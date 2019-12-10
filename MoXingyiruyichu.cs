using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoXingyiruyichu : MonoBehaviour {
    public GameObject duixiang;
    public GameObject duixiang1;
    private GameObject Canvass;
    private GameObject KuangKuang;

    private GameObject WuPin;
    private GameObject ipad;
    private GameObject ZhaoPian;
    private GameObject ShouBiao;
    private GameObject ShouJi;
    private GameObject XiangLian;
    private GameObject YinHangKa;
    // Use this for initialization
    #region//单例
    private static MoXingyiruyichu instance;
    public static MoXingyiruyichu GetInstance()
    {
        return instance;
    }

    void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
    }
    #endregion

    void Start () {
        Canvass = GameObject.Find("Canvas");
        KuangKuang = Canvass.transform.Find("选择模型").gameObject;
        WuPin = GameObject.Find("WuPin");
        ipad = WuPin.transform.Find("ipad").gameObject;
        ZhaoPian = WuPin.transform.Find("ZhaoPian").gameObject;
        ShouJi = WuPin.transform.Find("ShouJi").gameObject;
        ShouBiao = WuPin.transform.Find("ShouBiao").gameObject;
        XiangLian = WuPin.transform.Find("XiangLian").gameObject;
        YinHangKa = WuPin.transform.Find("YinHangKa").gameObject;

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            OnMouseExit();
        }
    }
    private void OnMouseEnter()
    {
        duixiang.SetActive(false);
        duixiang1.SetActive(true);
    }
    public void OnMouseExit()
    {
        duixiang1.SetActive(false);
        duixiang.SetActive(true);

        if (duixiang1.name == "ipad (1)")
        {
            if (duixiang1.transform.localPosition.y > 0.0835 && duixiang1.transform.localPosition.y < 0.25 &&
                duixiang1.transform.localPosition.z > 0.6 && duixiang1.transform.localPosition.z < 0.94)
            {
                if (duixiang1.transform.localPosition.x > 0.54 && duixiang1.transform.localPosition.x < 0.77)
                {
                    HuanKuangKuang1();
                    KuangKuang.transform.Find("框框1/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("6");
                    KuangKuang.transform.Find("框框1").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);
                   
                }
                else if (duixiang1.transform.localPosition.x > 0.2 && duixiang1.transform.localPosition.x < 0.41)
                {
                    HuanKuangKuang2();
                    KuangKuang.transform.Find("框框2/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("6");
                    KuangKuang.transform.Find("框框2").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);
                }
                else if (duixiang1.transform.localPosition.x > -0.08 && duixiang1.transform.localPosition.x < 0.12)
                {
                    huanKuangKuang3();
                    KuangKuang.transform.Find("框框3/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("6");
                    KuangKuang.transform.Find("框框3").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);
                }
                else if (duixiang1.transform.localPosition.x > -0.47 && duixiang1.transform.localPosition.x < -0.25)
                {
                    huanKuangKuang4();
                    KuangKuang.transform.Find("框框4/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("6");
                    KuangKuang.transform.Find("框框4").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);
                }
                else if (duixiang1.transform.localPosition.x > -0.79 && duixiang1.transform.localPosition.x < -0.58)
                {
                    huanKuangKuang5();
                    KuangKuang.transform.Find("框框5/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("6");
                    KuangKuang.transform.Find("框框5").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);
                }
            }

            duixiang1.transform.localPosition = new Vector3(-0.153f, 0.318f, 0.031f);
        }
        else if (duixiang1.name == "ZhaoPian (1)")
        {
            if (duixiang1.transform.localPosition.y > 0.0835 && duixiang1.transform.localPosition.y < 0.20 &&
                 duixiang1.transform.localPosition.z > 0.62 && duixiang1.transform.localPosition.z < 0.93)
            {
                if (duixiang1.transform.localPosition.x > 0.58 && duixiang1.transform.localPosition.x < 0.79)
                {
                    HuanKuangKuang1();
                    KuangKuang.transform.Find("框框1/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("1");
                    KuangKuang.transform.Find("框框1").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > 0.23 && duixiang1.transform.localPosition.x < 0.44)
                {
                    HuanKuangKuang2();
                    KuangKuang.transform.Find("框框2/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("1");
                    KuangKuang.transform.Find("框框2").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > -0.12 && duixiang1.transform.localPosition.x < 0.10)
                {
                    huanKuangKuang3();
                    KuangKuang.transform.Find("框框3/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("1");
                    KuangKuang.transform.Find("框框3").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > -0.48 && duixiang1.transform.localPosition.x < -0.27)
                {
                    huanKuangKuang4();
                    KuangKuang.transform.Find("框框4/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("1");
                    KuangKuang.transform.Find("框框4").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > -0.81 && duixiang1.transform.localPosition.x < -0.59)
                {
                    huanKuangKuang5();
                    KuangKuang.transform.Find("框框5/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("1");
                    KuangKuang.transform.Find("框框5").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11");
                    duixiang.SetActive(false);

                }
                Invoke("tanhui", 2f);
            }
            duixiang1.transform.localPosition = new Vector3(0.1586684f, 0.4700461f, 0.2755616f);
        }


        else if (duixiang1.name == "ShouBiao (1)")
        {
            if (duixiang1.transform.localPosition.y > 0.0835 && duixiang1.transform.localPosition.y < 0.135 &&
                 duixiang1.transform.localPosition.z > 0.65 && duixiang1.transform.localPosition.z < 0.94)
            {
                if (duixiang1.transform.localPosition.x > 0.55 && duixiang1.transform.localPosition.x < 0.75)
                {
                    HuanKuangKuang1();
                    KuangKuang.transform.Find("框框1/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("5");
                    KuangKuang.transform.Find("框框1").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > 0.2 && duixiang1.transform.localPosition.x < 0.41)
                {
                    HuanKuangKuang2();
                    KuangKuang.transform.Find("框框2/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("5");
                    KuangKuang.transform.Find("框框2").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > -0.08 && duixiang1.transform.localPosition.x < 0.12)
                {
                    huanKuangKuang3();
                    KuangKuang.transform.Find("框框3/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("5");
                    KuangKuang.transform.Find("框框3").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > -0.47 && duixiang1.transform.localPosition.x < -0.25)
                {
                    huanKuangKuang4();
                    KuangKuang.transform.Find("框框4/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("5");
                    KuangKuang.transform.Find("框框4").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > -0.79 && duixiang1.transform.localPosition.x < -0.58)
                {
                    huanKuangKuang5();
                    KuangKuang.transform.Find("框框5/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("5");
                    KuangKuang.transform.Find("框框5").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
            }
            duixiang1.transform.localPosition = new Vector3(0.1787053f, 0.3780983f, 0.3724418f);
        }

        else if (duixiang1.name == "ShouJi (1)")
        {
            if (duixiang1.transform.localPosition.y > 0.0835 && duixiang1.transform.localPosition.y < 0.21 &&
                   duixiang1.transform.localPosition.z > 0.6 && duixiang1.transform.localPosition.z < 0.94)
            {
                if (duixiang1.transform.localPosition.x > 0.54 && duixiang1.transform.localPosition.x < 0.77)
                {
                    HuanKuangKuang1();
                    KuangKuang.transform.Find("框框1/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("4");
                    KuangKuang.transform.Find("框框1").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > 0.2 && duixiang1.transform.localPosition.x < 0.41)
                {
                    HuanKuangKuang2();
                    KuangKuang.transform.Find("框框2/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("4");
                    KuangKuang.transform.Find("框框2").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > -0.08 && duixiang1.transform.localPosition.x < 0.12)
                {
                    huanKuangKuang3();
                    KuangKuang.transform.Find("框框3/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("4");
                    KuangKuang.transform.Find("框框3").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > -0.47 && duixiang1.transform.localPosition.x < -0.25)
                {
                    huanKuangKuang4();
                    KuangKuang.transform.Find("框框4/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("4");
                    KuangKuang.transform.Find("框框4").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > -0.79 && duixiang1.transform.localPosition.x < -0.58)
                {
                    huanKuangKuang5();
                    KuangKuang.transform.Find("框框5/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("4");
                    KuangKuang.transform.Find("框框5").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
            }
            duixiang1.transform.localPosition = new Vector3(0.1890347f, 0.3452218f, 0.4327669f);
        }

        else if (duixiang1.name == "XiangLian (1)")
        {
            if (duixiang1.transform.localPosition.y > 0.0835 && duixiang1.transform.localPosition.y < 0.25 &&
                 duixiang1.transform.localPosition.z > 0.6 && duixiang1.transform.localPosition.z < 0.94)
            {
                if (duixiang1.transform.localPosition.x > 0.54 && duixiang1.transform.localPosition.x < 0.77)
                {
                    HuanKuangKuang1();
                    KuangKuang.transform.Find("框框1/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("3");
                    KuangKuang.transform.Find("框框1").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > 0.2 && duixiang1.transform.localPosition.x < 0.41)
                {
                    HuanKuangKuang2();
                    KuangKuang.transform.Find("框框2/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("3");
                    KuangKuang.transform.Find("框框2").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > -0.08 && duixiang1.transform.localPosition.x < 0.12)
                {
                    huanKuangKuang3();
                    KuangKuang.transform.Find("框框3/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("3");
                    KuangKuang.transform.Find("框框3").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > -0.47 && duixiang1.transform.localPosition.x < -0.25)
                {
                    huanKuangKuang4();
                    KuangKuang.transform.Find("框框4/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("3");
                    KuangKuang.transform.Find("框框4").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > -0.79 && duixiang1.transform.localPosition.x < -0.58)
                {
                    huanKuangKuang5();
                    KuangKuang.transform.Find("框框5/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("3");
                    KuangKuang.transform.Find("框框5").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
            }
            duixiang1.transform.localPosition = new Vector3(-0.1146825f, 0.462f, 0.397f);
        }
        else if (duixiang1.name == "YinHangKa (1)")
        {
            if (duixiang1.transform.localPosition.y > 0.0835 && duixiang1.transform.localPosition.y < 0.136 &&
                    duixiang1.transform.localPosition.z > 0.6 && duixiang1.transform.localPosition.z < 0.94)
            {
                if (duixiang1.transform.localPosition.x > 0.54 && duixiang1.transform.localPosition.x < 0.77)
                {
                    HuanKuangKuang1();
                    KuangKuang.transform.Find("框框1/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("2");
                    KuangKuang.transform.Find("框框1").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > 0.2 && duixiang1.transform.localPosition.x < 0.41)
                {
                    HuanKuangKuang2();
                    KuangKuang.transform.Find("框框2/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("2");
                    KuangKuang.transform.Find("框框2").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > -0.08 && duixiang1.transform.localPosition.x < 0.12)
                {
                    huanKuangKuang3();
                    KuangKuang.transform.Find("框框3/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("2");
                    KuangKuang.transform.Find("框框3").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > -0.47 && duixiang1.transform.localPosition.x < -0.25)
                {
                    huanKuangKuang4();
                    KuangKuang.transform.Find("框框4/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("2");
                    KuangKuang.transform.Find("框框4").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
                else if (duixiang1.transform.localPosition.x > -0.79 && duixiang1.transform.localPosition.x < -0.58)
                {
                    huanKuangKuang5();
                    KuangKuang.transform.Find("框框5/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("2");
                    KuangKuang.transform.Find("框框5").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝");
                    duixiang.SetActive(false);

                }
            }
            duixiang1.transform.localPosition = new Vector3(0.04863973f, 0.3647514f, 0.3527391f);
        }
    }

    void tanhui()
    {
        duixiang1.SetActive(false);
        duixiang.SetActive(true);
        if (KuangKuang.transform.Find("框框1").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("矩形11"))
        {
            KuangKuang.transform.Find("框框1").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝2");
            KuangKuang.transform.Find("框框1/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("XWS_wenjianjia");
        }
        if (KuangKuang.transform.Find("框框2").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("矩形11"))
        {
            KuangKuang.transform.Find("框框2").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝2");
            KuangKuang.transform.Find("框框2/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("XWS_wenjianjia");
        }
        if (KuangKuang.transform.Find("框框3").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("矩形11"))
        {
            KuangKuang.transform.Find("框框3").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝2");
            KuangKuang.transform.Find("框框3/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("XWS_wenjianjia");
        }
        if (KuangKuang.transform.Find("框框4").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("矩形11"))
        {
            KuangKuang.transform.Find("框框4").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝2");
            KuangKuang.transform.Find("框框4/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("XWS_wenjianjia");
        }
        if (KuangKuang.transform.Find("框框5").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("矩形11"))
        {
            KuangKuang.transform.Find("框框5").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("矩形11拷贝2");
            KuangKuang.transform.Find("框框5/模型").gameObject.GetComponent<RawImage>().texture = Resources.Load<Texture>("XWS_wenjianjia");
        }
    }

    void HuanKuangKuang1()
    {
        if (KuangKuang.transform.Find("框框1/模型").gameObject.GetComponent<RawImage>().texture != Resources.Load<Texture>("XWS_wenjianjia"))
        {
            if (KuangKuang.transform.Find("框框1/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("6"))
                ipad.SetActive(true);
            else if (KuangKuang.transform.Find("框框1/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("5"))
                ShouBiao.SetActive(true);
            else if (KuangKuang.transform.Find("框框1/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("4"))
                ShouJi.SetActive(true);
            else if (KuangKuang.transform.Find("框框1/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("3"))
                XiangLian.SetActive(true);
            else if (KuangKuang.transform.Find("框框1/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("2"))
                YinHangKa.SetActive(true);
            else if (KuangKuang.transform.Find("框框1/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("1"))
                ZhaoPian.SetActive(true);
        }
    }
    void HuanKuangKuang2()
    {
        if (KuangKuang.transform.Find("框框2/模型").gameObject.GetComponent<RawImage>().texture != Resources.Load<Texture>("XWS_wenjianjia"))
        {
            if (KuangKuang.transform.Find("框框2/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("6"))
                ipad.SetActive(true);
            else if (KuangKuang.transform.Find("框框2/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("5"))
                ShouBiao.SetActive(true);
            else if (KuangKuang.transform.Find("框框2/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("4"))
                ShouJi.SetActive(true);
            else if (KuangKuang.transform.Find("框框2/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("3"))
                XiangLian.SetActive(true);
            else if (KuangKuang.transform.Find("框框2/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("2"))
                YinHangKa.SetActive(true);
            else if (KuangKuang.transform.Find("框框2/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("1"))
                ZhaoPian.SetActive(true);
        }
    }
    void huanKuangKuang3()
    {
        if (KuangKuang.transform.Find("框框3/模型").gameObject.GetComponent<RawImage>().texture != Resources.Load<Texture>("XWS_wenjianjia"))
        {
            if (KuangKuang.transform.Find("框框3/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("6"))
                ipad.SetActive(true);
            else if (KuangKuang.transform.Find("框框3/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("5"))
                ShouBiao.SetActive(true);
            else if (KuangKuang.transform.Find("框框3/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("4"))
                ShouJi.SetActive(true);
            else if (KuangKuang.transform.Find("框框3/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("3"))
                XiangLian.SetActive(true);
            else if (KuangKuang.transform.Find("框框3/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("2"))
                YinHangKa.SetActive(true);
            else if (KuangKuang.transform.Find("框框3/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("1"))
                ZhaoPian.SetActive(true);
        }
    }
    void huanKuangKuang4()
    {
        if (KuangKuang.transform.Find("框框4/模型").gameObject.GetComponent<RawImage>().texture != Resources.Load<Texture>("XWS_wenjianjia"))
        {
            if (KuangKuang.transform.Find("框框4/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("6"))
                ipad.SetActive(true);
            else if (KuangKuang.transform.Find("框框4/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("5"))
                ShouBiao.SetActive(true);
            else if (KuangKuang.transform.Find("框框4/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("4"))
                ShouJi.SetActive(true);
            else if (KuangKuang.transform.Find("框框4/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("3"))
                XiangLian.SetActive(true);
            else if (KuangKuang.transform.Find("框框4/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("2"))
                YinHangKa.SetActive(true);
            else if (KuangKuang.transform.Find("框框4/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("1"))
                ZhaoPian.SetActive(true);
        }
    }
    void huanKuangKuang5()
    {
        if (KuangKuang.transform.Find("框框5/模型").gameObject.GetComponent<RawImage>().texture != Resources.Load<Texture>("XWS_wenjianjia"))
        {
            if (KuangKuang.transform.Find("框框5/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("6"))
                ipad.SetActive(true);
            else if (KuangKuang.transform.Find("框框5/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("5"))
                ShouBiao.SetActive(true);
            else if (KuangKuang.transform.Find("框框5/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("4"))
                ShouJi.SetActive(true);
            else if (KuangKuang.transform.Find("框框5/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("3"))
                XiangLian.SetActive(true);
            else if (KuangKuang.transform.Find("框框5/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("2"))
                YinHangKa.SetActive(true);
            else if (KuangKuang.transform.Find("框框5/模型").gameObject.GetComponent<RawImage>().texture == Resources.Load<Texture>("1"))
                ZhaoPian.SetActive(true);
        }
    }
}
