namespace PotterFinal;

using System.Collections.Generic;
public class HouseDescription {
	private SqliteConnection Connection;
	private SqliteOps ops;
	void HouseDescription() {
		ops = new();
	}

	public string GetDescription(string housename) {
		// who tf made this nasticide API??
		Dictionary<string, string> parms = new();
		parms.Add("name", housename);
		List<string> desc = ops.SelectQueryWithParams("SELECT description FROM House WHERE name = :name LIMIT 1;", parms);
		if (desc.Count == 1)
			return desc[0];
		else {
			return null;
		}
	}
}