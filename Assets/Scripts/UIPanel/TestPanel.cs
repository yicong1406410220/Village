using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestPanel : PanelBase {

    public static TestPanel instance;

    public override void Init(params object[] args)
    {
        base.Init(args);
        layer = PanelLayer.Panel;
        instance = this;
        
    }

    public override void OnShowing()
    {
        base.OnShowing();

    }


}
