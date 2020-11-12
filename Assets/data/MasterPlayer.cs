using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using csvutility;

public class MasterPlayerParam : CsvDataParam
{
	public int player_id { get; set; }
	public string player_name { get; set; }
	public int hp { get; set; }
}

public class MasterPlayer : CsvData<MasterPlayerParam>
{
}
