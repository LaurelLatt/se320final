namespace PotterFinal;

using System.Collections.Generic;
public class HouseDescription {
	private SqliteOps ops;
	public HouseDescription() {
		ops = new SqliteOps();
	}

	public string GetDescription(string housename) {
		// who tf made this nasticide API??
		Dictionary<string, string> parms = new Dictionary<string, string>();
		parms.Add("name", housename);
		List<string> desc = ops.SelectQueryWithParams("SELECT description FROM House WHERE name = @name LIMIT 1;", parms);
		if (desc.Count == 1)
			return desc[0];
		else {
			return null;
		}
	}
}