using AzureTraining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureTraining.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resource()
        {
            List<TrainingDeck> decks = new List<TrainingDeck>();
            decks.Add(new TrainingDeck("VM 실습 자료", " "));
            decks.Add(new TrainingDeck("Azure VM 실습자료 1. Virtual Machine", "https://webinarhub.blob.core.windows.net/azurehol/1.%20Create%20Virtual%20Machine%20(Ubuntu).docx"));
            decks.Add(new TrainingDeck("Azure VM 실습자료 2. Network", "https://webinarhub.blob.core.windows.net/azurehol/2.%20Manage%20Network.docx"));
            decks.Add(new TrainingDeck("Azure VM 실습자료 3. NSG & SLB", "https://webinarhub.blob.core.windows.net/azurehol/Azure%20IaaS%20Tutorial-IIS%20%EC%84%A4%EC%B9%98.docx"));
            decks.Add(new TrainingDeck(" ", " "));
            //
            decks.Add(new TrainingDeck("IOT 실습 자료", " "));
            decks.Add(new TrainingDeck("Azure IoT Training Deck", "https://webinarhub.blob.core.windows.net/iottraining/0.%20IoT%20Training%20Allup.pptx"));
            decks.Add(new TrainingDeck("Azure IoT Training Lab #2. Create IoT Hub", "https://webinarhub.blob.core.windows.net/iottraining/2.1%20Azure%20IoT%20Hub%20LAB%20Create.docx"));
            decks.Add(new TrainingDeck("Azure IoT Training Lab #2.1 Simulated APP", "https://webinarhub.blob.core.windows.net/azurehol/2.1%20Azure%20IoT%20Hub%20LAB%20Create.docx"));
            decks.Add(new TrainingDeck("Azure IoT Training Lab #2.1 VS 실습 파일들", "https://webinarhub.blob.core.windows.net/azurehol/simulateddevice.zip"));
            decks.Add(new TrainingDeck("Azure IoT Training Lab #2.1 Raspberry pi 2", "https://webinarhub.blob.core.windows.net/iottraining/2.2%20Azure%20IoT%20Hub%20LAB%20Raspberry%20Pi2.docx"));
            decks.Add(new TrainingDeck("Azure IoT Training Lab #2.2 Ubuntu 16", "https://webinarhub.blob.core.windows.net/iottraining/2.2%20Azure%20IoT%20Hub%20LAB%20Ubuntu%201604LTS.docx"));
            decks.Add(new TrainingDeck("Azure IoT Training Lab #3. Stream Analytics", "https://webinarhub.blob.core.windows.net/iottraining/3.1%20Processing%20and%20Analytics%20LAB.docx"));
            decks.Add(new TrainingDeck("Azure IoT Training Lab #4. Azure IoT Remote Monitoring Solution", "https://webinarhub.blob.core.windows.net/iottraining/4.1%20Preconfigured%20IoT%20sol%20LAB.docx"));
            decks.Add(new TrainingDeck(" ", " "));
            //
            decks.Add(new TrainingDeck("Networking 실습 자료", " "));
            decks.Add(new TrainingDeck("Azure Networking 1. L4 Load Balancer", "https://webinarhub.blob.core.windows.net/azurehol/2.%20Manage%20Network.docx"));
            decks.Add(new TrainingDeck("Azure Networking 2. VNet2VNet & S2S", "https://webinarhub.blob.core.windows.net/azurehol/6.%20VNet2VNet.docx"));
            decks.Add(new TrainingDeck("Azure Networking 3. P2S (Point-to-Site)", "https://webinarhub.blob.core.windows.net/azurehol/Azure%20Connect%20Tutorial_P2S.docx"));

            return View(decks);
        }

        public ActionResult Freepass()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Freepass(int id = 0)
        {
            if (Request.Form["textbox1"] == null)
            {
                List<freepass> codes = new List<freepass>();
                return View(codes);
            }
            else if (Request.Form["textbox1"].ToString() == "lgdisplay")
            {
                List<freepass> codes = new List<freepass>();
                return View(codes);
            }
            else
            {
                List<freepass> codes = new List<freepass>();
                return View(codes);
            }
        }

        public ActionResult onAir()
        {
            return View();
        }


        public ActionResult Webinar()
        {
            List<WebinarVideo> videos = new List<WebinarVideo>();
            //videos.Add(new WebinarVideo("Azure Virtual Machine 소개 (기초)", "https://webinarhub.blob.core.windows.net/asset-40a423c7-8536-40e3-9ab9-43b7d411c0a7/Webinar%201%20Azure%20Virtual%20Machines.mp4?sv=2012-02-12&sr=c&si=e10065b2-efc1-464f-9955-257f94e10377&sig=W8kZzzYvAzCPASRRMfkY8AFyg%2FzI4pVwDyNzet3TTFo%3D&st=2014-09-22T08%3A38%3A18Z&se=2016-09-21T08%3A38%3A18Z", "Microsoft Azure Virtual Machine (구포털 기준) 소개 2014년 04월 22일"));
            //videos.Add(new WebinarVideo("Azure Media Service 소개 (기초) ", "https://webinarhub.blob.core.windows.net/asset-8c991a20-3d1b-4bf8-a051-1f4c067bf0fd/Webinar%202%20Azure%20Media%20Service.mp4?sv=2012-02-12&sr=c&si=cb23c298-becc-418c-aa5b-eb6e0224eb10&sig=wKw%2BniSh%2FLiBBkwvNSEqEt2Yu4VJ1vAkrRZ9fUX%2ByIo%3D&st=2014-06-25T04%3A08%3A48Z&se=2016-06-24T04%3A08%3A48Z", "Microsoft Azure Media Service (구포털 기준) 소개 2014년 06월 24일"));
            videos.Add(new WebinarVideo("Azure Media Service Live Streaming (생방송 기능) ", "https://webinarhub.blob.core.windows.net/asset-4dc1dc0f-305d-48ed-ad4a-07bb80ac0009/Azure%20Media%20Service%20Live%20Streaming.mp4?sv=2012-02-12&sr=c&si=28bf062a-1b75-4843-96b2-ea83d8e15aea&sig=GoCWQlLfTzrYvZKTBUdH%2BNB6KVj%2FRUOrg5LJgbWnky8%3D&st=2016-03-21T09%3A18%3A48Z&se=2116-02-26T09%3A18%3A48Z", "Media Service의 생방송 기능 소개 (구포털 기준) 소개 2016년 02월 17일"));
            //videos.Add(new WebinarVideo("Azure Web Site 소개 (기초) ", "https://webinarhub.blob.core.windows.net/asset-2781e371-16f7-4d05-b8a8-a2f4a6c6d4be/Webinar%203%20Azure%20Web%20Sites.mp4?sv=2012-02-12&sr=c&si=64708dee-ea71-401b-a65a-049a752951f8&sig=UrWP4HfWZZ15NAKjnhNfGgMff0FwP5YXOSvdqVugTE8%3D&st=2014-09-01T00%3A54%3A07Z&se=2016-08-31T00%3A54%3A07Z", "Microsoft Azure Web Site (구포털 기준) 소개 2014년 08월 26일"));
            //videos.Add(new WebinarVideo("Azure Remote App 소개 (기초) ", "https://webinarhub.blob.core.windows.net/asset-e480e227-4234-4935-a01f-df66f7fd40dc/Webinar%204%20Azure%20RemoteApp.mp4?sv=2012-02-12&sr=c&si=23949a29-3740-4db0-aed1-8e073f0d15d8&sig=ttcVg8Sjq27epVvxozYly1HyjtL5xbziCOHFOFoeP7Q%3D&st=2014-09-23T06%3A16%3A35Z&se=2016-09-22T06%3A16%3A35Z", "Microsoft Azure Remote App (구포털 기준) 소개 2014년 09월 23일"));
            videos.Add(new WebinarVideo("Azure CDN 소개 (기초) ", "https://webinarhub.blob.core.windows.net/asset-77129c94-1dbd-40dc-996c-ef3327e8bb36/Technet%20Azure%20CDN%20for%20ITPro.mp4?sv=2012-02-12&sr=c&si=540a1fde-75e8-4629-92f3-93e3b85696cf&sig=YYKEG4uCS%2FtZnBwMcQWkvcbtSrPTgwq72WQ3olWVE7w%3D&st=2016-03-21T09%3A18%3A44Z&se=2116-02-26T09%3A18%3A44Z", "Microsoft Azure CDN (신포털 기준) 소개 2016년 02월 24일"));
            videos.Add(new WebinarVideo("Azure Virtual Machine (고급) ", "https://webinarhub.blob.core.windows.net/asset-a2722644-b1b4-4fcd-8bb5-e3d62d968cc5/T2-S4%20Almighty_H264_4500kbps_AAC_und_ch2_128kbps.mp4?sv=2012-02-12&sr=c&si=4f88a0e3-e9f3-4e63-b08d-3a29f1ee2234&sig=FadStgszmRUTjARiByC6V4PFoSL%2FzHR6CIMKHaUWUTk%3D&st=2015-03-07T15%3A00%3A18Z&se=2017-03-06T15%3A00%3A18Z", "Microsoft Azure Virtual Machine (구포털 기준) 소개 2014년 10월"));
            return View(videos);
        }

        public ActionResult Lab01()
        {
            return View();
        }

        public ActionResult Lab02()
        {
            return View();
        }

        public ActionResult Lab03()
        {
            // Create Linux VM using PowerShell
            // 1. 

            /*
             * 
             */
            return View();
        }

        public ActionResult Lab04()
        {
            // Virtual Machine - Windows
            // 1. Create Storage
            // 2. Create Cloud Servive
            // 3. Create VMs
            // 4. Attach Disk
            // 5. Attach Disk
            /*
             * 
             */
            return View();
        }

        public ActionResult Lab11()
        {
            return View();
        }

        public ActionResult Lab12()
        {
            return View();
        }

        public ActionResult Lab20()
        {
            return View();
        }

        public ActionResult Lab101()
        {
            return View();
        }

        public ActionResult Lab102()
        {
            return View();
        }

        public ActionResult Download()
        {
            return Redirect("https://webinarhub.blob.core.windows.net/webinar-deck/Windows Azure 가상 컴퓨터 시작하기.docx");
        }
    }
}