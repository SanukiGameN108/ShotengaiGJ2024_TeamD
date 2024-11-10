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
        4, 5, 20, 21, 70, 71, 72, 108, 109, 110, 
        120, 121, 122, 145, 146, 147, 148, 150, 151, 152, 170, 171, 172, 
        200, 201, 202, 210, 211, 212, 250, 251, 252, 270, 271, 272,
    };

    public static readonly int GROUND_X_COUNT = 350;
    public static readonly int GROUND_Y_COUNT = 3;
    public static readonly int GROUND_Z_COUNT = 5;
}
