using UnityEngine;

/// <summary>
/// グラウンドの座標等に関する定数クラス。
/// 
/// この定数クラスの定数を編集することで、ステージの地形を変えることができる。
/// </summary>
public static class StageConstants
{
    public static readonly Vector3 GROUND_CUBE_SCALE = new Vector3(1, 1, 1);

    public static readonly Vector3 GROUND_STARTING_POSITION = new Vector3(-20, -5, -2);
    public static readonly int GROUND_X_COUNT = 1000;
    public static readonly int GROUND_Y_COUNT = 3;
    public static readonly int GROUND_Z_COUNT = 4;

    public static readonly Vector3 OBSTACLES_POSITION = new Vector3(0, -2.2f, -0.5f);
    public static readonly int OBSTACLES_COUNT = 50;

    public static readonly Vector3 TOILET_POSITION = new Vector3(0, -2.5f, 0);
    public static readonly int TOILET_COUNT = 25;

    public static readonly Vector3 TRASH_POSITION = new Vector3(0, -2.5f, 0);
    public static readonly int TRASH_COUNT = 100;  // 生成するゴミの数

    public static readonly int[] hollPosXList = {
        50, 51, 70, 71, 72, 
        108, 109, 110, 
        100, 101, 102, 103, 104, 
        140, 141, 142, 143, 144, 
        200, 201, 202, 203, 204, 205, 206, 
        270, 271, 272, 273, 274, 275, 276,
    };

    public static readonly float ABYSS_TOP_Y = -10f;
}
