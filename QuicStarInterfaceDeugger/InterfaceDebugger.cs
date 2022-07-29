using QuickStarFormInterface;




namespace QuicStarInterfaceDeugger;

public class QuicStarInterfaceDeugger: QuickStarFormInterface.IPluginInterface
{
    public void PluginInit(AddonCommunication communication)
    {
        ShowWindow += ThrowException;
        HideWindow += ThrowException;
        CloseWindow += ThrowException;
        ShowSettingsWindow += ThrowException;
        ShowAboutWindow += ThrowException;
        Closing += ThrowException;
        
    }

    public int PluginMainThread()
    {
        throw new NotImplementedException();
    }

    public string PluginName => "Debugger";
    public string PluginVersion => "0.0.1";
    public string PluginAuthor => "WTD-5050-RD";
    public string PluginDescription => "A Plugin For debugging the plugin system";
    public AddonAddress[] UsableAddonsList
    {
        get => new[] { AddonAddress.DebugAddon0, AddonAddress.VapeController0 };
        set => throw new NotImplementedException();
    }


    void ThrowException()
    {
        throw new Exception("ACTION NOT IMPLIMENTED YET!");
    }
    
    //TODO impliment thease Actions
    public Action ShowWindow { get; set; }
    public Action HideWindow { get; set; }
    public Action CloseWindow { get; set; }
    public Action ShowSettingsWindow { get; set; }
    public Action ShowAboutWindow { get; set; }
    public Action Closing { get; set; }
}