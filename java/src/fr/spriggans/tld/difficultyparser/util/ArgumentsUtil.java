package fr.spriggans.tld.difficultyparser.util;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class ArgumentsUtil {

	private static final String OPT_HELP = "help";

	private static final String OPT_STRING = "s";

	private static final String OPT_PILGRIM = "-pilgrim";

	private static final String OPT_VOYAGER = "-voyager";

	private static final String OPT_STALKER = "-stalker";

	private static final String OPT_INTERLOPER = "-interloper";

	private static final String PILGRIM_STRING = "+38wgsDwKFDgoy15RAAA";

	// TODO
	private static final String VOYAGER_STRING = "";

	// TODO
	private static final String STALKER_STRING = "";

	private static final String INTERLOPER_STRING = "8sHMbj8PKxsn2aKOLgEA";

	/**
	 * List of existing parameters.
	 */
	private static final List<String> KNOWN_PARAMETERS = Arrays.asList(OPT_HELP, OPT_STRING, OPT_PILGRIM, OPT_VOYAGER,
			OPT_STALKER, OPT_INTERLOPER);

	/**
	 * Reads args and puts all that in a nice HashMap.<br/>
	 * If an error occurs, prints the help and an error message. Returns null if
	 * error in args.
	 */
	public static Map<String, List<String>> parseArgumentsToMap(String[] args) {
		Map<String, List<String>> params = parseArgs(args);
		boolean paramsOK = checkParamValues(params);
		if (!paramsOK) {
			System.err.println("");
			printHelp();
			return null;
		}
		return params;
	}

	/**
	 * Converts args into map.
	 */
	private static Map<String, List<String>> parseArgs(String[] args) {
		final Map<String, List<String>> res = new HashMap<>();
		List<String> options = null;
		for (int i = 0; i < args.length; i++) {
			final String arg = args[i];
			if (arg.charAt(0) == '-') {
				if (arg.length() < 2) {
					System.err.println("Error at argument " + arg);
					return null;
				}
				options = new ArrayList<>();
				res.put(arg.substring(1), options);
			} else if (options != null) {
				options.add(arg);
			} else {
				System.err.println("Illegal parameter usage");
				return null;
			}
		}
		return res;
	}

	/**
	 * Check if passed parameters are valid.
	 */
	private static boolean checkParamValues(Map<String, List<String>> params) {
		if (params == null || params.get(OPT_HELP) != null) {
			return false;
		}

		// We must set at least one parameter
		if (params.size() == 0) {
			System.err.println("At least one argument is required.");
			return false;
		}
		// We must set exactly one parameter
		if (params.size() != 1) {
			System.err.println("The command does not accept multiple arguments.");
			return false;
		}
		if (!checkParamValue(params, OPT_STRING, false, false)) {
			return false;
		}
		if (!checkParamValue(params, OPT_PILGRIM, true, false)) {
			return false;
		}
		if (!checkParamValue(params, OPT_VOYAGER, true, false)) {
			return false;
		}
		if (!checkParamValue(params, OPT_STALKER, true, false)) {
			return false;
		}
		if (!checkParamValue(params, OPT_INTERLOPER, true, false)) {
			return false;
		}

		// Checks extra not allowed arguments
		if (!checkUnknownArguments(params)) {
			return false;
		}
		return true;
	}

	/**
	 * @param isFlag
	 *            true if parameter is a flag (doesn't take value inputs)
	 * @param required
	 *            if true, param must be supplied
	 */
	private static boolean checkParamValue(Map<String, List<String>> params, String paramToCheck, boolean isFlag,
			boolean required) {
		List<String> param = params.get(paramToCheck);
		if (param == null) {
			// Parameter is not set
			if (required) {
				System.err.println("Parameter '-" + paramToCheck + "' is required.");
				return false;
			}
			return true;
		}
		if (param.size() > 0) {
			// If parameter is a flag, it must not have a value
			if (isFlag) {
				System.err.println("Parameter '-" + paramToCheck + "' does not accept values.");
				return false;
			}
		} else if (!isFlag) {
			// Parameter is set without value and is not a flag...
			System.err.println("Parameter '-" + paramToCheck + "' must have a value.");
			return false;
		}
		return true;
	}

	private static boolean checkUnknownArguments(Map<String, List<String>> params) {
		for (String suppliedParam : params.keySet()) {
			if (!KNOWN_PARAMETERS.contains(suppliedParam)) {
				System.err.println("Argument '-" + suppliedParam + "' is not a valid argument.");
				return false;
			}
		}
		return true;
	}

	private static void printHelp() {
		System.err.println(
				"This program creates a difficulty settings file to use with the provided mod 'TLD_CustomChallengeDifficulties'.");
		System.err.println(
				"You can either use predifined game difficulties, or get a custom difficulty from a string you can find in-game.");
		System.err.println("The file created should be located next to this jar file.");
		System.err.println("");
		System.err.println("Usage : java -jar ParseSettings.jar [options]");
		System.err.println("  Options:");
		System.err.println("  -help\t\t\tShows this screen");
		System.err.println("  -s <value>\t\tThe String value. You get this value from TLD's custom difficulty screen.");
		System.err.println(
				"\t\t\tThe value must be in the form 'AAAA-BBBB-CCCC-DDDD-EEEE', or 'AAAABBBBCCCCDDDDEEEE'; without the quotes.");
		System.err.println("  --pilgrim\t\tCreates a setings file corresponding to the Pilgrim difficulty.");
		System.err.println("  --voyager\t\tCreates a setings file corresponding to the Voyager difficulty.");
		System.err.println("  --stalker\t\tCreates a setings file corresponding to the Stalker difficulty.");
		System.err.println("  --interloper\t\tCreates a setings file corresponding to the Interloper difficulty.");
	}

	public static String getDifficultyString(Map<String, List<String>> params) {
		if (params == null) {
			return null;
		}
		String difficultyString = null;
		String argString = getParamValue(params, ArgumentsUtil.OPT_STRING);
		if (argString != null) {
			// We provided a argString ! Check its format.
			difficultyString = argString.replaceAll("-", "");
			if (difficultyString.length() != 20) {
				difficultyString = null;
				System.err.println("The difficulty String you provided is not in the correct format.");
				System.err.println(
						"The value must be in the form 'AAAA-BBBB-CCCC-DDDD-EEEE', or 'AAAABBBBCCCCDDDDEEEE'; without the quotes.");
			}
		} else {
			if (isFlagSet(params, ArgumentsUtil.OPT_PILGRIM)) {
				difficultyString = PILGRIM_STRING;
			} else if (isFlagSet(params, ArgumentsUtil.OPT_VOYAGER)) {
				difficultyString = VOYAGER_STRING;
			} else if (isFlagSet(params, ArgumentsUtil.OPT_STALKER)) {
				difficultyString = STALKER_STRING;
			} else if (isFlagSet(params, ArgumentsUtil.OPT_INTERLOPER)) {
				difficultyString = INTERLOPER_STRING;
			}
		}
		return difficultyString;
	}

	private static String getParamValue(Map<String, List<String>> params, String param) {
		List<String> p = params.get(param);
		if (p == null || p.size() == 0) {
			return null;
		}
		return p.get(0);
	}

	private static boolean isFlagSet(Map<String, List<String>> params, String param) {
		List<String> p = params.get(param);
		return p != null;
	}
}
