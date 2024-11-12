using UnityEngine;

/// <summary>
/// グラウンドの座標等に関する定数クラス。
/// 
/// この定数クラスの定数を編集することで、ステージの地形を変えることができる。
/// </summary>
public static class StageConstants
{
    public static readonly Vector3 GROUND_CUBE_SCALE = new Vector3(1, 1, 1);
    public static readonly Vector3 INITIAL_POSITION = new Vector3(-20, -5, 0);

    public static readonly int[] hollPosXList = {
        4, 5, 20, 21, 70, 71, 72, 
        108, 109, 110, 
        100, 101, 102, 103, 104, 
        120, 121, 122, 123, 124, 
        140, 141, 142, 143, 144, 
        200, 201, 202, 203, 204, 205, 206, 
        220, 221, 222, 223, 224, 225, 226, 
        250, 251, 252, 253, 254, 255, 256, 
        270, 271, 272, 273, 274, 275, 276
    };

    public static readonly int GROUND_X_COUNT = 350;
    public static readonly int GROUND_Y_COUNT = 3;
    public static readonly int GROUND_Z_COUNT = 5;

    public static readonly float ABYSS_TOP_Y = -10f;
}
