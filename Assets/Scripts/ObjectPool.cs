using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;

    [SerializeField] private GameObject popUpHeadsPrefab;
    private Queue<GameObject> popUpHeadsPool = new Queue<GameObject>();
    [SerializeField] private int popUpHeadsPoolSize = 35;

    [SerializeField] private GameObject popUpTailsPrefab;
    private Queue<GameObject> popUpTailsPool = new Queue<GameObject>();
    [SerializeField] private int popUpTailsPoolSize = 35;

    [SerializeField] private GameObject popUpLuckyPrefab;
    private Queue<GameObject> popUpLuckyPool = new Queue<GameObject>();
    [SerializeField] private int popUpLuckyPoolSize = 35;

    public TMP_FontAsset JostHeavyEngAndRuss;
    public TMP_FontAsset notoSansJapaneseBold;
    public TMP_FontAsset notoSansChineseBold;
    public TMP_FontAsset nonoSansKoreanBold;

    public Transform parent;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

 

    void Start()
    {
        for (int i = 0; i < popUpHeadsPoolSize; i++)
        {
            GameObject headsPool = Instantiate(popUpHeadsPrefab);
            popUpHeadsPool.Enqueue(headsPool);
            headsPool.SetActive(false);
            headsPool.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            headsPool.transform.SetParent(parent);
        }
        for (int i = 0; i < popUpTailsPoolSize; i++)
        {
            GameObject tailsPool = Instantiate(popUpTailsPrefab);
            popUpTailsPool.Enqueue(tailsPool);
            tailsPool.SetActive(false);
            tailsPool.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            tailsPool.transform.SetParent(parent);
        }
        for (int i = 0; i < popUpLuckyPoolSize; i++)
        {
            GameObject luckyPool = Instantiate(popUpLuckyPrefab);
            popUpLuckyPool.Enqueue(luckyPool);
            luckyPool.SetActive(false);
            luckyPool.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            luckyPool.transform.SetParent(parent);
        }
    }

    public GameObject GetHeadsFromPool()
    {
        if(popUpHeadsPool.Count > 0)
        {
            GameObject heads = popUpHeadsPool.Dequeue();
            heads.SetActive(true);


            return heads;
        }
        else
        {
            GameObject heads = Instantiate(popUpHeadsPrefab);
            return heads;
        }
    }
    //----------------------------------------
    public GameObject GetTailsFromPool()
    {
        if (popUpTailsPool.Count > 0)
        {
            GameObject tails = popUpTailsPool.Dequeue();
            tails.SetActive(true);
            return tails;
        }
        else
        {
            GameObject tails = Instantiate(popUpTailsPrefab);
            return tails;
        }
    }
    //----------------------------------------
    public GameObject GetLuckyFromPool()
    {
        if (popUpLuckyPool.Count > 0)
        {
            GameObject lucky = popUpLuckyPool.Dequeue();
            lucky.SetActive(true);
            return lucky;
        }
        else
        {
            GameObject lucky = Instantiate(popUpLuckyPrefab);
            return lucky;
        }
    }

    public void ReturnHeadsToPool(GameObject heads)
    {
        popUpHeadsPool.Enqueue(heads);
        StartCoroutine(waitForAnimationToStop(heads));
    }

    IEnumerator waitForAnimationToStop(GameObject heads)
    {
        yield return new WaitForSeconds(0.75f);
        heads.SetActive(false);

    }
    //---------------------------------------------------------
    public void ReturnTailsToPool(GameObject tails)
    {
        popUpTailsPool.Enqueue(tails);
        StartCoroutine(waitForAnimationToStop2(tails));
    }

    IEnumerator waitForAnimationToStop2(GameObject tails)
    {
        yield return new WaitForSeconds(0.75f);
        tails.SetActive(false);

    }
    //---------------------------------------------------------
    public void ReturnLuckyToPool(GameObject lucky)
    {
        popUpLuckyPool.Enqueue(lucky);
        StartCoroutine(waitForAnimationToStop3(lucky));
    }

    IEnumerator waitForAnimationToStop3(GameObject lucky)
    {
        yield return new WaitForSeconds(0.88f);
        lucky.SetActive(false);

    }
}
