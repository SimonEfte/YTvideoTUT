using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class Tabs : MonoBehaviour
{

    public int StartFirstTime = 0;

    public GameObject TabUpgrades;
    public GameObject FakeTabUpgrades;
    public GameObject SpecialTabUpgrades;
    public GameObject FakeSpecialTabUpgrades;
    public GameObject AchevementsTab;
    public GameObject FakeAchevementsTab;
    public GameObject Achievements;
    public GameObject Upgrades;
    public GameObject SpecialUpgrades;
    public GameObject Info;
    public GameObject InfoTab;
    public GameObject FakeInfoTab;
    public GameObject Menu;
    public GameObject OpenMenuButton;
    public GameObject CloseMenuButton;

    public GameObject tabsOnSpecialButtonACHIEVEMENTS;
    public GameObject fakeTabsOnSpecialButtonACHIEVEMENTS;
    public GameObject TabsOnSpecialButtonsUPGRADES;
    public GameObject fakeTabsOnSpecialButtonsUPGRADES;
    public GameObject TabsOnSpecialButtonsSPECIALUPGRADES;
    public GameObject fakeTabsOnSpecialButtonsSPECIALUPGRADES;
    public GameObject TabsOnSpecialButtonsInfo;
    public GameObject fakeTabsOnSpecialButtonsInfo;
    public GameObject OutOfScrollsTabs;

    public GameObject settingTab;
    public GameObject settingTabClicker;
    public GameObject infoTab;
    public GameObject infoTabClicked;
    public GameObject socialsTab;
    public GameObject socialsTabClicker;
    public GameObject socialsScreen;
    public GameObject infoScreen;

    public Dropdown resolutionDropdown;
    
    Resolution[] resolutions;

    public void SettingTab()
    {
        socialsScreen.SetActive(false);
        infoScreen.SetActive(false);
        settingTabClicker.SetActive(true);
        settingTab.SetActive(false);
        infoTab.SetActive(true);
        infoTabClicked.SetActive(false);
        socialsTab.SetActive(true);
        socialsTabClicker.SetActive(false);
    }
    public void InfoTabSetting()
    {
        socialsScreen.SetActive(false);
        infoScreen.SetActive(true);
        settingTabClicker.SetActive(false);
        settingTab.SetActive(true);
        infoTab.SetActive(false);
        infoTabClicked.SetActive(true);
        socialsTab.SetActive(true);
        socialsTabClicker.SetActive(false);
    }
    public void SocialsTab()
    {
        socialsScreen.SetActive(true);
        infoScreen.SetActive(false);
        settingTabClicker.SetActive(false);
        settingTab.SetActive(true);
        infoTab.SetActive(true);
        infoTabClicked.SetActive(false);
        socialsTab.SetActive(false);
        socialsTabClicker.SetActive(true);
    }

    List<int> widths = new List<int>() {1920, 1600, 1366, 1280, 1176};
    List<int> heights = new List<int>() {1080, 900, 768, 720, 664};

    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 75;
        if(resolutionDropdown != null) 
        {
            dropdownValue = PlayerPrefs.GetInt("dropDownValueNumber");
            resolutionDropdown.value = dropdownValue; 
        }
    }

    public int dropdownValue;

    public void SetScreenSize(int index)
    {
        bool fullscreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width, height, fullscreen);
        dropdownValue = index;
        PlayerPrefs.SetInt("dropDownValueNumber", dropdownValue);
    }

    public GameObject saveGameBtn, quitChallengeBtn1, quitChallengeBtn2, quitChallengeBtn3, quitChallengeBtn4, saveGameText, resetBtn;
    public GameObject musicFrame, audioFrame;

    void Start()
    {
        if(LoadSaves.isMobileBuild == false)
        {
            isFullscreenOrWindowed = PlayerPrefs.GetInt("WindowedOrFullscreen");
            StartCoroutine(SetFullOrWind());
        }
        else
        {
            Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
            //Screen.SetResolution(1920, 1080, FullScreenMode.ExclusiveFullScreen);

            musicFrame.transform.localPosition = new Vector2(132, 295);
            audioFrame.transform.localPosition = new Vector2(132, 80);

            saveGameBtn.transform.localPosition = new Vector2(0,-124);
            saveGameBtn.transform.localScale = new Vector2(1.2f, 1.2f);

            quitChallengeBtn1.transform.localPosition = new Vector2(0, -240);
            quitChallengeBtn1.transform.localScale = new Vector2(0.85f, 0.85f);

            quitChallengeBtn2.transform.localPosition = new Vector2(0, -240);
            quitChallengeBtn2.transform.localScale = new Vector2(0.85f, 0.85f);

            quitChallengeBtn3.transform.localPosition = new Vector2(0, -240);
            quitChallengeBtn3.transform.localScale = new Vector2(0.85f, 0.85f);

            quitChallengeBtn4.transform.localPosition = new Vector2(0, -240);
            quitChallengeBtn4.transform.localScale = new Vector2(0.85f, 0.85f);

            saveGameText.transform.localPosition = new Vector2(0, -20); 
            saveGameText.transform.localScale = new Vector2(2, 2);

            resetBtn.transform.localPosition = new Vector2(0, -345f);
            resetBtn.transform.localScale = new Vector2(0.77f, 0.77f);
        }
      

        /*
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i< resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);


            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();*/
    }

    /*
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }*/

    IEnumerator SetFullOrWind()
    {
        yield return new WaitForSeconds(0.5f);

        if(isFullscreenOrWindowed == 0)
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
            Screen.SetResolution(1366, 768, FullScreenMode.Windowed);
        }
        if (isFullscreenOrWindowed == 1)
        {
            Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
        }
        if (isFullscreenOrWindowed == 2)
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
        }
    }

    public void QuitGame()
    {
        StartCoroutine(waitForKill());
    }

    IEnumerator waitForKill()
    {
        Application.Quit();
        yield return new WaitForSeconds(0.5f);
        System.Diagnostics.Process.GetCurrentProcess().Kill();
    }
   

    public void ClickOnMenu()
    {
        Menu.SetActive(true);
        OpenMenuButton.SetActive(false);
        CloseMenuButton.SetActive(true);
    }

    public GameObject choose;

    public void ExitMenu()
    {
        choose.SetActive(false);
        Menu.SetActive(false);
        CloseMenuButton.SetActive(false);
        OpenMenuButton.SetActive(true);
    }

    public void CloseMenu()
    {
        Menu.SetActive(false);
        CloseMenuButton.SetActive(false);
        OpenMenuButton.SetActive(true);
    }

    public void SpecialUpgradesClickOnAchievements()
    {
        Info.SetActive(false);
        Achievements.SetActive(true);
        SpecialUpgrades.SetActive(false);
        tabsOnSpecialButtonACHIEVEMENTS.SetActive(true);
        fakeTabsOnSpecialButtonACHIEVEMENTS.SetActive(false);
        TabsOnSpecialButtonsUPGRADES.SetActive(true);
        fakeTabsOnSpecialButtonsUPGRADES.SetActive(false);
        TabsOnSpecialButtonsSPECIALUPGRADES.SetActive(true);
        fakeTabsOnSpecialButtonsSPECIALUPGRADES.SetActive(false);
        TabsOnSpecialButtonsInfo.SetActive(true);
        fakeTabsOnSpecialButtonsInfo.SetActive(false);
        tabsOnSpecialButtonACHIEVEMENTS.SetActive(false);
        fakeTabsOnSpecialButtonACHIEVEMENTS.SetActive(true);
    }

    public void SpecialUpgradesClickOnInfo()
    {
        Info.SetActive(true);
        Achievements.SetActive(false);
        SpecialUpgrades.SetActive(false);
        tabsOnSpecialButtonACHIEVEMENTS.SetActive(true);
        fakeTabsOnSpecialButtonACHIEVEMENTS.SetActive(false);
        TabsOnSpecialButtonsUPGRADES.SetActive(true);
        fakeTabsOnSpecialButtonsUPGRADES.SetActive(false);
        TabsOnSpecialButtonsSPECIALUPGRADES.SetActive(true);
        fakeTabsOnSpecialButtonsSPECIALUPGRADES.SetActive(false);
        TabsOnSpecialButtonsInfo.SetActive(false);
        fakeTabsOnSpecialButtonsInfo.SetActive(true);
        tabsOnSpecialButtonACHIEVEMENTS.SetActive(true);
        fakeTabsOnSpecialButtonACHIEVEMENTS.SetActive(false);
    }
    public void SpecialUpgradesClickOnSpecialUpgrades()
    {
        Info.SetActive(false);
        Achievements.SetActive(false);
        SpecialUpgrades.SetActive(true);
        OutOfScrollsTabs.SetActive(true);
        tabsOnSpecialButtonACHIEVEMENTS.SetActive(true);
        fakeTabsOnSpecialButtonACHIEVEMENTS.SetActive(false);
        TabsOnSpecialButtonsUPGRADES.SetActive(true);
        fakeTabsOnSpecialButtonsUPGRADES.SetActive(false);
        TabsOnSpecialButtonsSPECIALUPGRADES.SetActive(false);
        fakeTabsOnSpecialButtonsSPECIALUPGRADES.SetActive(true);
        TabsOnSpecialButtonsInfo.SetActive(true);
        fakeTabsOnSpecialButtonsInfo.SetActive(false);
        tabsOnSpecialButtonACHIEVEMENTS.SetActive(true);
        fakeTabsOnSpecialButtonACHIEVEMENTS.SetActive(false);
    }

    public void SpecialUpgradesClickBackToUpgrades()
    {
        Upgrades.SetActive(true);
        SpecialUpgrades.SetActive(false);
        Info.SetActive(false);
        Achievements.SetActive(false);
        OutOfScrollsTabs.SetActive(false);
        TabUpgrades.SetActive(false);
        FakeTabUpgrades.SetActive(true);
        SpecialTabUpgrades.SetActive(true);
        FakeSpecialTabUpgrades.SetActive(false);
        AchevementsTab.SetActive(true);
        FakeAchevementsTab.SetActive(false);
        InfoTab.SetActive(true);
        FakeInfoTab.SetActive(false);
    }

    public void UpgradesPanelClickOnInfo()
    {
        Upgrades.SetActive(false);
        SpecialUpgrades.SetActive(false);
        Info.SetActive(true);
        OutOfScrollsTabs.SetActive(true);
        Achievements.SetActive(false);
        TabsOnSpecialButtonsUPGRADES.SetActive(true);
        fakeTabsOnSpecialButtonsUPGRADES.SetActive(false);
        TabsOnSpecialButtonsSPECIALUPGRADES.SetActive(true);
        fakeTabsOnSpecialButtonsSPECIALUPGRADES.SetActive(false);
        TabsOnSpecialButtonsInfo.SetActive(false);
        fakeTabsOnSpecialButtonsInfo.SetActive(true);
        tabsOnSpecialButtonACHIEVEMENTS.SetActive(true);
        fakeTabsOnSpecialButtonACHIEVEMENTS.SetActive(false);
    }

    public void SpecialUpgradesPanelClick()
    {
        Upgrades.SetActive(false);
        SpecialUpgrades.SetActive(true);
        Info.SetActive(false);
        OutOfScrollsTabs.SetActive(true);
        Achievements.SetActive(false);
        TabsOnSpecialButtonsUPGRADES.SetActive(true);
        fakeTabsOnSpecialButtonsUPGRADES.SetActive(false);
        TabsOnSpecialButtonsSPECIALUPGRADES.SetActive(false);
        fakeTabsOnSpecialButtonsSPECIALUPGRADES.SetActive(true);
        TabsOnSpecialButtonsInfo.SetActive(true);
        fakeTabsOnSpecialButtonsInfo.SetActive(false);
        tabsOnSpecialButtonACHIEVEMENTS.SetActive(true);
        fakeTabsOnSpecialButtonACHIEVEMENTS.SetActive(false);
    }
    public void AchievementsPanelClick()
    {
        Upgrades.SetActive(false);
        SpecialUpgrades.SetActive(false);
        Info.SetActive(false);
        OutOfScrollsTabs.SetActive(true);
        Achievements.SetActive(true);
        TabsOnSpecialButtonsUPGRADES.SetActive(true);
        fakeTabsOnSpecialButtonsUPGRADES.SetActive(false);
        TabsOnSpecialButtonsSPECIALUPGRADES.SetActive(true);
        fakeTabsOnSpecialButtonsSPECIALUPGRADES.SetActive(false);
        TabsOnSpecialButtonsInfo.SetActive(true);
        fakeTabsOnSpecialButtonsInfo.SetActive(false);
        tabsOnSpecialButtonACHIEVEMENTS.SetActive(false);
        fakeTabsOnSpecialButtonACHIEVEMENTS.SetActive(true);
    }

    public int isFullscreenOrWindowed;

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        
        if (isFullscreen == true)
        {
            isFullscreenOrWindowed = 1;
            Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
            PlayerPrefs.SetInt("WindowedOrFullscreen", isFullscreenOrWindowed);
        }
        if (isFullscreen == false)
        {
            isFullscreenOrWindowed = 2;
            Screen.fullScreenMode = FullScreenMode.Windowed;
            PlayerPrefs.SetInt("WindowedOrFullscreen", isFullscreenOrWindowed);
        }
    }
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Menu.activeInHierarchy == false) { ClickOnMenu(); }
            else { ExitMenu(); }
        }
    }

    public void GiveCoins()
    {
        GlobalCoins.CoinCount += 1000000000000000000000000f;
    }

    public void GiveInflationPoins()
    {
        AscendCoins.ascensionCoinAmount += 100;
    }

    public void RemoveCoins()
    {
        GlobalCoins.CoinCount = 0;
    }

    public void DeletePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
