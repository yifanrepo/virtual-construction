using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cakeslice
{
    public class MainLogic1 : MonoBehaviour {

        
		int Stage = 1;
        int Step = 0;
        int Step1 = 0;
        int Step2 = 1;
        bool Timer5Active = false;
        float TimerStart = 0.0F;
        float GazeDelay = 5.0F;
        bool Timer5Complete = false;

        RaycastHit hit;
//        bool Toolbox_Actioned = false;
        bool Worker3_Actioned = false;
        bool Intro5_Actioned = false;
        bool Intro6_Actioned = false;
        bool Intro7_Actioned = false;
		bool Intro8_Actioned = false;

		bool Materials_Actioned = false;
		bool Material_Storage_Area_Actioned = false;

		GameObject Sound = null;
        GameObject Reticle = null;
        GameObject Reticle1 = null;
        GameObject Reticle2 = null;
        GameObject Reticle3 = null;
        GameObject Reticle4 = null;
        //GameObject Reticle5 = null;
        //GameObject Reticle6 = null;
        //GameObject Reticle7 = null;
        GameObject Door_Left = null;
        GameObject Door_Right = null;
        GameObject MainCamera = null;
        GameObject Materials = null;
		GameObject Material_Storage_Area = null;
        GameObject Storage_Area_O = null;
        GameObject Materials_Attached_To_Camera = null;

        GameObject Co1 = null;
        GameObject Co2 = null;
        GameObject Co3 = null;
        GameObject Co4 = null;
        GameObject Co5 = null;
        GameObject Co6 = null;
        GameObject Co7 = null;
        GameObject Co8 = null;
        GameObject Co19 = null;
        GameObject Co20 = null;
        GameObject Co21 = null;
        GameObject Co22 = null;
        GameObject Co23 = null;
        GameObject Co24 = null;
        GameObject Co25 = null;
        GameObject Co26 = null;
        GameObject Co27 = null;
        GameObject Co28 = null;
        GameObject Co29 = null;
        GameObject Co30 = null;
        GameObject Co31 = null;
        GameObject Co32 = null;
        GameObject Co33 = null;
        GameObject Co34 = null;
        GameObject Co35 = null;
        GameObject Co36 = null;
        GameObject Co37 = null;
        GameObject Co38 = null;
        GameObject Co39 = null;
        GameObject Table = null;
        GameObject Slab = null;
        GameObject Slab4 = null;
        GameObject Slab5 = null;
        GameObject Avatar = null;
        GameObject ID = null;
        GameObject System = null;
        GameObject Player = null;
        GameObject RoadRoller = null;

        GameObject t1 = null;
        GameObject t2 = null;
        GameObject t3 = null;
        GameObject t4 = null;
        GameObject t5 = null;
        GameObject t6 = null;
        GameObject t7 = null;
        GameObject t8 = null;
        GameObject t10 = null;
        GameObject t11 = null;
        GameObject t12 = null;
        GameObject t13 = null;
        GameObject t14 = null;
        GameObject t15 = null;
        GameObject t16 = null;
        GameObject t17 = null;
        GameObject t18 = null;
        GameObject t19 = null;
        GameObject t20 = null;
        GameObject t21 = null;
        GameObject t22 = null;

        GameObject tx1 = null;
        GameObject tx2 = null;
        GameObject tx3 = null;
        GameObject tx4 = null;
        GameObject tx5 = null;
        GameObject tx6 = null;
        GameObject tx7 = null;
        GameObject tx8 = null;
        GameObject tx9 = null;
        GameObject tx10 = null;
        GameObject tx11 = null;
        GameObject tx12 = null;

        GameObject a1 = null;
        GameObject a2 = null;
        GameObject a3 = null;
        GameObject a4 = null;
        GameObject a5 = null;
        GameObject a6 = null;
        GameObject a7 = null;
        GameObject a8 = null;
        GameObject a9 = null;
        GameObject a10 = null;
        GameObject a11 = null;
        GameObject a12 = null;
        GameObject a13 = null;
        GameObject a14 = null;

        GameObject w1 = null;
        GameObject w2 = null;
        GameObject w3 = null;
        GameObject w4 = null;
        GameObject w5 = null;
        GameObject w6 = null;
        GameObject w7 = null;

        string soundFileName = "";
        bool audioPlaying = false;
		AudioSource audio =null;

        Vector3 x1;
        Vector3 x1a;
        Vector3 x2;
        Vector3 x2a;
        Vector3 x3;
        Vector3 x3a;
        Vector3 x4;
        Vector3 x4a;
        Vector3 x5;
        Vector3 x5a;
        Vector3 x6;
        Vector3 x6a;
        Vector3 x7;
        Vector3 x7a;
        Vector3 x8;
        Vector3 x8a;
        Vector3 xID;
        Vector3 xIDa;
        Vector3 x19;
        Vector3 x19a;
        Vector3 x20;
        Vector3 x20a;
        Vector3 x21;
        Vector3 x22;
        Vector3 x23;
        Vector3 x24;
        Vector3 x25;
        Vector3 x25a;

        private float distance = 4.0f;
        //public float speed;


        // Use this for initialization
        void Start() {
			//PreGame
//			Toolbox = GameObject.FindWithTag("Toolbox");
			Sound = GameObject.FindWithTag("Sound");
            Reticle = GameObject.FindWithTag("Reticle");
            Reticle1 = GameObject.FindWithTag("Reticle1");
            Reticle2 = GameObject.FindWithTag("Reticle2");
            Reticle3 = GameObject.FindWithTag("Reticle3");
            Reticle4 = GameObject.FindWithTag("Reticle4");
            //Reticle5 = GameObject.FindWithTag("Reticle5");
            //Reticle6 = GameObject.FindWithTag("Reticle6");
            //Reticle7 = GameObject.FindWithTag("Reticle7");
            Door_Left = GameObject.FindWithTag("Door_Left");
            Door_Right = GameObject.FindWithTag("Door_Right");
            MainCamera = GameObject.FindWithTag("MainCamera");
            Storage_Area_O = GameObject.FindWithTag("Storage_Area_O");
            ID = GameObject.FindWithTag("ID");
            System = GameObject.FindWithTag("System");
            Player = GameObject.FindWithTag("Player");

            Co1 = GameObject.FindWithTag("1");
            Co2 = GameObject.FindWithTag("2");
            Co3 = GameObject.FindWithTag("3");
            Co4 = GameObject.FindWithTag("4");
            Co5 = GameObject.FindWithTag("5");
            Co6 = GameObject.FindWithTag("6");
            Co7 = GameObject.FindWithTag("7");
            Co8 = GameObject.FindWithTag("8");
            Co19 = GameObject.FindWithTag("19");
            Co20 = GameObject.FindWithTag("20");
            Co21 = GameObject.FindWithTag("21");
            Co22 = GameObject.FindWithTag("22");
            Co23 = GameObject.FindWithTag("23");
            Co24 = GameObject.FindWithTag("24");
            Co25 = GameObject.FindWithTag("25");
            Co26 = GameObject.FindWithTag("26");
            Co27 = GameObject.FindWithTag("27");
            Co28 = GameObject.FindWithTag("28");
            Co29 = GameObject.FindWithTag("29");
            Co30 = GameObject.FindWithTag("30");
            Co31 = GameObject.FindWithTag("31");
            Co32 = GameObject.FindWithTag("32");
            Co33 = GameObject.FindWithTag("33");
            Co34 = GameObject.FindWithTag("34");
            Co35 = GameObject.FindWithTag("35");
            Co36 = GameObject.FindWithTag("36");
            Co37 = GameObject.FindWithTag("37");
            Co38 = GameObject.FindWithTag("38");
            Co39 = GameObject.FindWithTag("39");
            Table = GameObject.FindWithTag("Table");
            Slab = GameObject.FindWithTag("Slab");
            Slab4 = GameObject.FindWithTag("Slab4");
            Slab5 = GameObject.FindWithTag("Slab5");
            Avatar = GameObject.FindWithTag("Avatar");
            RoadRoller = GameObject.FindWithTag("RoadRoller");

            t1 = GameObject.FindWithTag("t1");
            t2 = GameObject.FindWithTag("t2");
            t3 = GameObject.FindWithTag("t3");
            t4 = GameObject.FindWithTag("t4");
            t5 = GameObject.FindWithTag("t5");
            t6 = GameObject.FindWithTag("t6");
            t7 = GameObject.FindWithTag("t7");
            t8 = GameObject.FindWithTag("t8");
            t10 = GameObject.FindWithTag("t10");
            t11 = GameObject.FindWithTag("t11");
            t12 = GameObject.FindWithTag("t12");
            t13 = GameObject.FindWithTag("t13");
            t14 = GameObject.FindWithTag("t14");
            t15 = GameObject.FindWithTag("t15");
            t16 = GameObject.FindWithTag("t16");
            t17 = GameObject.FindWithTag("t17");
            t18 = GameObject.FindWithTag("t18");
            t19 = GameObject.FindWithTag("t19");
            t20 = GameObject.FindWithTag("t20");
            t21 = GameObject.FindWithTag("t21");
            t22 = GameObject.FindWithTag("t22");

            tx1 = GameObject.FindWithTag("tx1");
            tx2 = GameObject.FindWithTag("tx2");
            tx3 = GameObject.FindWithTag("tx3");
            tx4 = GameObject.FindWithTag("tx4");
            tx5 = GameObject.FindWithTag("tx5");
            tx6 = GameObject.FindWithTag("tx6");
            tx7 = GameObject.FindWithTag("tx7");
            tx8 = GameObject.FindWithTag("tx8");
            tx9 = GameObject.FindWithTag("tx9");
            tx10 = GameObject.FindWithTag("tx10");
            tx11 = GameObject.FindWithTag("tx11");
            tx12 = GameObject.FindWithTag("tx12");

            a1 = GameObject.FindWithTag("a1");
            a2 = GameObject.FindWithTag("a2");
            a3 = GameObject.FindWithTag("a3");
            a4 = GameObject.FindWithTag("a4");
            a5 = GameObject.FindWithTag("a5");
            a6 = GameObject.FindWithTag("a6");
            a7 = GameObject.FindWithTag("a7");
            a8 = GameObject.FindWithTag("a8");
            a9 = GameObject.FindWithTag("a9");
            a10 = GameObject.FindWithTag("a10");
            a11 = GameObject.FindWithTag("a11");
            a12 = GameObject.FindWithTag("a12");
            a13 = GameObject.FindWithTag("a13");
            a14 = GameObject.FindWithTag("a14");

            w1 = GameObject.FindWithTag("w1");
            w2 = GameObject.FindWithTag("w2");
            w3 = GameObject.FindWithTag("w3");
            w4 = GameObject.FindWithTag("w4");
            w5 = GameObject.FindWithTag("w5");
            w6 = GameObject.FindWithTag("w6");
            w7 = GameObject.FindWithTag("w7");
            //            Lid = GameObject.FindWithTag("Lid");
            //Task1
            Materials = GameObject.FindWithTag("Materials");
			Material_Storage_Area = GameObject.FindWithTag("Material_Storage_Area");

			//Task2

            //Turotial
            Co1.SetActive(false);
            Co2.SetActive(false);
            Co3.SetActive(false);
            Co4.SetActive(false);
            Co5.SetActive(false);
            Co6.SetActive(false);
            Co7.SetActive(false);
            Co8.SetActive(false);
            Co19.SetActive(false);
            Co20.SetActive(false);
            Co21.SetActive(false);
            //Co22.SetActive(false);
            Co23.SetActive(false);
            //Co24.SetActive(false);
            Co25.SetActive(false);
            Co26.SetActive(false);
            Co27.SetActive(false);
            //Co28.SetActive(false);
            //Co29.SetActive(false);
            Co30.SetActive(false);
            //Co31.SetActive(false);
            Co32.SetActive(false);
            Co33.SetActive(false);
            //Co34.SetActive(false);
            //Co35.SetActive(false);
            Co36.SetActive(false);
            Co37.SetActive(false);
            Co38.SetActive(false);
            Co39.SetActive(false);
            Table.SetActive(false);
            Slab.SetActive(false);
            Slab4.SetActive(false);
            Slab5.SetActive(false);
            ID.SetActive(false);
            RoadRoller.SetActive(false);
            //Show objects

            //Hide objects
            Reticle.SetActive(false);
            Reticle1.SetActive(false);
            Reticle2.SetActive(false);
            Reticle3.SetActive(false);
            Reticle4.SetActive(false);
            //Reticle5.SetActive(false);
            //Reticle6.SetActive(false);
            //Reticle7.SetActive(false);
            //Toolbox.SetActive(false);

            a1.SetActive(false);
            a2.SetActive(false);
            a3.SetActive(false);
            a4.SetActive(false);
            a5.SetActive(false);
            a6.SetActive(false);
            a7.SetActive(false);
            a8.SetActive(false);
            a9.SetActive(false);
            a10.SetActive(false);
            a11.SetActive(false);
            a12.SetActive(false);
            a13.SetActive(false);
            a14.SetActive(false);

            w1.SetActive(true);
            w2.SetActive(true);
            w3.SetActive(true);
            w4.SetActive(true);
            w5.SetActive(true);
            w6.SetActive(false);
            w7.SetActive(true);
        }

		void Update()
        {
            switch (Stage)
            {
                case 1:
                    PreGame();
                    break;
                case 2:
                    Entrance();
                    break;
                case 3:
                    Task();
                    break;
            }
        }

        bool PlaySound(string soundFileName)
        {
            switch (soundFileName)
            {
                case "1":
                    audio = Sound.transform.Find("Clip1").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        audio.Stop();
                        audioPlaying = false;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "2":
				    //Debug.Log("clip2");
                    audio = Sound.transform.Find("Clip2").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        audio.Stop();
                        audioPlaying = false;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "3":
				    //Debug.Log("clip3");
				    audio = Sound.transform.Find("Clip3").gameObject.GetComponent<AudioSource>();
				    //if the sound has finished playing return true
				    if (audioPlaying && !audio.isPlaying)
				    {
                        audio.Stop();
                        audioPlaying = false;
    					return true;
				    }
				    //if the sound is still playing return false
				    if (audioPlaying && audio.isPlaying) return false;
				    //if the sound has not been played yet
				    if (!audioPlaying)
				    {
	    				audioPlaying = true;
		    			audio.Play();
			    		return false;
				    }
                    //return false;
                    break;
                case "4":
                    audio = Sound.transform.Find("Clip4").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        audio.Stop();
                        audioPlaying = false;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
			    case "5":
				    audio = Sound.transform.Find("Clip5").gameObject.GetComponent<AudioSource>();
				    //if the sound has finished playing return true
				    if (audioPlaying && !audio.isPlaying)
				    {
                        Debug.Log("stopped audio for Clip5");
                        audio.Stop();
                        audioPlaying = false;
                        Intro5_Actioned = true;
					    return true;
				    }
				    //if the sound is still playing return false
				    if (audioPlaying && audio.isPlaying) return false;
				    //if the sound has not been played yet
				    if (!audioPlaying)
				    {
                        Debug.Log("triggered Clip5");
					    audioPlaying = true;
					    audio.Play();
					    return false;
				    }
				    //return false;
				    break;
			case "6":
				audio = Sound.transform.Find("Clip6").gameObject.GetComponent<AudioSource>();
				//if the sound has finished playing return true
				if (audioPlaying && !audio.isPlaying)
				{
					Debug.Log("stopped audio for Clip5");
					audio.Stop();
					audioPlaying = false;
					Intro6_Actioned = true;
					return true;
				}
				//if the sound is still playing return false
				if (audioPlaying && audio.isPlaying) return false;
				//if the sound has not been played yet
				if (!audioPlaying)
				{
					Debug.Log("triggered Clip6");
					audioPlaying = true;
					audio.Play();
					return false;
				}
				//return false;
				break;
			case "7":
				audio = Sound.transform.Find("Clip7").gameObject.GetComponent<AudioSource>();
				//if the sound has finished playing return true
				if (audioPlaying && !audio.isPlaying)
				{
					Debug.Log("stopped audio for Clip5");
					audio.Stop();
					audioPlaying = false;
					Intro7_Actioned = true;
					return true;
				}
				//if the sound is still playing return false
				if (audioPlaying && audio.isPlaying) return false;
				//if the sound has not been played yet
				if (!audioPlaying)
				{
					Debug.Log("triggered Clip6");
					audioPlaying = true;
					audio.Play();
					return false;
				}
				//return false;
				break;
			case "8":
				audio = Sound.transform.Find("Clip8").gameObject.GetComponent<AudioSource>();
				//if the sound has finished playing return true
				if (audioPlaying && !audio.isPlaying)
				{
					Debug.Log("stopped audio for Clip8");
					audio.Stop();
					audioPlaying = false;
					Intro8_Actioned = true;
					return true;
				}
				//if the sound is still playing return false
				if (audioPlaying && audio.isPlaying) return false;
				//if the sound has not been played yet
				if (!audioPlaying)
				{
					Debug.Log("triggered Clip6");
					audioPlaying = true;
					audio.Play();
					return false;
				}
				//return false;
				break;
                case "8a":
                    audio = Sound.transform.Find("Clip8a").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        Debug.Log("stopped audio for Clip8");
                        audio.Stop();
                        audioPlaying = false;
                        Intro8_Actioned = true;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        Debug.Log("triggered Clip6");
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "9":
                    audio = Sound.transform.Find("Clip9").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        Debug.Log("stopped audio for Clip8");
                        audio.Stop();
                        audioPlaying = false;
                        Intro8_Actioned = true;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        Debug.Log("triggered Clip6");
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "11":
                    audio = Sound.transform.Find("Clip11").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        Debug.Log("stopped audio for Clip8");
                        audio.Stop();
                        audioPlaying = false;
                        Intro8_Actioned = true;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        Debug.Log("triggered Clip6");
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "14":
                    audio = Sound.transform.Find("Clip14").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        Debug.Log("stopped audio for Clip8");
                        audio.Stop();
                        audioPlaying = false;
                        Intro8_Actioned = true;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        Debug.Log("triggered Clip6");
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "16":
                    audio = Sound.transform.Find("Clip16").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        Debug.Log("stopped audio for Clip8");
                        audio.Stop();
                        audioPlaying = false;
                        Intro8_Actioned = true;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        Debug.Log("triggered Clip6");
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "17":
                    audio = Sound.transform.Find("Clip17").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        Debug.Log("stopped audio for Clip8");
                        audio.Stop();
                        audioPlaying = false;
                        Intro8_Actioned = true;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        Debug.Log("triggered Clip6");
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "18":
                    audio = Sound.transform.Find("Clip18").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        Debug.Log("stopped audio for Clip8");
                        audio.Stop();
                        audioPlaying = false;
                        Intro8_Actioned = true;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        Debug.Log("triggered Clip6");
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "19":
                    audio = Sound.transform.Find("Clip19").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        Debug.Log("stopped audio for Clip8");
                        audio.Stop();
                        audioPlaying = false;
                        Intro8_Actioned = true;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        Debug.Log("triggered Clip6");
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "20":
                    audio = Sound.transform.Find("Clip20").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        Debug.Log("stopped audio for Clip8");
                        audio.Stop();
                        audioPlaying = false;
                        Intro8_Actioned = true;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        Debug.Log("triggered Clip6");
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "21":
                    audio = Sound.transform.Find("Clip21").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        Debug.Log("stopped audio for Clip8");
                        audio.Stop();
                        audioPlaying = false;
                        Intro8_Actioned = true;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        Debug.Log("triggered Clip6");
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "22":
                    audio = Sound.transform.Find("Clip22").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        Debug.Log("stopped audio for Clip8");
                        audio.Stop();
                        audioPlaying = false;
                        Intro8_Actioned = true;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        Debug.Log("triggered Clip6");
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "23":
                    audio = Sound.transform.Find("Clip23").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        Debug.Log("stopped audio for Clip8");
                        audio.Stop();
                        audioPlaying = false;
                        Intro8_Actioned = true;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        Debug.Log("triggered Clip6");
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "24":
                    audio = Sound.transform.Find("Clip24").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        Debug.Log("stopped audio for Clip8");
                        audio.Stop();
                        audioPlaying = false;
                        Intro8_Actioned = true;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        Debug.Log("triggered Clip6");
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "25":
                    audio = Sound.transform.Find("Clip25").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        Debug.Log("stopped audio for Clip8");
                        audio.Stop();
                        audioPlaying = false;
                        Intro8_Actioned = true;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        Debug.Log("triggered Clip6");
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "5sSilence":
                    audio = Sound.transform.Find("ClipSilence").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        audio.Stop();
                        audioPlaying = false;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "1sSilence":
                    audio = Sound.transform.Find("1Silence").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        audio.Stop();
                        audioPlaying = false;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "Welldone":
                    audio = Sound.transform.Find("Welldone").gameObject.GetComponent<AudioSource>();
                    //if the sound has finished playing return true
                    if (audioPlaying && !audio.isPlaying)
                    {
                        audio.Stop();
                        audioPlaying = false;
                        return true;
                    }
                    //if the sound is still playing return false
                    if (audioPlaying && audio.isPlaying) return false;
                    //if the sound has not been played yet
                    if (!audioPlaying)
                    {
                        audioPlaying = true;
                        audio.Play();
                        return false;
                    }
                    //return false;
                    break;
                case "26":
				    break;
                }
            return false;
        }

        void PreGame()
        {

            switch (Step)
            {
                case 0:
                    //setcameraposition		
                    //make the reticle invisible
                    //play first sound file until it finishes
                    Table.SetActive(true);
                    Avatar.GetComponent<OvrAvatar>().StartWithControllers = true;
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step = Step + 1;
                    };
                    break;
                case 1:
                    //setcameraposition		
                    //make the reticle invisible
                    //play first sound file until it finishes
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step = Step + 1;
                    };
                    break;
                case 2:
                    //setcameraposition		
                    //make the reticle invisible
                    //play first sound file until it finishes
                    soundFileName = "1";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step = Step + 1;
                    };
                    break;
                case 3:
                    //setcameraposition		
                    //make the reticle invisible
                    //play first sound file until it finishes
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step = Step + 1;
                    };
                    break;
                case 4:
                    //setcameraposition		
                    //make the reticle invisible
                    //play first sound file until it finishes
                    //Reticle.SetActive(true);
                    soundFileName = "2";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step = Step + 1;
                    };
                    break;
                case 5:
                    //setcameraposition		
                    //make the reticle invisible
                    //play first sound file until it finishes
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step = Step + 1;
                    };
                    break;
                case 6:
                    //setcameraposition		
                    //make the reticle invisible
                    //play first sound file until it finishes
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Avatar.GetComponent<OvrAvatar>().StartWithControllers = false;
                        Step = Step + 1;
                    };
                    break;
                case 7:
                    //play second sound file until it finishes
                    Reticle.SetActive(true);
                    soundFileName = "3";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step = Step + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 8:
                    //setcameraposition		
                    //make the reticle invisible
                    //play first sound file until it finishes
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Reticle.SetActive(false);
                        Step = Step + 1;
                    };
                    break;
                case 9:
                    //play second sound file until it finishes
                    Reticle1.SetActive(true);
                    soundFileName = "4";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step = Step + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 10:
                    //setcameraposition		
                    //make the reticle invisible
                    //play first sound file until it finishes
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Reticle1.SetActive(false);
                        Step = Step + 1;
                    };
                    break;
                case 11:
                    //play second sound file until it finishes
                    Reticle2.SetActive(true);
                    soundFileName = "5";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Co1.SetActive(true);
                        a1.SetActive(true);
                        Step = Step + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 12:
                    soundFileName = "1sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        x1 = Co1.transform.position;
                        Step = Step + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 13:
                    x1a = Co1.transform.position;
                    if (x1 != x1a)
                    {
                        //Step += step;
                        Debug.Log("Some Objects Have Been Moved");
                        Reticle2.SetActive(false);
                        a1.SetActive(false);
                        Step = Step + 1;
                    };
                    break;
                case 14:
                    //play second sound file until it finishe
                    soundFileName = "6";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step = Step + 1;
                        Co1.SetActive(false);
                        t1.SetActive(false);
                        //Debug.Log("after 2");
                    };
                    break;
                case 15:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step = Step + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 16:
                    //play second sound file until it finishes
                    Reticle3.SetActive(true);
                    soundFileName = "7";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Co2.SetActive(true);
                        Co3.SetActive(true);
                        Co4.SetActive(true);
                        Co5.SetActive(true);
                        Co6.SetActive(true);
                        Co8.SetActive(true);
                        a2.SetActive(true);
                        Step = Step + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 17:
                    soundFileName = "1sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2"); 
                        x2 = Co2.transform.position;
                        x3 = Co3.transform.position;
                        x4 = Co4.transform.position;
                        x5 = Co5.transform.position;
                        x6 = Co6.transform.position;
                        x8 = Co8.transform.position;
                        Step = Step + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 18:
                    x2a = Co2.transform.position;
                    x3a = Co3.transform.position;
                    x4a = Co4.transform.position;
                    x5a = Co5.transform.position;
                    x6a = Co6.transform.position;
                    x8a = Co8.transform.position;
                    if (x2 != x2a)
                        {
                        a2.transform.position = new Vector3(30.145f, -0.81f, 54.568f);
                    }
                    if (x8 != x8a)
                        {
                        a2.transform.position = new Vector3(30.145f, -0.81f, 55.305f);
                    }
                    if (x3 != x3a)
                    {
                        a2.transform.position = new Vector3(30.145f, -0.81f, 56.159f);
                    }
                    if (x4 != x4a)
                    {
                        a2.transform.position = new Vector3(30.145f, -0.81f, 56.949f);
                    }
                    if (x5 != x5a)
                    {
                        a2.transform.position = new Vector3(31.188f, -0.42f, 58.323f);
                    }
                    if ((x2 != x2a) && (x3 != x3a) && (x4 != x4a) && (x5 != x5a) && (x6 != x6a) && (x8 != x8a))
                    {
                        //Step += step;
                        Debug.Log("All Objects Have Been Moved");
                        a2.SetActive(false);
                        Step = Step + 1;
                    };
                    break;
                case 19:
                    soundFileName = "Welldone";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Reticle3.SetActive(false);
                        Step = Step + 1;
                    };
                    break;
                case 20:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Co2.SetActive(false);
                        Co3.SetActive(false);
                        Co4.SetActive(false);
                        Co5.SetActive(false);
                        Co6.SetActive(false);
                        Co8.SetActive(false);
                        Table.SetActive(false);
                        t2.SetActive(false);
                        t3.SetActive(false);
                        t4.SetActive(false);
                        t5.SetActive(false);
                        t18.SetActive(false);
                        t8.SetActive(false);
                        Step = Step + 1;
                    };
                    break;
                case 21:
                    Reticle4.SetActive(true);
                    soundFileName = "8";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Co7.SetActive(true);
                        a3.SetActive(true);
                        a4.SetActive(true);
                        Step = Step + 1;
                    };
                    break;
                case 22:
                    soundFileName = "1sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        x7 = Co7.transform.position;
                        Step = Step + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 23:
                    x7a = Co7.transform.position;
                    if (x7a != x7)
                    {
                        //Step += step;
                        Reticle4.SetActive(false);
                        a3.SetActive(false);
                        a4.SetActive(false);
                        Step = Step + 1;
                    };
                    break;
                case 24:
                    soundFileName = "8a";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Slab.SetActive(true);
                        a5.SetActive(true);
                        Step = Step + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 25:
                    if (Co7.GetComponent<Housekeeping>().isOn == true)
                    {
                        //Debug.Log("2");
                        Step = Step + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 26:
                    soundFileName = "9";
                    a5.SetActive(false);
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step = Step + 1;
                        Co7.SetActive(false);
                        t7.SetActive(false);
                        Slab.SetActive(false);
                        Avatar.GetComponent<OvrAvatar>().StartWithControllers = false;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeOut = true;
                    };
                    break;
                case 27:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Stage = 2;
                        Step = Step + 1;
                    };
                    break;
                case 28:
                    break;
            }

        }

        void Entrance() {

                switch (Step1)
                {
                case 0:
                    //make the reticle visible
                    //Debug.Log("case2");
                    //play second sound file until it finishes
                    System.transform.position = new Vector3(65.181f, -0.084f, 41.51f);
                    Player.transform.position = new Vector3(65.181f, 1.546f, 41.51f);
                    MainCamera.GetComponent<OVRScreenFade1>().fadeOut = false;
                    MainCamera.GetComponent<OVRScreenFade1>().fadeIn = true;
                    RoadRoller.SetActive(true);
                    Step1 = Step1 + 1;
                    break;
                case 1:
                    //make the reticle visible
                    //Debug.Log("case2");
                    //play second sound file until it finishes
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
					//Debug.Log("2");
                        Step1 = Step1 + 1;
					//Debug.Log("after 2");
                    };
                    break;
                case 2:
                    MainCamera.GetComponent<OVRScreenFade1>().fadeIn = false;
                    //make the reticle visible
                    //Debug.Log("case2");
                    //play second sound file until it finishes
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 3:
                    //make the reticle visible
                    //Debug.Log("case2");
                    //play second sound file until it finishes
                    soundFileName = "14";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        ID.SetActive(true);
                        xID = ID.transform.position;
                        a6.SetActive(true);
                        a7.SetActive(true);
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 4:
                    xIDa = ID.transform.position;
                    if (xIDa != xID)
                    {
                        //Step += step;
                        a6.SetActive(false);
                    };
                    if (ID.GetComponent<JustForNow>().isOpen == true)
                    {
                        Step1 = Step1 + 1;
                        a7.SetActive(false);
                    };
                    break;
                case 5:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        ID.SetActive(false);
                        t19.SetActive(false);
                        t20.SetActive(false);
                        MainCamera.GetComponent<OVRScreenFade1>().fadeOut = true;
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
			//case 17:
                    //make the toolbox visible, play the sound file attached to the toolbox, and close the toolbox lid
                    //Debug.Log("case3");
                    //play fourth sound file until it finishes
//                    if (Lid.GetComponent<Animator>().GetBool("Toolbox Trigger") == true)
//                    {
//                        Step = Step + 1;
//                    }
				//if (Safety_Pass.transform.position != new Vector3(91.544f, 1.479f, 47.723f))
        //        if (Safety_Pass.transform.hasChanged)
				    //{
        //                Reticle.SetActive(false);
        //                Step = Step + 1;
				    //}
        //            break;
                case 6: //play fourth sound file until it finishes
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Stage = 3;
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 7:
                    break;
            }
                    
        }
            
        void Task() {

            switch (Step2)
            {
                case 1:
                    //setcameraposition	
                    Door_Left.GetComponent<Animator>().SetBool("Door_Left1", true);
                    Door_Right.GetComponent<Animator>().SetBool("Door_Right1", true);
                    System.transform.position = new Vector3(31.53f, -0.084f, 19.081f);
                    Player.transform.position = new Vector3(31.53f, 1.546f, 19.081f);
                    MainCamera.GetComponent<OVRScreenFade1>().fadeOut = false;
                    MainCamera.GetComponent<OVRScreenFade1>().fadeIn = true;
                    w1.SetActive(false);
                    w2.SetActive(false);
                    Co19.SetActive(true);
                    a9.SetActive(true);
                    a12.SetActive(true);
                    Step2 = Step2 + 1;
                    break;
                case 2:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeIn = false;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 3:
                    soundFileName = "16";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        //Storage_Area_O.GetComponent<Animator>().SetBool("Storage_Area", true);
                        x19 = Co19.transform.position;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 4:
                    x19a = Co19.transform.position;
                    if (x19a != x19)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                        a9.SetActive(false);
                        Co20.SetActive(true);
                        a8.SetActive(true);
                    };
                    break;
                case 5:
                    soundFileName = "1sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        x20 = Co20.transform.position;
                        Step2 = Step2 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 6:
                    x20a = Co20.transform.position;
                    if (x20a != x20)
                    {
                        //Step += step;
                        a8.SetActive(false);
                    };
                    soundFileName = "18";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 7:
                    x20a = Co20.transform.position;
                    if (x20a != x20)
                    {
                        //Step += step;
                        a8.SetActive(false);
                    };
                    if (Co19.GetComponent<Housekeeping1>().isOn == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                        a14.SetActive(true);
                        a12.SetActive(false);
                    };
                    break;
                case 8:
                    soundFileName = "19";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        //Reticle7.SetActive(false);
                        Step2 = Step2 + 1;
                    };
                    break;
                case 9:
                    if (Co19.GetComponent<Proceed>().isOn == true)
                    {
                        a14.SetActive(false);
                        a8.SetActive(false);
                        Step2 = Step2 + 1;
                    };
                    break;
                case 10:
                    soundFileName = "20";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                        Co19.SetActive(false);
                        Co20.SetActive(false);
                        t6.SetActive(false);
                        t21.SetActive(false);
                    };
                    break;
                case 11:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 12:
                    soundFileName = "21";
                    Co21.SetActive(true);
                    //Co22.SetActive(true);
                    Co23.SetActive(true);
                    //Co24.SetActive(true);
                    Co25.SetActive(true);
                    Co26.SetActive(true);
                    Co27.SetActive(true);
                    //Co28.SetActive(true);
                    //Co29.SetActive(true);
                    Co30.SetActive(true);
                    //Co31.SetActive(true);
                    Co32.SetActive(true);
                    Co33.SetActive(true);
                    //Co34.SetActive(true);
                    //Co35.SetActive(true);
                    Co36.SetActive(true);
                    Co37.SetActive(true);
                    Co38.SetActive(true);
                    Co39.SetActive(true);
                    a11.SetActive(true);
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 13:
                    MainCamera.GetComponent<OVRScreenFade1>().fadeOut = true;
                    Player.GetComponent<OVRPlayerController>().enabled = false;
                    Step2 = Step2 + 1;
                    //};
                    break;

                case 14:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        MainCamera.GetComponent<OVRScreenFade1>().fadeOut = false;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeIn = true;
                        //Debug.Log("2");
                        x21 = w3.transform.position;
                        //if (System.transform.position != x21)
                        //{
                        //float step = speed * Time.deltaTime;
                        //System.transform.position = Vector3.MoveTowards(System.transform.position, x21, step);
                        //Player.transform.position = Vector3.MoveTowards(Player.transform.position, x21, step);
                        System.transform.position = x21;
                        Player.transform.position = x21;
                        Step2 = Step2 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 15:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step2 = Step2 + 1;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeIn = false;
                        //Debug.Log("after 2");
                    };
                    break;
                case 16:
                    soundFileName = "1sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step2 = Step2 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 17:
                    soundFileName = "1sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step2 = Step2 + 1;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeOut = true;
                        //Debug.Log("after 2");
                    };
                    break;
                case 18:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        MainCamera.GetComponent<OVRScreenFade1>().fadeOut = false;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeIn = true;
                        x22 = w4.transform.position;
                //if (System.transform.position != x22)
                //{
                        //float step = speed * Time.deltaTime;
                        //System.transform.position = Vector3.MoveTowards(System.transform.position, x22, step);
                        //Player.transform.position = Vector3.MoveTowards(Player.transform.position, x22, step);
                        System.transform.position = x22;
                        Player.transform.position = x22;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 19:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step2 = Step2 + 1;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeIn = false;
                        //Debug.Log("after 2");
                    };
                    break;
                case 20:
                    soundFileName = "22";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeOut = true;
                    };
                    break;
                case 21:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        MainCamera.GetComponent<OVRScreenFade1>().fadeOut = false;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeIn = true;
                        x23 = w5.transform.position;
                    //if (System.transform.position != x23)
                    //{
                        //float step = speed * Time.deltaTime;
                        //System.transform.position = Vector3.MoveTowards(System.transform.position, x23, step);
                        //Player.transform.position = Vector3.MoveTowards(Player.transform.position, x23, step);
                        System.transform.position = x23;
                        Player.transform.position = x23;
                    Step2 = Step2 + 1;
                    };
                    break;
                case 22:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step2 = Step2 + 1;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeIn = false;
                        Door_Left.GetComponent<Animator>().SetBool("Door_Left2", true);
                        Door_Right.GetComponent<Animator>().SetBool("Door_Right2", true);
                        //Debug.Log("after 2");
                    };
                    break;
                case 23:
                    soundFileName = "1sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step2 = Step2 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 24:
                    soundFileName = "1sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step2 = Step2 + 1;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeOut = true;
                        //Debug.Log("after 2");
                    };
                    break;
                case 25:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        MainCamera.GetComponent<OVRScreenFade1>().fadeOut = false;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeIn = true;
                        x22 = w4.transform.position;
                    //if (System.transform.position != x22)
                    //{
                        //float step = speed * Time.deltaTime;
                        //System.transform.position = Vector3.MoveTowards(System.transform.position, x22, step);
                        //Player.transform.position = Vector3.MoveTowards(Player.transform.position, x22, step);
                        System.transform.position = x22;
                        Player.transform.position = x22;
                    Step2 = Step2 + 1;
                    };
                    break;
                case 26:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step2 = Step2 + 1;
                        Slab4.SetActive(true);
                        MainCamera.GetComponent<OVRScreenFade1>().fadeIn = false;
                        Player.GetComponent<OVRPlayerController>().enabled = true;
                        //Debug.Log("after 2");
                    };
                    break;
                case 27:
                    soundFileName = "25";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 28:
                    if (Player.GetComponent<Proceed1>().isOn == true)
                    {
                        //Debug.Log("2");
                            MainCamera.GetComponent<OVRScreenFade1>().fadeOut = true;
                            Step2 = Step2 + 4;
                            //Debug.Log("after 2");
                        //Debug.Log("after 2");
                    };
                    if ((Co21.GetComponent<Housekeeping1>().isOn == true)|| (Co23.GetComponent<Housekeeping1>().isOn == true) || (Co25.GetComponent<Housekeeping1>().isOn == true) || (Co26.GetComponent<Housekeeping1>().isOn == true) || (Co27.GetComponent<Housekeeping1>().isOn == true) || (Co30.GetComponent<Housekeeping1>().isOn == true) || (Co32.GetComponent<Housekeeping1>().isOn == true) || (Co33.GetComponent<Housekeeping1>().isOn == true)||(Co36.GetComponent<Housekeeping1>().isOn == true) || (Co37.GetComponent<Housekeeping1>().isOn == true) || (Co38.GetComponent<Housekeeping1>().isOn == true) || (Co39.GetComponent<Housekeeping1>().isOn == true))
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                        a14.SetActive(true);
                    };
                    break;
                case 29:
                    soundFileName = "23";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 30:
                    if ((Co21.GetComponent<Proceed>().isOn == true) || (Co23.GetComponent<Proceed>().isOn == true) || (Co25.GetComponent<Proceed>().isOn == true) || (Co26.GetComponent<Proceed>().isOn == true) || (Co27.GetComponent<Proceed>().isOn == true) || (Co30.GetComponent<Proceed>().isOn == true) || (Co32.GetComponent<Proceed>().isOn == true) || (Co33.GetComponent<Proceed>().isOn == true) || (Co36.GetComponent<Proceed>().isOn == true) || (Co37.GetComponent<Proceed>().isOn == true) || (Co38.GetComponent<Proceed>().isOn == true) || (Co39.GetComponent<Proceed>().isOn == true))
                    {
                        a14.SetActive(false);
                        Co21.SetActive(false);
                        //Co22.SetActive(true);
                        Co23.SetActive(false);
                        //Co24.SetActive(true);
                        Co25.SetActive(false);
                        Co26.SetActive(false);
                        Co27.SetActive(false);
                        //Co28.SetActive(true);
                        //Co29.SetActive(true);
                        Co30.SetActive(false);
                        //Co31.SetActive(true);
                        Co32.SetActive(false);
                        Co33.SetActive(false);
                        //Co34.SetActive(true);
                        //Co35.SetActive(true);
                        Co36.SetActive(false);
                        Co37.SetActive(false);
                        Co38.SetActive(false);
                        Co39.SetActive(false);
                        a11.SetActive(false);
                        tx1.SetActive(false);
                        tx2.SetActive(false);
                        tx3.SetActive(false);
                        tx4.SetActive(false);
                        tx5.SetActive(false);
                        tx6.SetActive(false);
                        tx7.SetActive(false);
                        tx8.SetActive(false);
                        tx9.SetActive(false);
                        tx10.SetActive(false);
                        tx11.SetActive(false);
                        tx12.SetActive(false);
                        Step2 = Step2 + 1;
                    };
                    break;
                case 31:
                    soundFileName = "Welldone";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeOut = true;
                    };
                    break;
                case 32:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        MainCamera.GetComponent<OVRScreenFade1>().fadeOut = false;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeIn = true;
                        a11.SetActive(false);
                        x24 = w7.transform.position;
                        //if (System.transform.position != x23)
                        //{
                        //float step = speed * Time.deltaTime;
                        //System.transform.position = Vector3.MoveTowards(System.transform.position, x23, step);
                        //Player.transform.position = Vector3.MoveTowards(Player.transform.position, x23, step);
                        System.transform.position = x24;
                        Player.transform.position = x24;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 33:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step2 = Step2 + 1;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeIn = false;
                        w6.SetActive(true);
                        Slab5.SetActive(true);
                        t22.SetActive(true);
                        a13.SetActive(true);
                        a10.SetActive(true);
                        a12.SetActive(true);
                        Player.GetComponent<OVRPlayerController>().enabled = false;
                        //Debug.Log("after 2");
                    };
                    break;
                case 34:
                    x25 = w6.transform.position;
                    soundFileName = "24";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Player.GetComponent<OVRPlayerController>().enabled = true;
                        Step2 = Step2 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 35:
                    if (Player.GetComponent<Proceed2>().isOn == true)
                    {
                        //Debug.Log("2");
                        soundFileName = "17";
                        if (PlaySound(soundFileName) == true)
                        {
                            //Debug.Log("2");
                            MainCamera.GetComponent<OVRScreenFade1>().fadeOut = true;
                            Step2 = Step2 + 2;
                            //Debug.Log("after 2");
                        };
                        //Debug.Log("after 2");
                    };
                    x25a = w6.transform.position;
                    if (x25a != x25)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 36:
                    soundFileName = "17";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step2 = Step2 + 1;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeOut = true;
                        //Debug.Log("after 2");
                    };
                    break;
                case 37:
                    break;
            }
        }
    }
}