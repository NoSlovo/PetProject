using IPAD_simulator.Enums;
using IPAD_simulator.Scripts;
using UnityEditor.DeviceSimulation;
using UnityEngine;
using UnityEngine.UIElements;


public class SimulatorWindowPlugin : DeviceSimulatorPlugin
{
    public override string title { get; } = "SimulatorAdaptive";

    private bool _isTablet;

    public override void OnCreate()
    {
        deviceSimulator.touchScreenInput += touchEvent => { };
    }

    public override VisualElement OnCreateUI()
    {
       
        VisualElement root = new VisualElement();
        CreateUI(root);
        return root;
    }

    private void CreateUI(VisualElement root)
    {
        var activePresets = "None";
        var nameLabelTablet = new Label($"{activePresets}");
        var nameLabelIPhone = new Label("ActiveIPhone");
        var buttonActiveIPhone = new Button{text = "ActivePresetIPhone"};
        buttonActiveIPhone.clicked += () => ActivePreset(nameLabelIPhone,SystemTypeDevice.IPhone);
        var nameLabelIPad = new Label("ActiveIPad");
        var buttonActiveIPad = new Button{text = "ActivePresetIPad"};
        
        root.Add(nameLabelTablet);
        root.Add(nameLabelIPhone);
        root.Add(buttonActiveIPhone);
        root.Add(nameLabelIPad);
        root.Add(buttonActiveIPad);
    }

    private BaseAdapter[] GetAdapters()
    {
        return  Object.FindObjectsOfType<BaseAdapter>();
    }

    private void ActivePreset(Label label,SystemTypeDevice systemTypeView)
    {
        var elements = GetAdapters();
        foreach (var element in elements)
        {
            element.ActiveView(systemTypeView);
        }
    }
}
