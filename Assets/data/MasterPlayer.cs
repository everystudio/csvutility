using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using csvutility;

public class MasterPlayerParam : CsvDataParam
{
	public int player_id;
	public string player_name;
	public int hp;
}

public class MasterPlayer : CsvData<MasterPlayerParam>
{
}
