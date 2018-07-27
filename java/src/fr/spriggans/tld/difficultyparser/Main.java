package fr.spriggans.tld.difficultyparser;

import java.io.IOException;
import java.io.UnsupportedEncodingException;
import java.util.List;
import java.util.Map;

import fr.spriggans.tld.difficultyparser.parameter.DifficutlyParameters;
import fr.spriggans.tld.difficultyparser.util.ArgumentsUtil;

public class Main {

	
	
	public static void main(String[] args) throws UnsupportedEncodingException, IOException {
		final Map<String, List<String>> params =  ArgumentsUtil.parseArgumentsToMap(args);
		String difficultyString = ArgumentsUtil.getDifficultyString(params);
		if(difficultyString != null) {
			Program prgm = new Program(new DifficutlyParameters(difficultyString));
			String fileLocation = prgm.generateSettingsFile();
			System.out.println("The settings file has been created successfully !");
			System.out.println("The file is located at : " + fileLocation);
		}
	}
	
}
