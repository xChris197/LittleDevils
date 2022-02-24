using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Inventory : MonoBehaviour
{
    //Keeps tracks of which rings have been picked up
    public static bool carryRed = false;
    public static bool carryOrange = false;
    public static bool carryYellow = false;
    public static bool carryGreen = false;
    public static bool carryBlue = false;

    //Keeps track of which keys have been picked up
    public static bool hasTutorialKey = false;
    public static bool hasBathroomkey = false;

    public static bool carrySquareKey = false;
    public static bool carryCircleKey = false;
    public static bool carryHexagonKey = false;
    public static bool carryOctagonKey = false;
    public static bool carryDiamondKey = false;

    //Keeps track of whether the xylophone mallet has been picked up
    public static bool carryMallet = false;

    //keeps track of whether the battery has been picked up
    public bool hasBatteryOne = false;
    public bool hasBatteryTwo = false;
    public bool hasBatteryThree = false;
    public bool hasAllBattery = false;

    //keeps track of what gun piece has been picked up
    public bool hasGunHandle = false;
    public bool hasGunBody = false;
    public bool hasGunMuzzle = false;
    public bool hasGunCartridge = false;

    //these are references to the UI
    public GameObject PickUpUI;
    public GameObject circleKeyUI;
    public GameObject squareKeyUI;
    public GameObject diamondKeyUI;
    public GameObject hexagonKeyUI;
    public GameObject octogonKeyUI;
    public GameObject batteryBackgoundUI;
    public GameObject batteryOneUI;
    public GameObject batteryTwoUI;
    public GameObject batteryThreeUI;
    public GameObject malletUI;
    public GameObject hanoiBackground;
    public GameObject hanoiRingRed;
    public GameObject hanoiRingOrange;
    public GameObject hanoiRingYellow;
    public GameObject hanoiRingGreen;
    public GameObject hanoiRingBlue;
    public GameObject GunBackgroundUI;
    public GameObject GunHandleUI;
    public GameObject GunBodyUI;
    public GameObject GunMuzzleUI;
    public GameObject GunCartridgeUI;

    public SCR_PlayerCasting casting;

    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if(player != null)
        {
            casting = GameObject.Find("Player").GetComponent<SCR_PlayerCasting>();
        }

        //this disables all the UI right at the begining
        carryCircleKey = false;
        carrySquareKey = false;
        carryDiamondKey = false;
        carryHexagonKey = false;
        carryOctagonKey = false;
        hasTutorialKey = false;
        hasBathroomkey = false;
        hasBatteryOne = false;
        hasBatteryTwo = false;
        hasBatteryThree = false;
        carryMallet = false;
        carryRed = false;
        carryOrange = false;
        carryYellow = false;
        carryGreen = false;
        carryBlue = false;
        hasGunHandle = false;
        hasGunBody = false;
        hasGunMuzzle = false;
        hasGunCartridge = false;

    }

    void Update()
    {

        if (carryCircleKey == true || hasTutorialKey == true)
        {

            circleKeyUI.SetActive(true);

        }
        else
        {

            circleKeyUI.SetActive(false);

        }
        if (carrySquareKey == true)
        {

            squareKeyUI.SetActive(true);

        }
        else
        {

            squareKeyUI.SetActive(false);

        }
        if (carryDiamondKey == true || hasBathroomkey == true)
        {

            diamondKeyUI.SetActive(true);

        }
        else
        {

            diamondKeyUI.SetActive(false);

        }
        if (carryHexagonKey == true)
        {

            hexagonKeyUI.SetActive(true);

        }
        else
        {

            hexagonKeyUI.SetActive(false);

        }
        if (carryOctagonKey == true)
        {

            octogonKeyUI.SetActive(true);

        }
        else
        {

            octogonKeyUI.SetActive(false);

        }
        if (hasBatteryOne == true)
        {

            batteryOneUI.SetActive(true);
            batteryBackgoundUI.SetActive(true);

        }
        else
        {

            batteryOneUI.SetActive(false);

        }
        if (hasBatteryTwo == true)
        {

            batteryTwoUI.SetActive(true);
            batteryBackgoundUI.SetActive(true);

        }
        else
        {

            batteryTwoUI.SetActive(false);

        }
        if (hasBatteryThree == true)
        {

            batteryThreeUI.SetActive(true);
            batteryBackgoundUI.SetActive(true);

        }
        else
        {

            batteryThreeUI.SetActive(false);

        }
        if (hasBatteryOne == true && hasBatteryTwo == true && hasBatteryThree == true)
        {

            hasAllBattery = true;

        }
        else
        {

            hasAllBattery = false;

        }
        if (carryMallet == true)
        {

            malletUI.SetActive(true);

        }
        else
        {

            malletUI.SetActive(false);

        }
        if (carryRed == true)
        {

            hanoiBackground.SetActive(true);
            hanoiRingRed.SetActive(true);

        }
        else
        {

            hanoiRingRed.SetActive(false);

        }
        if (carryOrange == true)
        {

            hanoiBackground.SetActive(true);
            hanoiRingOrange.SetActive(true);

        }
        else
        {

            hanoiRingOrange.SetActive(false);

        }
        if (carryYellow == true)
        {

            hanoiBackground.SetActive(true);
            hanoiRingYellow.SetActive(true);

        }
        else
        {

            hanoiRingYellow.SetActive(false);

        }
        if (carryGreen == true)
        {

            hanoiBackground.SetActive(true);
            hanoiRingGreen.SetActive(true);

        }
        else
        {

            hanoiRingGreen.SetActive(false);

        }
        if (carryBlue == true)
        {

            hanoiBackground.SetActive(true);
            hanoiRingBlue.SetActive(true);

        }
        else
        {

            hanoiRingBlue.SetActive(false);

        }
        if (hasGunHandle == true)
        {

            GunBackgroundUI.SetActive(true);
            GunHandleUI.SetActive(true);

        }
        else
        {

            GunHandleUI.SetActive(false);

        }
        if (hasGunBody == true)
        {

            GunBackgroundUI.SetActive(true);
            GunBodyUI.SetActive(true);

        }
        else
        {

            GunBodyUI.SetActive(false);

        }
        if (hasGunMuzzle == true)
        {

            GunBackgroundUI.SetActive(true);
            GunMuzzleUI.SetActive(true);

        }
        else
        {

            GunMuzzleUI.SetActive(false);

        }
        if (hasGunCartridge == true)
        {

            GunBackgroundUI.SetActive(true);
            GunCartridgeUI.SetActive(true);

        }
        else
        {

            GunCartridgeUI.SetActive(false);

        }
        if (hasGunHandle == false && hasGunBody == false && hasGunMuzzle == false && hasGunCartridge == false)
        {

            GunBackgroundUI.SetActive(false);

        }
        if (hasGunHandle == true && hasGunBody == true && hasGunMuzzle == true && hasGunCartridge == true)
        {

            GunBackgroundUI.SetActive(false);
            GunBodyUI.SetActive(false);
            GunHandleUI.SetActive(false);
            GunMuzzleUI.SetActive(false);
            GunCartridgeUI.SetActive(false);

        }
        if (hasBatteryOne == false && hasBatteryTwo == false && hasBatteryThree == false)
        {

            batteryBackgoundUI.SetActive(false);

        }
        if (carryRed == false && carryOrange == false && carryYellow == false && carryGreen == false && carryBlue == false)
        {

            hanoiBackground.SetActive(false);

        }


    }
}
