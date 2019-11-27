using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class Chengliang : MonoBehaviour {

    public Text[] jiaReFenshu;
    public Text fenShu;
    public GameObject FenshuUI;
    public Text tiShiTextWenzi;
    public Text tiShiTextFenshu;
    string Table = "";
    string tableHead = "<table align= \"center\" border=\"1\" cellpadding=\"1\" cellspacing=\"1\" style=\"width: 960px;\">";//表头

    string tableBodyHead = "<tbody align= \"center\">";
    string tableBodyTail = "</tbody>";
    string tableTail = "</table>";
    bool isKeDianJi = true;

    public GameObject buttonBar;
    public GameObject Wenzitishi;
    public GameObject kaoHeTiShiUI;
    public GameObject kaoHeTiShiBtn;
    public GameObject tiJiaoFenShuBtn;
    public GameObject timeJiShiQi;
    public Text Mytext;
    public Text XianshiqiText;
    public Text NoteText2;
    public Text NoteText3;
    public GameObject tareZuo;
    public GameObject tareYou;
    public GameObject IorOkaiGuan;

    public GameObject cuoWuTishi_1;
    public GameObject cuoWuTishi_2;
    public GameObject cuoWuTishi_3;
    public GameObject cuoWuTishi_4;
    public GameObject chengLiangZhi;
    public GameObject xiaoTiShiChuang;
    public GameObject textTiShi;

    public GameObject textXianYin3_4;
    public GameObject textXianYin5_6Jia;
    public GameObject leftButton;
    public GameObject rightButton;
    public GameObject UIjiemian;
    public MouseController_ver1 _MouCam;
    public Camera TianpingCam;
    public Camera BijibenCam;
    public GameObject TianpingText;
    public GameObject YaoshiPingli;
    public GameObject YaoshiXuanzhuan;
    public GameObject Bijibenyuan;
    public GameObject BijibenHou;
    public GameObject WNST;
    public GameObject Tipppp;

    [Space]
    [Header("New Add")]
    public GameObject panel;//遮挡的panel
    public GameObject buZhouTiShiBtn;//步骤提示按钮


    private GameObject target_Tianping;
    private GameObject Trtget_Tianpingkaiguan;
    private GameObject Target_Chengliangzhi;
    private GameObject Target_Daoru;
    private GameObject huaDongTiao;

    public Transform Transform_YanlianChishi;
    public  Transform Transform_Chushi;
    public  Transform Transform_Chengliangzhi;
    public Transform Transform_GuanchaTianpingkaiguan;
    public Transform Transform_Daoru;

    private GameObject tianPingMen;

    private GameObject kaiGuanGaoLiang;
    private GameObject trueGaoLiang;
    private GameObject trueGaoLiang2;
    public Camera MainCam;
    private GameObject XiaoChuangKou;
    private GameObject Shanbaitu;
    public GameObject CPeople;
    public GameObject CPeople5_6;
    public GameObject CPeople5_6jiad;
    private GameObject Shuipao;
    private GameObject shuipaozhongxin;
    private GameObject Shuipingtai;
    private GameObject KaiguanAnniu;
    private GameObject Chengliangzhi;
    private GameObject TrueAnniu1;
    private GameObject TrueAnniu2;
    private GameObject Yaopinping1;
    private GameObject Bijiben;
    private GameObject Tianping;
    private GameObject ren5_6Yaoping;
    private GameObject ren5_6YaopingShou;
    private GameObject step5_6MenGuan;
    private GameObject step5_6MenKai;
    private GameObject step5_6JiaMenGuan;
    private GameObject step5_6JiaMenKai;

    private HighlightableObject hTianPingMen;

    private HighlightableObject HShuipingtai;
    private HighlightableObject HChengliangzhi;
    private HighlightableObject HYaopinping1;
    private HighlightableObject HBijiben;
    private HighlightableObject HTianping;
    private HighlightableObject hKaiGuanGaoLiang;
    private HighlightableObject hTrueGaoLiang;
    private HighlightableObject hTrueGaoLiang2;
    private HighlightableObject hTareZuo;
    private HighlightableObject hTareYou;
    private HighlightableObject hIorOkaiGuan;

    private Animator AWenzitishi;
    private Animator ACPeople;
    private Animator ACPeople5_6;
    private Animator ACPeople5_6jiad;
    private Animator AYaoshiXuanzhuan;
    private Animator aChengliangZhi;

    private CanvasGroup ShanbaiCangrp;

    int AdianjiCishu = 0;
    int KaiguandianjiCishu = 0;
    int menDianJiCiShu = 0;
    int luJingKaoHe = 0;
    //int biJiBenDianJiCiShu = 0;
    string mytext = "";
   public static string Gaoliangname = "";
   public static string DianjiKongzhi = "";
   public static string DianjiKongzhi2 = "";
    private float xianshiqinum=9.9999f;
    float shanbaizhi = 0;
    bool isYidong = false;
    bool isShanbai = false;
   public static  bool isDianjiA = false;
   public static string xiTong = "";
    //public static string xiTong = "演练系统";
    //public static string xiTong = "考核系统";

    private GameObject TextAbutton;
    public GameObject AtianjiaCam;
	void Start () {

        TextAbutton = GameObject.Find("界面").transform.Find("Text").gameObject;
        UIjiemian.GetComponent<Animator>().SetBool("isInitial", true);
        //StartCoroutine(WaitForSecond(0));

        kaiGuanGaoLiang = GameObject.Find("KaiGuanGaoLiang");
        trueGaoLiang = GameObject.Find("TrueGaoLiang (1)");
        trueGaoLiang2 = GameObject.Find("TrueGaoLiang (2)"); 
        XiaoChuangKou = GameObject.Find("界面/SeperateScreen");
        Shanbaitu = GameObject.Find("界面/Panel");
        //CPeople = GameObject.Find("Step3_4");
        //CPeople5_6 = GameObject.Find("Step5_6");
        //CPeople5_6jiad = GameObject.Find("Step5_6_jia_d");
        tianPingMen = GameObject.Find("Step3_4/group10/GRP:yiqi_zong2/GRP:yiqi_zong:Line04/GRP:yiqi_zong:Rectangle06/GRP:yiqi_zong:Box005");
        Shuipao = GameObject.Find("Step3_4/group10/GRP:yiqi_zong2/GRP:yiqi_zong:Line04/GRP:yiqi_zong:GeoSphere001 (1)");
        shuipaozhongxin = GameObject.Find("Step3_4/group10/GRP:yiqi_zong2/GRP:yiqi_zong:Line04/GRP:yiqi_zong:GeoSphere001");
        Shuipingtai = GameObject.Find("Step3_4/group10/GRP:yiqi_zong2/GRP:yiqi_zong:Line04/GRP:yiqi_zong:Box03");
        KaiguanAnniu = GameObject.Find("ScalePanel/Button (2)");
        TrueAnniu1 = GameObject.Find("ScalePanel/Button (1)");
        TrueAnniu2 = GameObject.Find("ScalePanel/Button");
        Chengliangzhi = GameObject.Find("Step3_4/group10/GRP:yiqi_zong2/GRP:ChengZhongZhi/GRP:pCube5");
        Yaopinping1 = GameObject.Find("Step3_4/group10/GRP:yiqi_zong2/jiaotoudiguan8");
        Bijiben = GameObject.Find("Step5_6/group10/GRP:yiqi_zong2/GRP:BiJiBen");
        Tianping = GameObject.Find("Step5_6/group10/GRP:yiqi_zong2/GRP:yiqi_zong:Line04");
        ren5_6Yaoping = GameObject.Find("Step5_6/group10/GRP:yiqi_zong2/GRP:jiaotoudiguan8");
        ren5_6YaopingShou = GameObject.Find("Step5_6/group10/GRP:yiqi_zong2/jiaotoudiguan9");
        step5_6MenGuan = GameObject.Find("Step5_6/group10/GRP:yiqi_zong2/GRP:yiqi_zong:Line04/GRP:yiqi_zong:Rectangle06");
        step5_6MenKai = GameObject.Find("Step5_6/group10/GRP:yiqi_zong2/GRP:yiqi_zong:Line04/GRP:yiqi_zong:Rectangle06 kai(2)");
        step5_6JiaMenGuan = GameObject.Find("Step5_6_jia_d/group10/GRP:yiqi_zong2/GRP:yiqi_zong:Line04/GRP:yiqi_zong:Rectangle06");
        step5_6JiaMenKai = GameObject.Find("Step5_6_jia_d/group10/GRP:yiqi_zong2/GRP:yiqi_zong:Line04/GRP:yiqi_zong:Rectangle06 dakai(1)");

        target_Tianping = GameObject.Find("Step3_4/group10/GRP:yiqi_zong2/GRP:yiqi_zong:Line04");
        Trtget_Tianpingkaiguan = GameObject.Find("Kaiguanweizhi");
        Target_Chengliangzhi = GameObject.Find("chegnliangzhiweizhi");
        Target_Daoru = GameObject.Find("DaoruMubiaodian");
        huaDongTiao = GameObject.Find("Slider");

        //Transform_Chushi = transform.Find("CameraGroups/ChushiCam");
        //Transform_Chengliangzhi = transform.Find("ChengliangzhiCam");

        HShuipingtai = Shuipingtai.GetComponent<HighlightableObject>();
        HChengliangzhi = Chengliangzhi.GetComponent<HighlightableObject>();
        HYaopinping1 = Yaopinping1.GetComponent<HighlightableObject>();
        HBijiben = Bijiben.GetComponent<HighlightableObject>();
        HTianping = Tianping.GetComponent<HighlightableObject>();
        hTianPingMen = tianPingMen.GetComponent<HighlightableObject>();
        hKaiGuanGaoLiang = kaiGuanGaoLiang.GetComponent<HighlightableObject>();
        hTrueGaoLiang = trueGaoLiang.GetComponent<HighlightableObject>();
        hTrueGaoLiang2 = trueGaoLiang2.GetComponent<HighlightableObject>();
        hTareZuo = tareZuo.GetComponent<HighlightableObject>();
        hTareYou = tareYou.GetComponent<HighlightableObject>();
        hIorOkaiGuan = IorOkaiGuan.GetComponent<HighlightableObject>();

        ACPeople = CPeople.GetComponent<Animator>();
        AWenzitishi = Wenzitishi.GetComponent<Animator>();
        ACPeople5_6 = CPeople5_6.GetComponent<Animator>();
        ACPeople5_6jiad = CPeople5_6jiad.GetComponent<Animator>();
        AYaoshiXuanzhuan = YaoshiXuanzhuan.GetComponent<Animator>();
        aChengliangZhi = chengLiangZhi.GetComponent<Animator>();

        ShanbaiCangrp = Shanbaitu.GetComponent<CanvasGroup>();
        if (xiTong =="演练系统")
        {
            kaoHeTiShiBtn.SetActive(false);
            tiJiaoFenShuBtn.SetActive(false);
            CameraMovePos._instance.OnCameraMovePos(Transform_YanlianChishi);
            CameraMovePos._instance.OnChangeCameraData(0.5f, 0.1f, 1f, Transform_YanlianChishi);
            StartCoroutine(CameraMovePos._instance.OnSetTarget(target_Tianping));
        }
        if (xiTong =="考核系统")
        {
            kaoHeTiShiBtn.SetActive(true);
            tiJiaoFenShuBtn.SetActive(true);
        CameraMovePos._instance.OnCameraMovePos(Transform_Chushi);
        CameraMovePos._instance.OnChangeCameraData(0.5f, 0.1f, 1f, Transform_Chushi);
        StartCoroutine(CameraMovePos._instance.OnSetTarget(target_Tianping));
        }
        huaDongTiao.GetComponent<Slider>().value = 0.34f;
        step5_6MenKai.SetActive(false);
        step5_6JiaMenKai.SetActive(false);
        ren5_6Yaoping.SetActive(false);
        ren5_6YaopingShou.SetActive(false);
        shuipaozhongxin.SetActive(false);
        CPeople5_6.SetActive(false);
        CPeople5_6jiad.SetActive(false);
        if (xiTong =="演练系统")
        {
            Gaoliangname = "水平台高亮";
            StartCoroutine(BoFangShengYin3(0.2f));
        }
        if (xiTong == "考核系统")
        {
            buttonBar.SetActive(false);
            Wenzitishi.SetActive(false);
            timeJiShiQi.SetActive(true);
            Gaoliangname = "水平台高亮";
            leftButton.GetComponent<Button>().enabled = false;
            rightButton.GetComponent<Button>().enabled = false;
            DianjiKongzhi = "水平台可点击";
            KaiguanAnniu.GetComponent<Button>().enabled = true;
            AWenzitishi.enabled = false;
        }
	}

    // Update is called once per frame
    void Update()
    {
        if (isDianjiA)
        {
            if (Input.GetMouseButtonDown(0))
            {
                AdianjiCishu = AdianjiCishu + 1;
                if (AdianjiCishu == 1)
                {
                    AYaoshiXuanzhuan.Play("要是旋转动画");
                    isDianjiA = false;
                }
                if (AdianjiCishu == 2)
                {
                    AYaoshiXuanzhuan.Play("要是旋转动画2");
                    isDianjiA = false;
                }
                if (AdianjiCishu == 3)
                {
                    AYaoshiXuanzhuan.Play("要是旋转动画3");
                    AdianjiCishu = 0;
                    isDianjiA = false;
                }
            }
        }
        if (isShanbai)
        {
            shanbaizhi = ShanbaiCangrp.alpha;
            shanbaizhi = shanbaizhi - 0.02f;
            ShanbaiCangrp.alpha = shanbaizhi;
            if (shanbaizhi < 0)
            {
                isShanbai = false;
            }
        }
        if (isYidong)
        {
            float x = Input.GetAxis("Vertical") * 0.001f * Time.deltaTime;
            float z = -Input.GetAxis("Horizontal") * 0.001f * Time.deltaTime;
            Shuipao.transform.Translate(x, 0, z);
            if (Vector3.Distance(Shuipao.transform.localPosition, shuipaozhongxin.transform.localPosition) < 0.0025647f)
            {
                isYidong = false;
                TianpingCam.gameObject.SetActive(false);
                XiaoChuangKou.GetComponent<Image>().enabled = false;
                TianpingText.GetComponent<Text>().enabled = false;
                Tipppp.SetActive(false);
                WNST.SetActive(false);
                CameraMovePos._instance.OnCameraMovePos(Transform_GuanchaTianpingkaiguan);
                CameraMovePos._instance.OnChangeCameraData(0.15f, 0.1f, 1f, Transform_GuanchaTianpingkaiguan);
                StartCoroutine(CameraMovePos._instance.OnSetTarget(Trtget_Tianpingkaiguan));
                Camera.main.gameObject.GetComponent<MouseFollowRotation>().enabled = true;

                Debug.Log("147258qwwer");
                if (xiTong == "演练系统")
                {
                    //WenZiXuanZe(2);
                    StartCoroutine(WenZiTiShi2(3));
                }
                if (xiTong == "考核系统")
                {
                    Gaoliangname = "开关高亮";
                    KaiguanAnniu.GetComponent<Button>().enabled = true;
                }
            }
        }
        if (isKeDianJi)
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (!EventSystem.current.IsPointerOverGameObject())
                    {
                        Debug.Log(hit.transform.gameObject.name);
                        if (hit.transform.gameObject.name == "GRP:yiqi_zong:Box03" && DianjiKongzhi == "水平台可点击" && xiTong == "演练系统")
                        {
                            //StartCoroutine(Shanbai(0));
                            HShuipingtai.FlashingOff();
                            DianjiKongzhi = "";
                            ACPeople.Play("Step3_1");
                        }
                        if (hit.transform.gameObject.name == "GRP:yiqi_zong:Box03" && DianjiKongzhi == "水平台可点击" && xiTong == "考核系统")
                        {
                            //StartCoroutine(Shanbai(0));
                            if (xiTong == "考核系统")
                            {
                                Score._instance.score += 10;
                                Score._instance.kaoheText[0] = "天平使用前进行了水平调整+10";
                                Score._instance.isCaozuo[0] = true;
                                Score._instance.isPanDuanCaozuo[0] = true;
                            }
                            KaiguanAnniu.GetComponent<Button>().enabled = false;
                            HShuipingtai.FlashingOff();
                            DianjiKongzhi = "";
                            ACPeople.Play("Step3_1");
                        }
                        if (hit.transform.gameObject.name == "GRP:pCube5" && DianjiKongzhi == "称量纸可点击")
                        {
                            aChengliangZhi.Play("称量纸");
                            HChengliangzhi.FlashingOff();
                            DianjiKongzhi = "";
                            ACPeople.Play("Step3_1_1");
                        }
                        if (hit.transform.gameObject.name == "jiaotoudiguan8" && DianjiKongzhi == "药品瓶可点击")
                        {
                            HYaopinping1.FlashingOff();
                            DianjiKongzhi = "";
                            ACPeople.Play("Step3_3");
                        }
                        if (hit.transform.gameObject.name == "GRP:BiJiBen" && (DianjiKongzhi == "笔记本可点击" || DianjiKongzhi2 == "笔记本可点击"))
                        {
                            HBijiben.FlashingOff();
                            DianjiKongzhi = "";
                            DianjiKongzhi2 = "";
                            textXianYin3_4.SetActive(true);
                            textXianYin5_6Jia.SetActive(true);
                            if (xiTong == "演练系统")
                            {
                                BijibenCam.gameObject.SetActive(true);
                                XiaoChuangKou.GetComponent<Image>().enabled = true;
                                ACPeople5_6.Play("Step5_2");
                            }
                            if (xiTong == "考核系统")
                            {
                                Score._instance.score += 5;
                                Score._instance.kaoheText[2] = "称量后记录了数据+5";
                                Score._instance.isCaozuo[2] = true;
                                Score._instance.isPanDuanCaozuo[2] = true;
                                ACPeople5_6.Play("Step5_2");
                                BijibenCam.gameObject.SetActive(true);
                                XiaoChuangKou.GetComponent<Image>().enabled = true;
                            }
                        }
                        if (hit.transform.gameObject.name == "GRP:yiqi_zong:Line04" && (DianjiKongzhi == "天平可点击" || DianjiKongzhi2 == "天平可点击"))
                        {
                            if (xiTong == "演练系统")
                            {
                                HTianping.FlashingOff();
                                DianjiKongzhi = "";
                                DianjiKongzhi2 = "";
                                ACPeople5_6.Play("Step5_1");
                            }
                            if (xiTong == "考核系统")
                            {
                                if (Score._instance.isPanDuanCaozuo[2] == false)
                                {
                                    buZhouTiShiBtn.GetComponent<Button>().interactable = false;
                                    panel.SetActive(true);
                                    cuoWuTishi_3.SetActive(true);
                                }
                                if (Score._instance.isPanDuanCaozuo[2] == true)
                                {
                                    HTianping.FlashingOff();
                                    DianjiKongzhi = "";
                                    DianjiKongzhi2 = "";
                                    ACPeople5_6.Play("Step5_1");
                                }
                            }


                        }
                        if (hit.transform.gameObject.name == "GRP:yiqi_zong:Box005" && (DianjiKongzhi == "门可点击" || DianjiKongzhi2 == "门可点击"))
                        {
                            DianjiKongzhi = "";
                            DianjiKongzhi2 = "";
                            menDianJiCiShu = menDianJiCiShu + 1;
                            hTianPingMen.FlashingOff();
                            if (menDianJiCiShu == 1)
                            {
                                if (xiTong == "考核系统")
                                {
                                    Score._instance.score += 10;
                                    Score._instance.kaoheText[1] = "称量时关闭了天平门+10";
                                    Score._instance.isCaozuo[1] = true;
                                    Score._instance.isPanDuanCaozuo[1] = true;
                                }
                                ACPeople.Play("Step3_4_2");
                            }
                            if (menDianJiCiShu == 2)
                            {
                                if (xiTong == "考核系统")
                                {
                                    Score._instance.score += 10;
                                    Score._instance.kaoheText[3] = "关闭了天平门和电源+10";
                                    Score._instance.isCaozuo[3] = true;
                                    Score._instance.isPanDuanCaozuo[3] = true;
                                }
                                KaiguanAnniu.GetComponent<Button>().enabled = false;
                                step5_6JiaMenGuan.SetActive(true);
                                step5_6JiaMenKai.SetActive(false);
                                step5_6MenGuan.SetActive(true);
                                step5_6MenKai.SetActive(false);
                                menDianJiCiShu = 0;
                                ACPeople.Play("Step3_3_d");
                            }
                        }
                        if (hit.transform.gameObject.name == "RubberBox4" && (DianjiKongzhi == "天枰纸可点击" || DianjiKongzhi2 == "天枰纸可点击"))
                        {
                            if (Score._instance.isPanDuanCaozuo[1] == false)
                            {
                                buZhouTiShiBtn.GetComponent<Button>().interactable = false;
                                panel.SetActive(true);
                                cuoWuTishi_2.SetActive(true);
                            }
                            if (Score._instance.isPanDuanCaozuo[1] == true)
                            {
                                DianjiKongzhi = "";
                                DianjiKongzhi2 = "";
                                CPeople.SetActive(false);
                                CPeople5_6.SetActive(true);
                                step5_6JiaMenGuan.SetActive(false);
                                step5_6JiaMenKai.SetActive(true);
                                step5_6MenGuan.SetActive(false);
                                step5_6MenKai.SetActive(true);
                                menDianJiCiShu = 1;
                                luJingKaoHe = 1;
                                ACPeople5_6.Play("Step5_1_1");
                            }
                        }
                        if (hit.transform.gameObject.name == "GRP:yiqi_zong:Line04" && (DianjiKongzhi == "3-4天平可点击" || DianjiKongzhi2 == "3-4天平可点击"))
                        {
                            DianjiKongzhi = "";
                            DianjiKongzhi2 = "";
                            CPeople.SetActive(false);
                            CPeople5_6.SetActive(true);
                            CameraMovePos._instance.OnCameraMovePos(Transform_GuanchaTianpingkaiguan);
                            CameraMovePos._instance.OnChangeCameraData(0.15f, 0.1f, 1f, Transform_GuanchaTianpingkaiguan);
                            StartCoroutine(CameraMovePos._instance.OnSetTarget(Trtget_Tianpingkaiguan));
                            Gaoliangname = "开关可点击";
                            GaoliangXuanze();
                        }
                    }
                }
            }
    }
    public void C_OnClickButton()
    {
        AWenzitishi.SetBool("IsPlay", false);
        GaoliangXuanze();
    }
    public void WenZiXuanZe(int i)
    {
        switch (i)
        {
           
            case 1:
                mytext = "点击确认后，请调节水平调整脚,按住上下左右键越久，气泡移动越快";
                Gaoliangname = "水平调节";
                break;
            case 2:
                AudioPlayer._instance.PlayAudio(4);
                mytext = "点击确认后，请点击电源开关，打开天平,进行预热";
                Gaoliangname = "开关可点击";
                break;
            case 3:
                if (xiTong == "演练系统")
                {
                    AudioPlayer._instance.PlayAudio(5);
                }
                mytext = "点击确认后，请点击称量纸进行折叠,并放入天平内";
                Gaoliangname = "称量纸高亮";
                break;
            case 4:
                AudioPlayer._instance.PlayAudio(6);
                mytext = "点击确认后，请点击天平上的tare键，将示数调整为零";
                Gaoliangname = "True可点击";
                break;
            case 5:
                AudioPlayer._instance.PlayAudio(7);
                mytext = "点击确认后，请点击药品瓶称取三氧化二砷";
                Gaoliangname = "药品瓶高亮";
                break;
            case 6:
                mytext = "点击确认后，请点击鼠标左键进行称量";
                Gaoliangname = "A键可点击";
                break;
            case 7:
                
                mytext = "点击确认后，读数稳定后读取数据";
                Gaoliangname = "文字提示8";
                break;
            case 8:
                mytext = "点击确认后，请点击实验笔记本，记录称量的数据";
                Gaoliangname = "笔记本高亮";
                break;
            case 9:
                mytext = "点击确认后，请点击天平，取出三氧化二砷";
                Gaoliangname = "天平高亮";
                break;
            case 10:
                mytext = "点击确认后，请将三氧化二砷倒入锥形瓶中";
                Gaoliangname = "人物5-6d开启";
                break;
            case 11:
                AudioPlayer._instance.PlayAudio(9);
                mytext = "点击确认后，请将称量纸放回天平称量，观察读数";
                Gaoliangname = "人物3-4开启";
                break;
            case 12:
                mytext = "点击确认后，请观察称量纸的读数";
                Gaoliangname = "文字提示13";
                break;
            case 13:
                mytext = "点击确认后，请再次记录称量纸的重量";
                Gaoliangname = "出现记录";
                break;
            case 14:
                AudioPlayer._instance.PlayAudio(10);
                mytext = "点击确认后，请关闭天平";
                Gaoliangname = "关天平人物开启";
                break;
            case 15:
                mytext = "称量完毕后，点击确认后，请点击电源开关键，关闭天平";
                Gaoliangname = "开关可点击";
                break;
            case 16:
                mytext = "点击确认后，回到通风橱进行后续实验操作";
                Gaoliangname = "下一个场景";
                break;
        }
        Mytext.text = "";
        Mytext.text = mytext;
        AWenzitishi.SetBool("IsPlay", true);
    }
   public void GaoliangXuanze()
    {
        switch (Gaoliangname )
        {
            case "天平门高亮":
                hTianPingMen.FlashingOn(Color.green, Color.clear);
                break;
            case "水平台高亮":
                
                HShuipingtai.FlashingOn(Color.green, Color.clear);
                DianjiKongzhi = "水平台可点击";
                break;
            case "水平调节":
                isYidong = true;

                TianpingCam.gameObject.SetActive(true);
                XiaoChuangKou.GetComponent<Image>().enabled = true;
                TianpingText.GetComponent<Text>().enabled = true;
                WNST.SetActive(true);
                Tipppp.SetActive(true);
                break;
            case "开关可点击":
                if (xiTong == "演练系统")
                {
                    hIorOkaiGuan.FlashingOn(Color.green, Color.clear);
                }
                KaiguanAnniu.GetComponent<Button>().enabled = true;
                break;
            case "称量纸高亮":
                HChengliangzhi.FlashingOn(Color.green, Color.clear);
                DianjiKongzhi = "称量纸可点击";
                break;
            case "True可点击":
                if (xiTong == "演练系统")
                {
                    hTareZuo.FlashingOn(Color.green, Color.clear);
                    hTareYou.FlashingOn(Color.green, Color.clear);
                }
                TrueAnniu1.GetComponent<Button>().enabled = true;
                TrueAnniu2.GetComponent<Button>().enabled = true;
                break ;
            case "药品瓶高亮":
                HYaopinping1.FlashingOn(Color.green, Color.clear);
                DianjiKongzhi = "药品瓶可点击";
                break ;
            case "A键可点击":

                isDianjiA = true;
                AtianjiaCam.SetActive(true);
                TextAbutton.SetActive(true);
                break;
            case "文字提示8":
                StartCoroutine(Wenzitishi8(1));
                break;
            case "笔记本高亮":
                HBijiben.FlashingOn(Color.green, Color.clear);
                DianjiKongzhi = "笔记本可点击";
                break;
            case "笔记本高亮考核":
                //BijibenCam.gameObject.SetActive(true);
                //XiaoChuangKou.GetComponent<Image>().enabled = true;
                //HBijiben.FlashingOn(Color.green, Color.clear);
                DianjiKongzhi = "笔记本可点击";
                DianjiKongzhi2 = "天平可点击";
                break;
            case "天平高亮":
                HTianping.FlashingOn(Color.green, Color.clear);
                DianjiKongzhi = "天平可点击";
                break;
            case "人物5-6d开启":
                //StartCoroutine(Shanbai(0));
                CPeople5_6.SetActive(false);
                CPeople5_6jiad.SetActive(true);
                chengLiangZhi.SetActive(false);
                CameraMovePos._instance.OnCameraMovePos(Transform_Daoru);
                CameraMovePos._instance.OnChangeCameraData(0.5f, 0.1f, 1f, Transform_Daoru);
                StartCoroutine(CameraMovePos._instance.OnSetTarget(Target_Daoru));
                StartCoroutine(Daozhuixingping(1.5f));
                break;
            case "人物3-4开启":
                //StartCoroutine(Shanbai(0));
                
                CPeople5_6jiad.SetActive(false);
                CPeople.SetActive(true);
                Bijibenyuan.SetActive(false);
                BijibenHou.SetActive(true);
                CameraMovePos._instance.OnCameraMovePos(Transform_Chengliangzhi);
                CameraMovePos._instance.OnChangeCameraData(0.5f, 0.1f, 1f, Transform_Chengliangzhi);
                StartCoroutine(CameraMovePos._instance.OnSetTarget(Target_Chengliangzhi));
                if (luJingKaoHe == 0)
                {
                    StartCoroutine(ChengliangzhiFangtianping(1.5f));
                }
                if (luJingKaoHe ==1)
                {
                    StartCoroutine(ChengliangzhiFangtianping2(0f));
                    luJingKaoHe = 0;
                }
                break;
            case "文字提示13":
                //StartCoroutine(Shanbai(0));
                //CPeople.SetActive(false);
                //CPeople5_6.SetActive(true);
                BijibenCam.gameObject.SetActive(true);
                XiaoChuangKou.GetComponent<Image>().enabled = true;
                XianshiqiText.text = "0.0000";
                StartCoroutine(Wenzitishi13(1));
                break;
            case "出现记录":
                NoteText2.gameObject.SetActive(true);
                NoteText2.DOText("2.倒完三氧化二砷之后，称量纸\n重量为：0.0000g\n三氧化二砷真实重量为：0.1320g-0.0000g=0.1320g", 4); 
                StartCoroutine(Wenzitishi14(5f));
                break;
            case "文字出现考核":
                BijibenCam.gameObject.SetActive(true);
                XiaoChuangKou.GetComponent<Image>().enabled = true;
                XianshiqiText.text = "0.0000";
                NoteText2.gameObject.SetActive(true);
                NoteText2.DOText("2.倒完三氧化二砷之后，称量纸\n重量为：0.0000g\n三氧化二砷真实重量为：0.1320g-0.0000g=0.1320g", 4);
                //NoteText2.gameObject.SetActive(true);
                StartCoroutine(GuanbiWenzi(5f));
                break;
            case "关天平人物开启":
                //StartCoroutine(Shanbai(0));
                CameraMovePos._instance.OnCameraMovePos(Transform_GuanchaTianpingkaiguan);
                    CameraMovePos._instance.OnChangeCameraData(0.15f, 0.1f, 1f, Transform_GuanchaTianpingkaiguan);
                    StartCoroutine(CameraMovePos._instance.OnSetTarget(Trtget_Tianpingkaiguan));
                CPeople.SetActive(false);
                CPeople5_6.SetActive(true);
                NoteText3.gameObject.SetActive(true);
                BijibenCam.gameObject.SetActive(false );
                XiaoChuangKou.GetComponent<Image>().enabled = false;
                StartCoroutine(BofangGuantianpingdonghua(0.5f));
                break;
            case "下一个场景":
                //Application.LoadLevel(4);
                SceneManager.LoadScene("滴加药品");
                PlayDijia.jinRuChangjingCishu = 0;
                break;
            case "开关高亮":
                hKaiGuanGaoLiang.FlashingOn(Color.green, Color.clear);
                break;
            case "True高亮":
                hTrueGaoLiang.FlashingOn(Color.green, Color.clear);
                hTrueGaoLiang2.FlashingOn(Color.green, Color.clear);
                break;
            case "小窗口提示1":
                textTiShi.GetComponent<Text>().text = "点击键盘“A”键，进行加药称量";
                XiaoTiShi();
                break;
        }
    }
   public void GaoLiangTishiKaohe()
   {
       if (Score._instance.kaoHeTiShi == 0)
       {
           kaoHeTiShiUI.SetActive(true);
       }
       if (Score._instance.kaoHeTiShi == 1)
       {
           if (Gaoliangname == "")
           {
               return;
           }
           else
           {
               Score._instance.hintScore += 2;
               Score._instance.hintCiShu += 1;
               GaoliangXuanze();
               Gaoliangname = "";
           }
       }

   }
    public void XiaoTiShi()
   {
       xiaoTiShiChuang.SetActive(true);
       StartCoroutine(GuanTiShi(5));
   }
   public void QueDingKaoHeTiShi()
   {
       kaoHeTiShiUI.SetActive(false);
       Score._instance.hintScore += 2;
       Score._instance.hintCiShu += 1;
       Score._instance.kaoHeTiShi = 1;
       GaoliangXuanze();
   }
   public void QuXiaoKaoHeTiShi()
   {
       kaoHeTiShiUI.SetActive(false);
   }
    public void BackSences()
    {
        // Application.LoadLevel(2);
        SceneManager.LoadScene("主场景");
    }
    public void NextSences()
    {
        //Application.LoadLevel(4);
        SceneManager.LoadScene("滴加药品");
        PlayDijia.jinRuChangjingCishu = 0;
    }
    public void TianPinKai()
    {
        XianshiqiText.text = xianshiqinum.ToString("0.0000");
        if (xianshiqinum > 0)
        {
            xianshiqinum = xianshiqinum - 1.1111f;

        }
        else
        {
            if (xiTong == "演练系统")
            {
                CancelInvoke("TianPinKai");
                StartCoroutine(XiangjiGuanchaChengliangzhi(0.5f));
            }
            if (xiTong =="考核系统")
            {
                CancelInvoke("TianPinKai");
                StartCoroutine(XiangjiGuanchaChengliangzhi(0.5f));
                Gaoliangname = "称量纸高亮";
                DianjiKongzhi = "称量纸可点击";
            }
        }

    }
    public void TrueJian_OnClick()
    {
        if (xiTong == "演练系统")
        {
            hTareZuo.FlashingOff();
            hTareYou.FlashingOff();
            XianshiqiText.text = "0.0000";
            TrueAnniu1.GetComponent<Button>().enabled = false;
            TrueAnniu2.GetComponent<Button>().enabled = false;
            StartCoroutine(WenzitishiYaopinping(1.5f));
        }
        if (xiTong =="考核系统")
        {
            hTrueGaoLiang.FlashingOff();
            hTrueGaoLiang2.FlashingOff();
            XianshiqiText.text = "0.0000";
            TrueAnniu1.GetComponent<Button>().enabled = false;
            TrueAnniu2.GetComponent<Button>().enabled = false;
            Gaoliangname = "药品瓶高亮";
            DianjiKongzhi = "药品瓶可点击";
        }
    }
    public void OnClick_Kaiguan()
    {
        KaiguandianjiCishu = KaiguandianjiCishu + 1;
        hKaiGuanGaoLiang.FlashingOff();
        hIorOkaiGuan.FlashingOff();
        if (KaiguandianjiCishu == 1)
        {
            if (xiTong == "演练系统")
            {
                XianshiqiText.gameObject.SetActive(true);
                InvokeRepeating("TianPinKai", 0, 0.5f);
                StartCoroutine(WaitForcWenziTishi(6f));
                KaiguanAnniu.GetComponent<Button>().enabled = false;
            }
            if (xiTong == "考核系统")
            {

                Gaoliangname = "";
                if (Score ._instance.isPanDuanCaozuo[0] ==false )
                {
                    buZhouTiShiBtn.GetComponent<Button>().interactable = false;
                    panel.SetActive(true);
                    cuoWuTishi_1.SetActive(true);
                }
                if (Score._instance.isPanDuanCaozuo[0] == true)
                {
                    CameraMovePos._instance.OnCameraMovePos(Transform_GuanchaTianpingkaiguan);
                    CameraMovePos._instance.OnChangeCameraData(0.15f, 0.1f, 1f, Transform_GuanchaTianpingkaiguan);
                    StartCoroutine(CameraMovePos._instance.OnSetTarget(Trtget_Tianpingkaiguan));
                    XianshiqiText.gameObject.SetActive(true);
                    InvokeRepeating("TianPinKai", 0, 0.5f);
                    StartCoroutine(WaitForcWenziTishi(6f));
                    DianjiKongzhi = "";
                    KaiguanAnniu.GetComponent<Button>().enabled = false;
                }
            }
        }
        if (KaiguandianjiCishu ==2)
        {
            if (xiTong == "演练系统")
            {
                CameraMovePos._instance.OnCameraMovePos(Transform_GuanchaTianpingkaiguan);
                CameraMovePos._instance.OnChangeCameraData(0.15f, 0.1f, 1f, Transform_GuanchaTianpingkaiguan);
                StartCoroutine(CameraMovePos._instance.OnSetTarget(Trtget_Tianpingkaiguan));
                DianjiKongzhi = "";
                DianjiKongzhi2 = "";
                CPeople.SetActive(false);
                CPeople5_6.SetActive(true);
                ACPeople5_6.Play("Step6_3");
                KaiguanAnniu.GetComponent<Button>().enabled = false;
            }
            if (xiTong =="考核系统")
            {
                if (Score._instance.isPanDuanCaozuo[3] == false)
                {
                    buZhouTiShiBtn.GetComponent<Button>().interactable = false;
                    panel.SetActive(true);
                    cuoWuTishi_4.SetActive(true);
                }
                if (Score._instance.isPanDuanCaozuo[3] == true )
                {
                    CameraMovePos._instance.OnCameraMovePos(Transform_GuanchaTianpingkaiguan);
                    CameraMovePos._instance.OnChangeCameraData(0.15f, 0.1f, 1f, Transform_GuanchaTianpingkaiguan);
                    StartCoroutine(CameraMovePos._instance.OnSetTarget(Trtget_Tianpingkaiguan));
                    DianjiKongzhi = "";
                    DianjiKongzhi2 = "";
                    CPeople.SetActive(false);
                    CPeople5_6.SetActive(true);
                    ACPeople5_6.Play("Step6_3");
                    KaiguanAnniu.GetComponent<Button>().enabled = false;
                } 
            }
        }
    }
    IEnumerator Shanbai(float time)
    {
        yield return new WaitForSeconds(time);
        ShanbaiCangrp.alpha = 1;
        isShanbai = true;
    }
    IEnumerator GuanTiShi(float time)
    {
        yield return new WaitForSeconds(time);
        xiaoTiShiChuang.SetActive(false);
    }
    //IEnumerator WaitForSecond(float time)
    //{

    //    yield return new WaitForSeconds(time);
    //    _MouCam.SetCameraPosition(Camera.main.transform, 1f, 1f, 1f, false);
    //    _MouCam.SetOn();
    //}
    IEnumerator WaitForcWenziTishi(float time)
    {
        yield return new WaitForSeconds(time);
        WenZiXuanZe(3);
    }
    IEnumerator XiangjiGuanchaChengliangzhi(float time)
    {
        yield return new WaitForSeconds(time);
        //iTween.MoveTo(MainCam.gameObject, new Vector3(-1.321827f, 0.3114188f, -1.945563f), 1f);
        //iTween.RotateTo(MainCam.gameObject, new Vector3(30.8035f, -200.1777f, -0.0009f), 1f);
        //_MouCam.SetOff();
        //StartCoroutine(WaitForSecond(1));
        CameraMovePos._instance.OnCameraMovePos(Transform_Chengliangzhi);
        CameraMovePos._instance.OnChangeCameraData(0.5f, 0.1f, 1f, Transform_Chengliangzhi);
        StartCoroutine(CameraMovePos._instance.OnSetTarget( Target_Chengliangzhi));
    }
    IEnumerator WenzitishiYaopinping(float time)
    {
        yield return new WaitForSeconds(time);
        WenZiXuanZe(5);
    }
    IEnumerator Wenzitishi8(float time)
    {
        yield return new WaitForSeconds(time);
        //StartCoroutine(Shanbai(0));
        CPeople.SetActive(false);
        CPeople5_6.SetActive(true);
        WenZiXuanZe(8);
    }
    IEnumerator Daozhuixingping(float time)
    {
        yield return new WaitForSeconds(time);
        ACPeople5_6jiad.Play("Step5_6_Jia");
    }
    IEnumerator ChengliangzhiFangtianping(float time)
    {
        yield return new WaitForSeconds(time);
        ACPeople.Play("Step3_1_1_d");
    }
    IEnumerator ChengliangzhiFangtianping2(float time)
    {
        yield return new WaitForSeconds(time);
        ACPeople.Play("Step3_2_d");
    }
    IEnumerator Wenzitishi13(float time)
    {
        yield return new WaitForSeconds(time);
        WenZiXuanZe(13);
    }
    IEnumerator Wenzitishi14(float time)
    {
        yield return new WaitForSeconds(time);
        WenZiXuanZe(14);
    }
    IEnumerator BofangGuantianpingdonghua(float time)
    {
        yield return new WaitForSeconds(time);
        ACPeople5_6.Play("Step6_2");
    }
    IEnumerator GuanbiWenzi(float time)
    {
        yield return new WaitForSeconds(time);
        Gaoliangname = "关天平人物开启";
        GaoliangXuanze();
    }
    public void CuoWuTiShi_1()
    {
        panel.SetActive(false);
        buZhouTiShiBtn.GetComponent<Button>().interactable = true;
        cuoWuTishi_1.SetActive(false);
        CameraMovePos._instance.OnCameraMovePos(Transform_GuanchaTianpingkaiguan);
        CameraMovePos._instance.OnChangeCameraData(0.15f, 0.1f, 1f, Transform_GuanchaTianpingkaiguan);
        StartCoroutine(CameraMovePos._instance.OnSetTarget(Trtget_Tianpingkaiguan));
        XianshiqiText.gameObject.SetActive(true);
        InvokeRepeating("TianPinKai", 0, 0.5f);
        StartCoroutine(WaitForcWenziTishi(6f));
        DianjiKongzhi = "";
        KaiguanAnniu.GetComponent<Button>().enabled = false;
    }
    public void CuoWuTiShi_2()
    {
        panel.SetActive(false);
        buZhouTiShiBtn.GetComponent<Button>().interactable = true;
        cuoWuTishi_2.SetActive(false);
        DianjiKongzhi = "";
        DianjiKongzhi2 = "";
        CPeople.SetActive(false);
        CPeople5_6.SetActive(true);
        step5_6JiaMenGuan.SetActive(false);
        step5_6JiaMenKai.SetActive(true);
        step5_6MenGuan.SetActive(false);
        step5_6MenKai.SetActive(true);
        menDianJiCiShu = 1;
        luJingKaoHe = 1;
        ACPeople5_6.Play("Step5_1_1");
    }
    public void CuoWuTiShi_3()
    {
        panel.SetActive(false);
        buZhouTiShiBtn.GetComponent<Button>().interactable = true;
        cuoWuTishi_3.SetActive(false);
        HTianping.FlashingOff();
        DianjiKongzhi = "";
        DianjiKongzhi2 = "";
        ACPeople5_6.Play("Step5_1");
    }
    public void CuoWuTiShi_4()
    {
        panel.SetActive(false);
        buZhouTiShiBtn.GetComponent<Button>().interactable = true;
        cuoWuTishi_4.SetActive(false);
        CameraMovePos._instance.OnCameraMovePos(Transform_GuanchaTianpingkaiguan);
        CameraMovePos._instance.OnChangeCameraData(0.15f, 0.1f, 1f, Transform_GuanchaTianpingkaiguan);
        StartCoroutine(CameraMovePos._instance.OnSetTarget(Trtget_Tianpingkaiguan));
        DianjiKongzhi = "";
        DianjiKongzhi2 = "";
        CPeople.SetActive(false);
        CPeople5_6.SetActive(true);
        ACPeople5_6.Play("Step6_3");
        KaiguanAnniu.GetComponent<Button>().enabled = false;
    }
    IEnumerator BoFangShengYin3(float time)
    {
        yield return new WaitForSeconds(time );
        AudioPlayer._instance.PlayAudio(3);
    }
    IEnumerator WenZiTiShi2(float time)
    {
        yield return new WaitForSeconds(time);
        WenZiXuanZe(2);
        //AudioPlayer._instance.PlayAudio(2);
    }
    public void ZuiHouFenShu()
    {
        if (xiTong == "考核系统")
        {
            isKeDianJi = false;
            CameraMovePos._instance.SetTargetNull();
            JiShiQi._instanceTime.isTime = false;
            FenshuUI.SetActive(true);
            Table = tableHead + tableBodyHead;
            jiaReFenshu[0].text = Score._instance.kaoheText[0].ToString();
            Table = Table +
                        "<tr>" +
                             "<td>" + jiaReFenshu[0].text + "</td>" +
                        "</tr>";
            if (Score._instance.isCaozuo[0])
            {
                jiaReFenshu[0].color = Color.green;
            }
            jiaReFenshu[1].text = Score._instance.kaoheText[1].ToString();
            Table = Table +
                        "<tr>" +
                             "<td>" + jiaReFenshu[1].text + "</td>" +
                        "</tr>";
            if (Score._instance.isCaozuo[1])
            {
                jiaReFenshu[1].color = Color.green;
            }
            jiaReFenshu[2].text = Score._instance.kaoheText[2].ToString();
            Table = Table +
                        "<tr>" +
                             "<td>" + jiaReFenshu[2].text + "</td>" +
                        "</tr>";
            if (Score._instance.isCaozuo[2])
            {
                jiaReFenshu[2].color = Color.green;
            }
            jiaReFenshu[3].text = Score._instance.kaoheText[3].ToString();
            Table = Table +
                        "<tr>" +
                             "<td>" + jiaReFenshu[3].text + "</td>" +
                        "</tr>";
            if (Score._instance.isCaozuo[3])
            {
                jiaReFenshu[3].color = Color.green;
            }
            jiaReFenshu[4].text = Score._instance.kaoheText[4].ToString();
            Table = Table +
                        "<tr>" +
                             "<td>" + jiaReFenshu[4].text + "</td>" +
                        "</tr>";
            if (Score._instance.isCaozuo[4])
            {
                jiaReFenshu[4].color = Color.green;
            }
            jiaReFenshu[5].text = Score._instance.kaoheText[5].ToString();
            Table = Table +
                        "<tr>" +
                             "<td>" + jiaReFenshu[5].text + "</td>" +
                        "</tr>";
            if (Score._instance.isCaozuo[5])
            {
                jiaReFenshu[5].color = Color.green;
            }
            jiaReFenshu[6].text = Score._instance.kaoheText[6].ToString();
            Table = Table +
                        "<tr>" +
                             "<td>" + jiaReFenshu[6].text + "</td>" +
                        "</tr>";
            if (Score._instance.isCaozuo[6])
            {
                jiaReFenshu[6].color = Color.green;
            }
            jiaReFenshu[7].text = Score._instance.kaoheText[7].ToString();
            Table = Table +
                        "<tr>" +
                             "<td>" + jiaReFenshu[7].text + "</td>" +
                        "</tr>";
            if (Score._instance.isCaozuo[7])
            {
                jiaReFenshu[7].color = Color.green;
            }
            jiaReFenshu[8].text = Score._instance.kaoheText[8].ToString();
            Table = Table +
                        "<tr>" +
                             "<td>" + jiaReFenshu[8].text + "</td>" +
                        "</tr>";
            if (Score._instance.isCaozuo[8])
            {
                jiaReFenshu[8].color = Color.green;
            }
            jiaReFenshu[9].text = Score._instance.kaoheText[9].ToString();
            Table = Table +
                        "<tr>" +
                             "<td>" + jiaReFenshu[9].text + "</td>" +
                        "</tr>";
            if (Score._instance.isCaozuo[9])
            {
                jiaReFenshu[9].color = Color.green;
            }
            jiaReFenshu[10].text = Score._instance.kaoheText[10].ToString();
            Table = Table +
                        "<tr>" +
                             "<td>" + jiaReFenshu[10].text + "</td>" +
                        "</tr>";
            if (Score._instance.isCaozuo[10])
            {
                jiaReFenshu[10].color = Color.green;
            }
            //jiaReFenshu[11].text = Score._instance.kaoheText[11].ToString();
            //Table = Table +
            //            "<tr>" +
            //                 "<td>" + jiaReFenshu[11].text + "</td>" +
            //            "</tr>";
            //if (Score._instance.isCaozuo[11])
            //{
            //    jiaReFenshu[11].color = Color.green;
            //}
            //jiaReFenshu[12].text = Score._instance.kaoheText[12].ToString();
            //Table = Table +
            //            "<tr>" +
            //                 "<td>" + jiaReFenshu[12].text + "</td>" +
            //            "</tr>";
            //if (Score._instance.isCaozuo[12])
            //{
            //    jiaReFenshu[12].color = Color.green;
            //}
            //jiaReFenshu[13].text = Score._instance.kaoheText[13].ToString();
            //Table = Table +
            //            "<tr>" +
            //                 "<td>" + jiaReFenshu[13].text + "</td>" +
            //            "</tr>";
            //if (Score._instance.isCaozuo[13])
            //{
            //    jiaReFenshu[13].color = Color.green;
            //}
            jiaReFenshu[14].text = Score._instance.kaoheText[14].ToString();
            Table = Table +
                        "<tr>" +
                             "<td>" + jiaReFenshu[14].text + "</td>" +
                        "</tr>";
            if (Score._instance.isCaozuo[14])
            {
                jiaReFenshu[14].color = Color.green;
            }
            jiaReFenshu[15].text = Score._instance.kaoheText[15].ToString();
            Table = Table +
                        "<tr>" +
                             "<td>" + jiaReFenshu[15].text + "</td>" +
                        "</tr>";
            if (Score._instance.isCaozuo[15])
            {
                jiaReFenshu[15].color = Color.green;
            }
            jiaReFenshu[16].text = Score._instance.kaoheText[16].ToString();
            Table = Table +
                        "<tr>" +
                             "<td>" + jiaReFenshu[16].text + "</td>" +
                        "</tr>";
            if (Score._instance.isCaozuo[16])
            {
                jiaReFenshu[16].color = Color.green;
            }
            jiaReFenshu[17].text = Score._instance.kaoheText[17].ToString();
            Table = Table +
                        "<tr>" +
                             "<td>" + jiaReFenshu[17].text + "</td>" +
                        "</tr>";
            if (Score._instance.isCaozuo[17])
            {
                jiaReFenshu[17].color = Color.green;
            }

            //foreach (var i in Score._instance.isCaozuo)
            //{
            //    for (int j = 0; j < jiaReFenshu.Length; j++)
            //    {
            //        jiaReFenshu[j].color = Color.green;
            //    }
            //}
            tiShiTextWenzi.text = "操作提示按钮点击了" + Score._instance.hintCiShu + "次，总分数扣分";
            tiShiTextFenshu.text = "-" + Score._instance.hintScore.ToString();
            Table = Table +
                      "<tr>" +
                           "<td align=\"center\">" + "点击提示次数:" + Score._instance.hintCiShu + ",扣除分数:" + Score._instance.hintScore + "</td>" +
                      "</tr>";
            Table = Table + tableBodyTail + tableTail;
            fenShu.text = (Score._instance.score - Score._instance.hintScore).ToString();
            if (Score._instance.score - Score._instance.hintScore <= 0)
            {
                fenShu.text = "0";
            }
            Debug.Log("发送实验结束时间");
            Debug.Log(Table);
            CreateUI.GetInstance().sendToPlatform("End:"
                + fenShu.text + " "
                + "Table:"
                + Table);
        }
    }
}
