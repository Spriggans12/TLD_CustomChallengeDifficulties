package fr.spriggans.tld.difficultyparser.parameter;

public class Field<E extends Enum<E>> {

	private E enumValue;

	private final String description;

	private final String variableName;

	public Field(String description, String variableName) {
		this.description = description;
		this.variableName = variableName;
	}

	public String getDescription() {
		return description;
	}

	public E getEnumValue() {
		return enumValue;
	}

	public void setEnumValue(E enumValue) {
		this.enumValue = enumValue;
	}

	public String getVariableName() {
		return variableName;
	}
}
