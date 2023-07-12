using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FilledTypeTest : MonoBehaviour
{
    public Image filledTypeImg;

    private void Awake()
    {
        filledTypeImg.fillAmount = 1.0f;

    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(passedCoolTime(1f));
    }

    // Update is called once per frame
    void Update()
    {
    }

    //private void FixedUpdate()
    //{
    //    if(0<filledTypeImg.fillAmount)
    //    {
    //    filledTypeImg.fillAmount -= (Time.deltaTime) * 0.1f;
    //    }

    //}

    private IEnumerator passedCoolTime(float coolTimeDelay)
    {
        float coolTimePercent = 0.003f;
        while(0 < filledTypeImg.fillAmount)
        {
            //이 만큼 시간이 걸린다.
            yield return new WaitForSeconds(coolTimeDelay);

            //시간이 지나간 다음에 처리한다.
            filledTypeImg.fillAmount -= coolTimePercent;
        }
    }
}
