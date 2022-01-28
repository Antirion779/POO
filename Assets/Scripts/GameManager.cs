using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("ViewPort")] [SerializeField] private GameObject characterViewPort;
    [SerializeField] private GameObject equipementViewPort;
    int _numberOfCharacterSpawn = 0;
    int _numberOfEquipementSpawn = 0;

    [Header("Button")] [SerializeField] private Button goodBoyButton;
    [SerializeField] private Button badBoyButton;
    [SerializeField] private Button offensifItemButton;
    [SerializeField] private Button defensifItemButton;

    public void SpawnCharacters()
    {
        if (_numberOfCharacterSpawn > 2) //redimensionne pour le scroll
        {
            characterViewPort.GetComponent<RectTransform>().offsetMin += new Vector2(0, -100);
        }

        for (int i = 0; i < 3; i++)
        {
            if (Random.value > 0.5f) //is a good boy
            {
                Button spawnedCharacter = Instantiate(goodBoyButton);
                spawnedCharacter.transform.SetParent(characterViewPort.transform);

                GoodboyData goodBoy = spawnedCharacter.GetComponent<GoodboyData>();

                goodBoy.name = (Random.Range(1, 100)).ToString();
                goodBoy.life = Random.Range(50, 150);
                goodBoy.armor = Random.Range(0, 10);
                goodBoy.damage = Random.Range(10, 100);
                goodBoy.money = Random.Range(1, 1000);
                goodBoy.isMagical = (Random.value > 0.5f); //1 chance / 2 d'être magique 
                goodBoy.range = Random.Range(20, 220);
                goodBoy.reputation = Random.Range(0, 5000);

                switch (goodBoy.isMagical)
                {
                    case true:
                        goodBoy.role = GoodboyData.Class.Mage;
                        spawnedCharacter.GetComponentInChildren<Text>().text =
                            goodBoy.role.ToString() + goodBoy.name.ToString();
                        break;
                    case false:
                        if (goodBoy.range > 120)
                        {
                            goodBoy.role = GoodboyData.Class.Archer;
                            spawnedCharacter.GetComponentInChildren<Text>().text =
                                goodBoy.role.ToString() + goodBoy.name.ToString();
                            break;
                        }
                        else
                        {
                            goodBoy.role = GoodboyData.Class.Guerrier;
                            spawnedCharacter.GetComponentInChildren<Text>().text =
                                goodBoy.role.ToString() + goodBoy.name.ToString();
                            break;
                        }
                }

                goodBoy.Info();

                InventoryManager.instance.charactersList.Add(goodBoy);

            }
            else //is a bad boy
            {
                Button spawnedCharacter = Instantiate(badBoyButton);
                spawnedCharacter.transform.SetParent(characterViewPort.transform);

                BadBoyData badBoy = spawnedCharacter.GetComponent<BadBoyData>();

                badBoy.name = (Random.Range(1, 100)).ToString();
                badBoy.life = Random.Range(50, 150);
                badBoy.armor = Random.Range(0, 10);
                badBoy.damage = Random.Range(10, 100);
                badBoy.money = Random.Range(1, 10000);
                badBoy.isMagical = (Random.value > 0.5f); //1 chance / 2 d'être magique 
                badBoy.range = Random.Range(20, 220);
                badBoy.evilness = Random.Range(0, 5000);

                switch (badBoy.isMagical)
                {
                    case true:
                        badBoy.role = BadBoyData.Class.DarkMage;
                        spawnedCharacter.GetComponentInChildren<Text>().text =
                            badBoy.role.ToString() + badBoy.name.ToString();
                        break;
                    case false:
                        if (badBoy.range > 120)
                        {
                            badBoy.role = BadBoyData.Class.Skeleton;
                            spawnedCharacter.GetComponentInChildren<Text>().text =
                                badBoy.role.ToString() + badBoy.name.ToString();
                            break;
                        }
                        else
                        {
                            badBoy.role = BadBoyData.Class.Oger;
                            spawnedCharacter.GetComponentInChildren<Text>().text =
                                badBoy.role.ToString() + badBoy.name.ToString();
                            break;
                        }
                }

                badBoy.Info();

                InventoryManager.instance.charactersList.Add(badBoy);
            }

        }

        _numberOfCharacterSpawn++;
    }

    public void SpawnEquipement()
    {
        if (_numberOfEquipementSpawn > 2) //redimensionne pour le scroll
        {
            equipementViewPort.GetComponent<RectTransform>().offsetMin += new Vector2(0, -100);
        }

        for (int i = 0; i < 3; i++)
        {
            if (Random.value > 0.5f) //is a offensif Item
            {
                Button spawnedItem = Instantiate(offensifItemButton);
                spawnedItem.transform.SetParent(equipementViewPort.transform);

                OffensifItemData offensifItem = spawnedItem.GetComponent<OffensifItemData>();


                //setup
                offensifItem.type = Items.TypeEnum.offensif_Bonus;
                offensifItem.rarity = (Items.Rarity) Random.Range(0, 5);
                offensifItem.enchantBonus = offensifItem.GetRarityBonus(offensifItem.rarity);
                offensifItem.level = Random.Range(1, 100);
                offensifItem.mainStat = Random.Range(1, 100);
                offensifItem.mainStatBonus = (int)(offensifItem.mainStat * offensifItem.enchantBonus * offensifItem.level);
                offensifItem.weaponType = (OffensifItemData.WeaponTypeEnum)Random.Range(0, 2);

                offensifItem.name = offensifItem.rarity + " " + offensifItem.weaponType;
                spawnedItem.GetComponentInChildren<Text>().text =
                     offensifItem.name;

                switch (offensifItem.rarity)
                {
                    case Items.Rarity.Uncommun:
                        spawnedItem.GetComponent<Image>().color = Color.gray;
                        break;
                    case Items.Rarity.Commun:
                        spawnedItem.GetComponent<Image>().color = Color.green;
                        break;
                    case Items.Rarity.Rare:
                        spawnedItem.GetComponent<Image>().color = Color.blue;
                        break;
                    case Items.Rarity.Epic:
                        spawnedItem.GetComponent<Image>().color = Color.magenta;
                        break;
                    case Items.Rarity.Legendary:
                        spawnedItem.GetComponent<Image>().color = Color.yellow;
                        break;
                }
            }
            else
            {
                Button spawnedItem = Instantiate(defensifItemButton);
                spawnedItem.transform.SetParent(equipementViewPort.transform);

                DefensifItemData defensifItem = spawnedItem.GetComponent<DefensifItemData>();


                //setup
                defensifItem.type = Items.TypeEnum.defensif_Malus;
                defensifItem.rarity = (Items.Rarity)Random.Range(0, 5);
                defensifItem.enchantBonus = defensifItem.GetRarityBonus(defensifItem.rarity);
                defensifItem.level = Random.Range(1, 100);
                defensifItem.mainStat = Random.Range(1, 100);
                defensifItem.mainStatBonus = (int)(defensifItem.mainStat * defensifItem.enchantBonus * defensifItem.level);
                defensifItem.weaponType = (DefensifItemData.WeaponTypeEnum)Random.Range(0, 2);

                defensifItem.name = defensifItem.rarity + " " + defensifItem.weaponType;
                spawnedItem.GetComponentInChildren<Text>().text =
                    defensifItem.name;
                switch (defensifItem.rarity)
                {
                    case Items.Rarity.Uncommun:
                        spawnedItem.GetComponent<Image>().color = Color.gray;
                        break;
                    case Items.Rarity.Commun:
                        spawnedItem.GetComponent<Image>().color = Color.green;
                        break;
                    case Items.Rarity.Rare:
                        spawnedItem.GetComponent<Image>().color = Color.blue;
                        break;
                    case Items.Rarity.Epic:
                        spawnedItem.GetComponent<Image>().color = Color.magenta;
                        break;
                    case Items.Rarity.Legendary:
                        spawnedItem.GetComponent<Image>().color = Color.yellow;
                        break;
                }
            }
        }

        _numberOfEquipementSpawn++;
    }
}
