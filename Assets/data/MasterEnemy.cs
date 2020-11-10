using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using csvutility;

public class MasterEnemyParam : CsvDataParam
{
	public int enemy_id { get; set; }
	public string name { get; set; }
	public string sprite_name { get; set; }
	public string color { get; set; }
	public int level_hp { get; set; }
	public int level_attack { get; set; }
	public int level_defence { get; set; }
	public int level_speed { get; set; }
	public int size { get; set; }
	public string attribute { get; set; }

	public int drop_prob { get; set; }
	public int drop_item_id { get; set; }
	public int drop_item_id_2 { get; set; }
	public int drop_item_id_3 { get; set; }
	public int exp { get; set; }
	public int boss_level_add { get; set; }

	private const int HP_BASE = 10;
	private const int HP_PITCH = 3;

	private const int ATTACK_BASE = 5;
	private const int ATTACK_PITCH = 3;

	private const int DEFENCE_BASE = 5;
	private const int DEFENCE_PITCH = 5;

	private const int SPEED_BASE = 5;
	private const int SPEED_PITCH = 3;
}

public class MasterEnemy :CsvData<MasterEnemyParam> {
}
