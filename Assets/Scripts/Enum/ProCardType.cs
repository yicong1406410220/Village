//道具牌的类型
public enum ProCardType{
    Attack, //武器牌
    Spell, //法术牌
    Toughness, //防御牌
    AddHP //回复牌
}

//场景类型
public enum SceneType
{
    Start,
    Map,
    Game,
}

//场地类型
public enum FloorType
{
    Null,//空场地
    Combo,//连击
    StickTo, //坚守阵地
    OnceMore, //再进行一个回合
    Gold, //金币
    Addlive, //添加体力

}

