using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cakeslice
{
    public class MainLogic2 : MonoBehaviour {

        
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
        GameObject Reticle5 = null;
        GameObject Reticle6 = null;
        GameObject Reticle7 = null;
        GameObject Door_Left = null;
        GameObject Door_Right = null;
        GameObject MainCamera = null;
        GameObject Materials = null;
		GameObject Material_Storage_Area = null;
        GameObject Storage_Area = null;
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
        GameObject Co10 = null;
        GameObject Co11 = null;
        GameObject Co12 = null;
        GameObject Co13a = null;
        GameObject Co14 = null;
        GameObject Co15a = null;
        GameObject Co16 = null;
        GameObject Co17 = null;
        GameObject Co18 = null;
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
        GameObject t10 = null;
        GameObject t11 = null;
        GameObject t12 = null;
        GameObject t13 = null;
        GameObject t14 = null;
        GameObject t15 = null;
        GameObject t16 = null;
        GameObject t17 = null;
        GameObject t18 = null;

        GameObject e1 = null;
        GameObject e2 = null;
        GameObject e3 = null;
        GameObject e4 = null;

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

        private float distance = 4.0f;


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
            Reticle5 = GameObject.FindWithTag("Reticle5");
            Reticle6 = GameObject.FindWithTag("Reticle6");
            Reticle7 = GameObject.FindWithTag("Reticle7");
            Door_Left = GameObject.FindWithTag("Door_Left");
            Door_Right = GameObject.FindWithTag("Door_Right");
            MainCamera = GameObject.FindWithTag("MainCamera");
            Storage_Area = GameObject.FindWithTag("Storage_Area");
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
            Co10 = GameObject.FindWithTag("10");
            Co11 = GameObject.FindWithTag("11");
            Co12 = GameObject.FindWithTag("12");
            Co13a = GameObject.FindWithTag("13a");
            Co14 = GameObject.FindWithTag("14");
            Co15a = GameObject.FindWithTag("15a");
            Co16 = GameObject.FindWithTag("16");
            Co17 = GameObject.FindWithTag("17");
            Co18 = GameObject.FindWithTag("18");
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
            Avatar = GameObject.FindWithTag("Avatar");
            RoadRoller = GameObject.FindWithTag("RoadRoller");

            t1 = GameObject.FindWithTag("t1");
            t2 = GameObject.FindWithTag("t2");
            t3 = GameObject.FindWithTag("t3");
            t4 = GameObject.FindWithTag("t4");
            t5 = GameObject.FindWithTag("t5");
            t6 = GameObject.FindWithTag("t6");
            t7 = GameObject.FindWithTag("t7");
            t10 = GameObject.FindWithTag("t10");
            t11 = GameObject.FindWithTag("t11");
            t12 = GameObject.FindWithTag("t12");
            t13 = GameObject.FindWithTag("t13");
            t14 = GameObject.FindWithTag("t14");
            t15 = GameObject.FindWithTag("t15");
            t16 = GameObject.FindWithTag("t16");
            t17 = GameObject.FindWithTag("t17");
            t18 = GameObject.FindWithTag("t18");

            e1 = GameObject.FindWithTag("e1");
            e2 = GameObject.FindWithTag("e2");
            e3 = GameObject.FindWithTag("e3");
            e4 = GameObject.FindWithTag("e4");

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
            Co10.SetActive(false);
            Co11.SetActive(false);
            Co12.SetActive(false);
            Co13a.SetActive(false);
            Co14.SetActive(false);
            Co15a.SetActive(false);
            Co16.SetActive(false);
            Co17.SetActive(false);
            Co18.SetActive(false);
            Co19.SetActive(false);
            Co20.SetActive(false);
            Co21.SetActive(false);
            Co22.SetActive(false);
            Co23.SetActive(false);
            Co24.SetActive(false);
            Co25.SetActive(false);
            Co26.SetActive(false);
            Co27.SetActive(false);
            Co28.SetActive(false);
            Co29.SetActive(false);
            Co30.SetActive(false);
            Co31.SetActive(false);
            Co32.SetActive(false);
            Co33.SetActive(false);
            Co34.SetActive(false);
            Co35.SetActive(false);
            Co36.SetActive(false);
            Co37.SetActive(false);
            Co38.SetActive(false);
            Co39.SetActive(false);
            Table.SetActive(false);
            ID.SetActive(false);
            RoadRoller.SetActive(false);

            e1.SetActive(false);
            e2.SetActive(false);
            e3.SetActive(false);
            e4.SetActive(false);
            //Show objects


            //Hide objects
            Reticle.SetActive(false);
            Reticle1.SetActive(false);
            Reticle2.SetActive(false);
            Reticle3.SetActive(false);
            Reticle4.SetActive(false);
            Reticle5.SetActive(false);
            Reticle6.SetActive(false);
            Reticle7.SetActive(false);
            //Toolbox.SetActive(false);
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
                case "10":
                    audio = Sound.transform.Find("Clip10").gameObject.GetComponent<AudioSource>();
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
                case "12":
                    audio = Sound.transform.Find("Clip12").gameObject.GetComponent<AudioSource>();
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
                case "13":
                    audio = Sound.transform.Find("Clip13").gameObject.GetComponent<AudioSource>();
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
                case "15":
                    audio = Sound.transform.Find("Clip15").gameObject.GetComponent<AudioSource>();
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
                case "Heavyobject":
                    audio = Sound.transform.Find("Heavyobject").gameObject.GetComponent<AudioSource>();
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
                case "18":
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
                        Step = Step + 1;
                    };
                    break;
                case 14:
                    //play second sound file until it finishe
                    soundFileName = "Welldone";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step = Step + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 15:
                        Avatar.GetComponent<OvrAvatar>().StartWithControllers = false;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeOut = true;
                        Step = Step + 1;
                    break;
                case 16:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Stage = 2;
                        Step = Step + 1;
                    };
                    break;
                case 17:
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
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 4:
                    if (ID.GetComponent<JustForNow>().isOpen == true)
                    {
                        Step1 = Step1 + 1;
                    };
                    break;
                case 5:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 +1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 6:
                    soundFileName = "15";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 7:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 8:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 9:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 10:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 11:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 12:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 13:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 14:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 15:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 16:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 17:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 18:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 19:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 20:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 21:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 22:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 23:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
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
                case 24: //play fourth sound file until it finishes
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step1 = Step1 + 1;
                        //Debug.Log("after 2");
                    };
                    break;
                case 25:
                    break;
            }
                    
        }
            
        void Task() {

            switch (Step2)
            {
                case 1:
                    //setcameraposition		
                    System.transform.position = new Vector3(56.828f, -0.084f, 36.338f);
                    Player.transform.position = new Vector3(56.828f, 1.546f, 36.338f);
                    MainCamera.GetComponent<OVRScreenFade1>().fadeOut = false;
                    MainCamera.GetComponent<OVRScreenFade1>().fadeIn = true;
                    Co20.SetActive(true);
                    Co19.SetActive(true);
                    Co21.SetActive(true);
                    Co22.SetActive(true);
                    Co23.SetActive(true);
                    Co24.SetActive(true);
                    Co25.SetActive(true);
                    Co26.SetActive(true);
                    Co27.SetActive(true);
                    Co28.SetActive(true);
                    Co29.SetActive(true);
                    Co30.SetActive(true);
                    Co31.SetActive(true);
                    Co32.SetActive(true);
                    Co33.SetActive(true);
                    Co34.SetActive(true);
                    Co35.SetActive(true);
                    Co36.SetActive(true);
                    Co37.SetActive(true);
                    Co38.SetActive(true);
                    Co39.SetActive(true);
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
                        Storage_Area_O.GetComponent<Animator>().SetBool("Storage_Area", true);
                        Step2 = Step2 + 1;
                        e1.SetActive(true);
                        e2.SetActive(true);
                        e3.SetActive(true);
                        e4.SetActive(true);
                    };
                    break;
                case 4:
                    soundFileName = "1sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 5:
                    soundFileName = "1sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 6:
                    Reticle7.SetActive(true);
                    soundFileName = "Heavyobject";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 7:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Reticle7.SetActive(false);
                        Step2 = Step2 + 1;
                    };
                    break;
                case 8:
                    if (Co19.GetComponent<Housekeeping1>().isOn == true)
                    {
                        Step2 = Step2 + 1;
                    };
                    break;
                case 9:
                    soundFileName = "Welldone";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 10:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
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
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 13:
                    soundFileName = "5sSilence";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 14:
                    soundFileName = "17";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        MainCamera.GetComponent<OVRScreenFade1>().fadeOut = true;
                        Step2 = Step2 + 1;
                    };
                    break;
                case 15:
                    break;
            }
        }
    }
}