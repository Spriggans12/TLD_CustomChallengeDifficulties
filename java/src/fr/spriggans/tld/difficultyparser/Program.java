package fr.spriggans.tld.difficultyparser;

import java.io.IOException;
import java.io.UnsupportedEncodingException;

import fr.spriggans.tld.difficultyparser.parameter.DifficutlyParameters;
import fr.spriggans.tld.difficultyparser.writer.FileWritter;

public class Program {

	private static final String FILE = "./difficulty-settings.txt";

	private DifficutlyParameters diffParams;

	public Program(DifficutlyParameters diffParams) {
		this.diffParams = diffParams;
	}

	/**
	 * @return file location
	 */
	public String generateSettingsFile() throws UnsupportedEncodingException, IOException {
		return FileWritter.generate(FILE, this.diffParams);
	}

}
