using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private GameObject characterViewPort;
    [SerializeField] private Button goodBoyButton;

    [SerializeField] private List<Characters> charactersList;


    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("plus d'une instance de GameManger dans la scène !");
            return;
        }
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCharacters()
    {
        Button spawnedCharacter = Instantiate(goodBoyButton);
        spawnedCharacter.transform.SetParent(characterViewPort.transform);

        GoodboyData goodBoy = spawnedCharacter.GetComponent<GoodboyData>();

        goodBoy.name = "A";
        goodBoy.life = Random.Range(50, 150);
        goodBoy.armor = Random.Range(0, 10);
        goodBoy.reputation = Random.Range(0, 5000);

        goodBoy.Info();

        charactersList.Add(goodBoy);
    }
}
