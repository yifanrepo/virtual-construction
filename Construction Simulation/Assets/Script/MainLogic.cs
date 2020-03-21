using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cakeslice
{
    public class MainLogic : MonoBehaviour {

		public float speed1;
		public float speed2;
		public Transform target;
        
		int Stage = 1;
        int Step = 1;
        bool Timer5Active = false;
        float TimerStart = 0.0F;
        float GazeDelay = 5.0F;
        bool Timer5Complete = false;
		bool FadeIn = false;
        bool FadeOut = false;

        RaycastHit hit;
//        bool Toolbox_Actioned = false;
        bool Worker3_Actioned = false;
		bool Intro3_Actioned = false;
        bool Intro5_Actioned = false;
		bool Intro6_Actioned = false;
		bool Intro7_Actioned = false;
		bool Intro8_Actioned = false;
//        bool Board_Wall_Actioned = false;
//        bool Arms_Wall_Actioned = false;
//        bool Cones_Pile_Actioned = false;
//        bool Barricades_Wall_Actioned = false;
//		bool Bricks_Pile_Actioned = false;

		bool Materials_Actioned = false;
		bool Worker_Actioned = false;
		bool Wheel_Barrow_Actioned = false;
		bool Safe_Route_Actioned = false;
		bool Shortcut_Actioned = false;
		bool Bricks_Pile_1_Actioned = false;
		bool Bricks_Pile_2_Actioned = false;
		bool Material_Storage_Area_Actioned = false;
		bool Yellow_Hardhat_Actioned = false;
		bool White_Hardhat_Actioned = false;
		bool Green_Hardhat_Actioned = false;
		bool Brown_Hardhat_Actioned = false;
		bool Blue_Hardhat_Actioned = false;
		bool Grey_Hardhat_Actioned = false;
		bool Grey_Hardhat_2_Actioned = false;

//		bool Bricks_Pile_2_Actioned = false;

//		GameObject Toolbox = null;
		GameObject Door = null;
//        GameObject Board_Wall = null;
//        GameObject Board_Trench = null;
//        GameObject Arms_Wall = null;
//        GameObject Arms_Attached_To_Wall_Board = null;
//        GameObject Arms_Attached_To_Trench_Board = null;
//        GameObject Cones_Pile = null;
//        GameObject Cones_Trench = null;
//        GameObject Barricades_Wall = null;
//        GameObject Barricades_Trench = null;
//        GameObject Bricks_Pile = null;
//		GameObject Rep_0 = null;
//		GameObject Rep_1 = null;
//		GameObject Rep_2 = null;
//		GameObject Rep_3 = null;
//		GameObject Rep_4 = null;
		GameObject MainCamera = null;
        GameObject Reticle = null;
//        GameObject Lid = null;
		GameObject Yellow_Hardhat = null;
		GameObject White_Hardhat = null;
		GameObject Green_Hardhat = null;
		GameObject Brown_Hardhat = null;
		GameObject Blue_Hardhat = null;
		GameObject Grey_Hardhat = null;
		GameObject Grey_Hardhat_2 = null;

		GameObject Materials = null;
		GameObject Worker = null;
		GameObject Worker3 = null;
		GameObject Wheel_Barrow = null;
		GameObject Material_Storage_Area = null;
		GameObject Wheel_Barrow_Attached_To_Camera = null;
		GameObject Worker2 = null;
		GameObject Materials_Attached_To_Camera = null;
		GameObject Bricks_Pile = null;
		GameObject Bricks_Pile_1 = null;
		GameObject Bricks_Pile_2 = null;
		GameObject Safe_Route = null;
		GameObject Shortcut = null;
		GameObject Pole_1 = null;
		GameObject Pole_2 = null;

        //FadeIn,FadeOut
        public Texture2D fadeTexture;
		[Range(0.01f,1f)]
		public float fadespeed;
		public int drawDepth = -1000;
		private float alpha = 1f;

        string soundFileName = "";
        bool audioPlaying = false;
		AudioSource audio =null;


        // Use this for initialization
        void Start() {
			//PreGame
//			Toolbox = GameObject.FindWithTag("Toolbox");
			MainCamera = GameObject.FindWithTag("MainCamera");
            Reticle = GameObject.FindWithTag("Reticle");
//            Lid = GameObject.FindWithTag("Lid");
            Door = GameObject.FindWithTag("Door");
			Yellow_Hardhat = GameObject.FindWithTag("Yellow_Hardhat");
			White_Hardhat = GameObject.FindWithTag("White_Hardhat");
			Green_Hardhat = GameObject.FindWithTag("Green_Hardhat");
			Brown_Hardhat = GameObject.FindWithTag("Brown_Hardhat");
			Blue_Hardhat = GameObject.FindWithTag("Blue_Hardhat");
			Grey_Hardhat = GameObject.FindWithTag("Grey_Hardhat");
			Grey_Hardhat_2 = GameObject.FindWithTag("Grey_Hardhat_2");
			//Task1
			Materials = GameObject.FindWithTag("Materials");
			Worker = GameObject.FindWithTag("Worker");
			Wheel_Barrow = GameObject.FindWithTag("Wheel_Barrow");
			Material_Storage_Area = GameObject.FindWithTag("Material_Storage_Area");
			Worker2 = GameObject.FindWithTag("Worker2");
			Worker3 = GameObject.FindWithTag("Worker3");
//            Board_Wall = GameObject.FindWithTag("Board_Wall");
//            Board_Trench = GameObject.FindWithTag("Board_Trench");
//            Arms_Wall = GameObject.FindWithTag("Arms_Wall");
//            Arms_Attached_To_Wall_Board = GameObject.FindWithTag("Arms_Attached_To_Wall_Board");
//            Arms_Attached_To_Trench_Board = GameObject.FindWithTag("Arms_Attached_To_Trench_Board");
//            Cones_Pile = GameObject.FindWithTag("Cones_Pile");
//            Cones_Trench = GameObject.FindWithTag("Cones_Trench");
//            Barricades_Wall = GameObject.FindWithTag("Barricades_Wall");
//            Barricades_Trench = GameObject.FindWithTag("Barricades_Trench");
//            Bricks_Pile = GameObject.FindWithTag("Bricks_Pile");
			//Task2
			Wheel_Barrow_Attached_To_Camera = GameObject.FindWithTag("Wheel_Barrow_Attached_To_Camera");
			Materials_Attached_To_Camera = GameObject.FindWithTag("Materials_Attached_To_Camera");
			Bricks_Pile = GameObject.FindWithTag("Bricks_Pile");
			Bricks_Pile_1 = GameObject.FindWithTag("Bricks_Pile_1");
			Bricks_Pile_2 = GameObject.FindWithTag("Bricks_Pile_2");
			Safe_Route = GameObject.FindWithTag("Safe_Route");
			Shortcut = GameObject.FindWithTag("Shortcut");
			Pole_1 = GameObject.FindWithTag("Pole_1");
			Pole_2 = GameObject.FindWithTag("Pole_2");

			//inReportRoom
//			Rep_0 = GameObject.FindWithTag("Rep_0");
//			Rep_1 = GameObject.FindWithTag("Rep_1");
//			Rep_2 = GameObject.FindWithTag("Rep_2");
//			Rep_3 = GameObject.FindWithTag("Rep_3");
//			Rep_4 = GameObject.FindWithTag("Rep_4");
//            
			//Show objects
			Materials.SetActive(true);
			Worker.SetActive(true);
			Worker3.SetActive(true);
			Wheel_Barrow.SetActive (true);
			Bricks_Pile.SetActive(true);
			Bricks_Pile_1.SetActive(true);
//            Board_Wall.SetActive(true);
//            Arms_Wall.SetActive(true);
//            Cones_Pile.SetActive(true);
//            Barricades_Wall.SetActive(true);
            
            
			//Hide objects
//			Toolbox.SetActive(false);
			Door.SetActive (true);
			Yellow_Hardhat.SetActive(false);
			White_Hardhat.SetActive(false);
			Green_Hardhat.SetActive(false);
			Brown_Hardhat.SetActive(false);
			Blue_Hardhat.SetActive(false);
			Grey_Hardhat.SetActive(true);
			Grey_Hardhat_2.SetActive(false);
			Material_Storage_Area.SetActive (false);
			Wheel_Barrow_Attached_To_Camera.SetActive (false);
			Materials_Attached_To_Camera.SetActive (false);
			Worker2.SetActive (false);
			Bricks_Pile_2.SetActive (false);
			Safe_Route.SetActive (false);
			Shortcut.SetActive (false);
			Pole_1.SetActive (false);
			Pole_2.SetActive (false);
//            Board_Trench.SetActive(false);
//            Arms_Attached_To_Wall_Board.SetActive(false);
//            Arms_Attached_To_Trench_Board.SetActive(false);
//            Cones_Trench.SetActive(false);
//            Barricades_Trench.SetActive(false);
//			Rep_0.SetActive(false);
//			Rep_1.SetActive(false);
//			Rep_2.SetActive(false);
//			Rep_3.SetActive(false);
//			Rep_4.SetActive(false);
        }

		void Update()
        {
            switch (Stage)
            {
                case 1:
                    PreGame();
                    break;
                case 2:
                    Task1();
                    break;
			    case 3:
				    Task2();
				    break;
			    case 4:
				    Task3();
				    break;
			    case 5:
				    Task4();
				    break;
                case 6:
                    AchievementSystem();
                    break;
            }
        }

        void showReticle(bool isVisible)
        {
            //if isVisible = true then
            //  show the reticle
            //else
            //  hide the reticle
            Reticle.SetActive(isVisible);
        }

        bool PlaySound(string soundFileName)
        {
            switch (soundFileName)
            {
                case "1":
                    audio = MainCamera.transform.Find("Clip1").gameObject.GetComponent<AudioSource>();
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
                    audio = MainCamera.transform.Find("Clip2").gameObject.GetComponent<AudioSource>();
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
				    audio = MainCamera.transform.Find("Clip3").gameObject.GetComponent<AudioSource>();
				    //if the sound has finished playing return true
				    if (audioPlaying && !audio.isPlaying)
				    {
                        audio.Stop();
                        audioPlaying = false;
					    Intro3_Actioned = true;
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
                    audio = MainCamera.transform.Find("Clip4").gameObject.GetComponent<AudioSource>();
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
				    audio = MainCamera.transform.Find("Clip5").gameObject.GetComponent<AudioSource>();
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
				audio = MainCamera.transform.Find("Clip6").gameObject.GetComponent<AudioSource>();
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
				audio = MainCamera.transform.Find("Clip7").gameObject.GetComponent<AudioSource>();
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
				audio = MainCamera.transform.Find("Clip8").gameObject.GetComponent<AudioSource>();
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
                    audio = MainCamera.transform.Find("ClipSilence").gameObject.GetComponent<AudioSource>();
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
                case "9":
				    break;
                }
            return false;
        }

		void PreGame() {

            switch(Step)
            {
                case 1:
                    //setcameraposition		
				if (transform.position != new Vector3(93.52f, 3, 50.81f))
                    {
					transform.position = new Vector3(93.52f, 3, 50.81f);
//					transform.Rotate(0, 270, 0);

                        FadeIn = true;
                    }
                    //make the reticle invisible
                    showReticle(false);
                    //play first sound file until it finishes
                    soundFileName = "1";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Step += step;
                        Step = Step +1;
                    };
                    break;
                case 2: //make the reticle visible
				    //Debug.Log("case2");
				    showReticle(true);
                    //play second sound file until it finishes
                    soundFileName = "2";
                    if (PlaySound(soundFileName) == true)
                    {
					//Debug.Log("2");
                        Step = Step + 1;
					//Debug.Log("after 2");
                    };
                    break;
                case 3: 
                    //play third sound file until it finishes
                    soundFileName = "3";
                    if (PlaySound(soundFileName) == true)
                    {
                        //Debug.Log("2");
                        Step = Step + 1;
                        //Debug.Log("after 2");
                    };
                    break;
			case 4:
                    //make the toolbox visible, play the sound file attached to the toolbox, and close the toolbox lid
                    //Debug.Log("case3");
//                    Toolbox.SetActive(true);
//				    Grey_Hardhat.SetActive (true);
				    if (Grey_Hardhat_Actioned) {
					    float step1 = speed1 * Time.deltaTime;
					    float step2 = speed2 * Time.deltaTime;
					    Grey_Hardhat.transform.position = Vector3.MoveTowards (Grey_Hardhat.transform.position, target.position, step1);
					    Grey_Hardhat.transform.rotation = Quaternion.RotateTowards (Grey_Hardhat.transform.rotation, target.rotation, step2);
				    }
                    //play fourth sound file until it finishes
//                    if (Lid.GetComponent<Animator>().GetBool("Toolbox Trigger") == true)
//                    {
//                        Step = Step + 1;
//                    }
				if (Grey_Hardhat.transform.position == new Vector3(85.27f, 2.56f, 58.82f) && Grey_Hardhat.transform.rotation == Quaternion.Euler(79.07f, 180, 0))
				    {
					    Step = Step + 1;
				    }
                    break;
                case 5: //play fourth sound file until it finishes
                    soundFileName = "4";
                    if (PlaySound(soundFileName) == true)
                    {
					//make the door visible, play the sound file attached to the toolbox, and close the toolbox lid
					    Yellow_Hardhat.SetActive(true);
					    White_Hardhat.SetActive(true);
					    Green_Hardhat.SetActive(true);
					    Brown_Hardhat.SetActive(true);
					    Blue_Hardhat.SetActive(true);
					    Grey_Hardhat.SetActive(false);
					    Grey_Hardhat_2.SetActive(true);
                        Step = Step + 1;
                    };
                    break;
			
			case 6: //play fourth sound file until it finishes
				if (Yellow_Hardhat_Actioned)
				{
					//make the door visible, play the sound file attached to the toolbox, and close the toolbox lid
					Step = Step + 1;
				};
				break;
			
			case 7: //play fourth sound file until it finishes
				soundFileName = "8";
				if (PlaySound(soundFileName) == true)
				{
					//Debug.Log("2");
					Step = Step + 1;
					//Debug.Log("after 2");
				};
				break;

			    case 8:
                    if (Worker3_Actioned)
                    {
                        Debug.Log("About to play 5s of silence");
                        soundFileName = "5sSilence";
                        if (PlaySound(soundFileName) == true)
                        {
                            Step = Step + 1;
                            alpha = 1;
                            FadeIn = true;
                            Debug.Log("Have set fade in to true");
                            Stage = 2;
                        };
                    }
                    break;
                case 9:
				    break;
                case 10:
                    break;
            }


			if (Physics.Raycast(transform.position, transform.forward, out hit))
            { 
                GameObject hitObject = hit.collider.gameObject;
                if (hitObject.transform.parent != null)
                {
                    hitObject = hitObject.transform.parent.gameObject;
                }


                //Debug.Log(hitObject.GetComponent<Toggle>());
                        
                //Debug.Log(hitObject.GetComponentsInChildren<Toggle>().Length);

                if ((hitObject.GetComponent<Toggle>() == null) && (hitObject.GetComponentsInChildren<Toggle>().Length == 0))
                {
                    TurnOffAllOutlines();
                    TurnOffAllSounds();
                    return;
                }
//
//                if((hitObject.tag == "Toolbox") && (Toolbox_Actioned))
//                {
//                    TurnOffAllOutlines();
//                    TurnOffAllSounds();
//                    return;
//                }

				if((hitObject.tag == "Grey_Hardhat") && (Intro3_Actioned==false))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if((hitObject.tag == "Grey_Hardhat") && (Grey_Hardhat_Actioned))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if ((hitObject.tag == "Worker3") && (Worker3_Actioned))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if ((hitObject.tag == "Worker3") && (Intro8_Actioned==false))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if (hitObject.tag == "Materials")
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if (hitObject.tag == "Worker")
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if (hitObject.tag == "Wheel_Barrow")
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if((hitObject.tag == "Grey_Hardhat_2") && (Yellow_Hardhat_Actioned))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if((hitObject.tag == "Blue_Hardhat") && (Yellow_Hardhat_Actioned))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if((hitObject.tag == "Brown_Hardhat") && (Yellow_Hardhat_Actioned))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if((hitObject.tag == "Green_Hardhat") && (Yellow_Hardhat_Actioned))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if((hitObject.tag == "White_Hardhat") && (Yellow_Hardhat_Actioned))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}
                //Debug.Log("3");

                //if object is not outlined
                //  turn off all outlines
                //  turn off all sound files
                //  turn on outline
                //  start sound file

                //Debug.Log("4");
                if (hitObject.GetComponent<Toggle>() != null)
                {
                    if (hitObject.GetComponent<Toggle>().isViewed == false)
                    {
                        TurnOffAllOutlines();
                        TurnOffAllSounds();
                        TurnOnOutlines(hitObject);
                        TurnOnSound(hitObject);
                        //Debug.Log("5");
                        return;
                    }
                }

                if (hitObject.GetComponentsInChildren<Toggle>().Length != 0)
                {
                    if (hitObject.GetComponentsInChildren<Toggle>()[0].isViewed == false)
                    {
                        TurnOffAllOutlines();
                        TurnOffAllSounds();
                        TurnOnOutlines(hitObject);
                        TurnOnSound(hitObject);
                        //Debug.Log("6");
                        return;
                    }
                }

                //Debug.Log("7");

                if (hitObject.GetComponent<ToggleSound>().soundFinished == true)
                {
                    //Debug.Log("10");
                    if (Timer5Active)
                    {
                        //Debug.Log("11");
                        if ((Time.time - GazeDelay) > TimerStart)
                        {
                            //Debug.Log("12");
                            Timer5Complete = true;
                        }
                        //Debug.Log("13");
                        if (Timer5Complete)
                        {
                            //Debug.Log("14");
                            TurnOffAllOutlines();
                            PerformAction(hitObject.tag);
                            Timer5Active = false;
                            Timer5Complete = false;
                        }
                        //Debug.Log("15");
                    }
                    else
                    {
                        //Debug.Log("16");
                        Timer5Active = true;
                        TimerStart = Time.time;
                    }
                }


            }
            else
            { //user not look at object
                //turn off all outlines an sound files, turn off 5s timer
                TurnOffAllOutlines();
                TurnOffAllSounds();
                Timer5Active = false;
                Timer5Complete = false;
            }
                    
        }
            
        void Task1() {
			Material_Storage_Area.SetActive(true);
			Worker2.SetActive (true);
			if (Wheel_Barrow_Actioned)
			{
				Debug.Log("About to play 5s of silence");
				soundFileName = "5sSilence";
				if (PlaySound(soundFileName) == true)
				{
					alpha = 1;
					FadeIn = true;
					Debug.Log("Have set fade in to true");
					Stage = 3;
				};
			}

			if (Materials_Actioned)
			{
				Debug.Log("About to play 5s of silence");
				soundFileName = "5sSilence";
				if (PlaySound(soundFileName) == true)
				{
					alpha = 1;
					FadeIn = true;
					Debug.Log("Have set fade in to true");
					Stage = 3;
					//					Materials.SetActive(true);
					//					Materials_Actioned = false;
				};
			}

			if (transform.position != new Vector3 (83.05f, 3, 39.22f)) {
				transform.position = new Vector3 (83.05f, 3, 39.22f);
//				transform.Rotate(0, 270, 0);
				soundFileName = "5";
                Debug.Log("position wasnt exact");
			}

            if (!Intro5_Actioned)
            {
                if (PlaySound(soundFileName) != true)
                {
                    return;
                }
            }

//			if (Bricks_Pile_Actioned)
//			{
//				Debug.Log("About to play 5s of silence");
//				soundFileName = "5sSilence";
//				if (PlaySound(soundFileName) == true)
//				{
//					alpha = 1;
//					FadeIn = true;
//					Debug.Log("Have set fade in to true");
//					Stage = 3;
//					Bricks_Pile.SetActive(true);
//					Bricks_Pile_Actioned = false;
//				};
//			}

			if (Physics.Raycast(transform.position, transform.forward, out hit))
            { //user looks at object
              //if object has been actioned
              //turn off all outlines
              //turn off all sound files
                Debug.Log("1");

                GameObject hitObject = hit.collider.gameObject;
                if (hitObject.transform.parent != null)
                {
                    hitObject = hitObject.transform.parent.gameObject;
                }

                ////Debug.Log("2");
                //Debug.Log (hitObject.GetComponent<Toggle> ());
                ////Debug.Log("2.1");
                //Debug.Log (hitObject.GetComponentsInChildren<Toggle> ().Length);
                ////Debug.Log("2.2");
                if ((hitObject.GetComponent<Toggle>() == null) && (hitObject.GetComponentsInChildren<Toggle>().Length == 0))
                {
                    TurnOffAllOutlines();
                    TurnOffAllSounds();
                    return;
                }


				if((hitObject.tag == "Worker") && (Worker_Actioned))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if((hitObject.tag == "Worker") && (Materials_Actioned))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if((hitObject.tag == "Wheel_Barrow") && (Materials_Actioned))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if((hitObject.tag == "Wheel_Barrow") && (Worker_Actioned == false))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if (hitObject.tag == "Material_Storage_Area")
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

                //Debug.Log ("3");


                //if object is not outlined
                //  turn off all outlines
                //  turn off all sound files
                //  turn on outline
                //  start sound file

                //Debug.Log ("4");
                if (hitObject.GetComponent<Toggle>() != null)
                {
                    if (hitObject.GetComponent<Toggle>().isViewed == false)
                    {
                        TurnOffAllOutlines();
                        TurnOffAllSounds();
                        TurnOnOutlines(hitObject);
                        TurnOnSound(hitObject);
                        //Debug.Log ("5");
                        return;
                    }
                }
					
                if (hitObject.GetComponentsInChildren<Toggle>().Length != 0)
                {
                    if (hitObject.GetComponentsInChildren<Toggle>()[0].isViewed == false)
                    {
                        TurnOffAllOutlines();
                        TurnOffAllSounds();
                        TurnOnOutlines(hitObject);
                        TurnOnSound(hitObject);
                        //Debug.Log ("6");
                        return;
                    }
                }

                //Debug.Log ("7");

                if (hitObject.GetComponent<ToggleSound>().soundFinished == true)
                {
                    //Debug.Log ("10");
                    if (Timer5Active)
                    {
                        //Debug.Log ("11");
                        if ((Time.time - GazeDelay) > TimerStart)
                        {
                            //Debug.Log ("12");
                            Timer5Complete = true;
                        }
                        //Debug.Log ("13");
                        if (Timer5Complete)
                        {
                            //Debug.Log ("14");
                            TurnOffAllOutlines();
                            PerformAction(hitObject.tag);
                            Timer5Active = false;
                            Timer5Complete = false;
                        }
                        //Debug.Log ("15");
                    }
                    else
                    {
                        //Debug.Log ("16");
                        Timer5Active = true;
                        TimerStart = Time.time;
                    }
                }


            }
            else
            { //user not look at object
              //turn off all outlines an sound files, turn off 5s timer
                TurnOffAllOutlines();
                TurnOffAllSounds();
                Timer5Active = false;
                Timer5Complete = false;
            }

        }

		void Task2() {
			Worker2.SetActive (false);
			Bricks_Pile.SetActive(false);
			Bricks_Pile_2.SetActive (true);
			Safe_Route.SetActive (true);
			Shortcut.SetActive (true);
			Pole_1.SetActive (true);
			Pole_2.SetActive (true);

			if (Wheel_Barrow_Actioned) {
				Wheel_Barrow_Attached_To_Camera.SetActive (true);
				Wheel_Barrow_Attached_To_Camera.transform.position = new Vector3 (70.57f, 1.2f, 39);
			}

			if (Materials_Actioned) {
				Materials_Attached_To_Camera.SetActive (true);
				Materials_Attached_To_Camera.transform.position = new Vector3 (72.97f, 2.6f, 39);
			}


			if (transform.position != new Vector3 (73.33f, 3, 39)) {
				transform.position = new Vector3 (73.33f, 3, 39);
				soundFileName = "6";
				Debug.Log("position wasnt exact");
			}

			if (!Intro6_Actioned)
			{
				if (PlaySound(soundFileName) != true)
				{
					return;
				}
			}
				
			if (Safe_Route_Actioned)
			{
				Debug.Log("About to play 5s of silence");
				soundFileName = "5sSilence";
				if (PlaySound(soundFileName) == true)
				{
					alpha = 1;
					FadeIn = true;
					Debug.Log("Have set fade in to true");
					Stage = 4;
				};
			}

			if (Shortcut_Actioned)
			{
				Debug.Log("About to play 5s of silence");
				soundFileName = "5sSilence";
				if (PlaySound(soundFileName) == true)
				{
					alpha = 1;
					FadeIn = true;
					Debug.Log("Have set fade in to true");
					Stage = 5;
				};
			}

			if (Physics.Raycast(transform.position, transform.forward, out hit))
			{ //user looks at object
				//if object has been actioned
				//turn off all outlines
				//turn off all sound files
				Debug.Log("1");

				GameObject hitObject = hit.collider.gameObject;
				if (hitObject.transform.parent != null)
				{
					hitObject = hitObject.transform.parent.gameObject;
				}

				////Debug.Log("2");
				//Debug.Log (hitObject.GetComponent<Toggle> ());
				////Debug.Log("2.1");
				//Debug.Log (hitObject.GetComponentsInChildren<Toggle> ().Length);
				////Debug.Log("2.2");
				if ((hitObject.GetComponent<Toggle>() == null) && (hitObject.GetComponentsInChildren<Toggle>().Length == 0))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if(hitObject.tag == "Worker") 
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if(hitObject.tag == "Wheel_Barrow")
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if (hitObject.tag == "Material_Storage_Area")
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if (hitObject.tag == "Bricks_Pile_2")
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if((hitObject.tag == "Safe_Route") && (Safe_Route_Actioned))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if((hitObject.tag == "Shortcut") && (Shortcut_Actioned))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				//Debug.Log ("3");


				//if object is not outlined
				//  turn off all outlines
				//  turn off all sound files
				//  turn on outline
				//  start sound file

				//Debug.Log ("4");
				if (hitObject.GetComponent<Toggle>() != null)
				{
					if (hitObject.GetComponent<Toggle>().isViewed == false)
					{
						TurnOffAllOutlines();
						TurnOffAllSounds();
						TurnOnOutlines(hitObject);
						TurnOnSound(hitObject);
						//Debug.Log ("5");
						return;
					}
				}

				if (hitObject.GetComponentsInChildren<Toggle>().Length != 0)
				{
					if (hitObject.GetComponentsInChildren<Toggle>()[0].isViewed == false)
					{
						TurnOffAllOutlines();
						TurnOffAllSounds();
						TurnOnOutlines(hitObject);
						TurnOnSound(hitObject);
						//Debug.Log ("6");
						return;
					}
				}

				//Debug.Log ("7");


				if (hitObject.GetComponent<ToggleSound>().soundFinished == true)
				{
					//Debug.Log ("10");
					if (Timer5Active)
					{
						//Debug.Log ("11");
						if ((Time.time - GazeDelay) > TimerStart)
						{
							//Debug.Log ("12");
							Timer5Complete = true;
						}
						//Debug.Log ("13");
						if (Timer5Complete)
						{
							//Debug.Log ("14");
							TurnOffAllOutlines();
							PerformAction(hitObject.tag);
							Timer5Active = false;
							Timer5Complete = false;
						}
						//Debug.Log ("15");
					}
					else
					{
						//Debug.Log ("16");
						Timer5Active = true;
						TimerStart = Time.time;
					}
				}


			}
			else
			{ //user not look at object
				//turn off all outlines an sound files, turn off 5s timer
				TurnOffAllOutlines();
				TurnOffAllSounds();
				Timer5Active = false;
				Timer5Complete = false;
			}

		}

		void Task3() {
			
			if (Wheel_Barrow_Actioned) {
				Wheel_Barrow_Attached_To_Camera.transform.position = new Vector3 (63.53f, 1.2f, 46.23f);
			}

			if (Materials_Actioned) {
				Materials_Attached_To_Camera.transform.position = new Vector3 (65.93f, 2.6f, 46.23f);
			}

			if (transform.position != new Vector3 (66.29f, 3, 46.23f)) {
				transform.position = new Vector3 (66.29f, 3, 46.23f);
				soundFileName = "7";
				Debug.Log("position wasnt exact");
			}

			if (!Intro7_Actioned)
			{
				if (PlaySound(soundFileName) != true)
				{
					return;
				}
			}

			Material_Storage_Area.GetComponent<Animator> ().SetBool ("Material_Storage_Area_Trigger", true);

//			if (Bricks_Pile_1_Actioned)
//			{
//				Debug.Log("About to play 5s of silence");
//				soundFileName = "5sSilence";
//				if (PlaySound(soundFileName) == true)
//				{
//					alpha = 1;
//					FadeIn = true;
//					Debug.Log("Have set fade in to true");
//					Stage = 6;
//				};
//			}

			if (Material_Storage_Area_Actioned)
			{
				Debug.Log("About to play 5s of silence");
				soundFileName = "5sSilence";
				if (PlaySound(soundFileName) == true)
				{
					alpha = 1;
					FadeIn = true;
					Debug.Log("Have set fade in to true");
					Stage = 6;
				};
			}

			if (Physics.Raycast(transform.position, transform.forward, out hit))
			{ //user looks at object
				//if object has been actioned
				//turn off all outlines
				//turn off all sound files
				Debug.Log("1");

				GameObject hitObject = hit.collider.gameObject;
				if (hitObject.transform.parent != null)
				{
					hitObject = hitObject.transform.parent.gameObject;
				}

				////Debug.Log("2");
				//Debug.Log (hitObject.GetComponent<Toggle> ());
				////Debug.Log("2.1");
				//Debug.Log (hitObject.GetComponentsInChildren<Toggle> ().Length);
				////Debug.Log("2.2");
				if ((hitObject.GetComponent<Toggle>() == null) && (hitObject.GetComponentsInChildren<Toggle>().Length == 0))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if(hitObject.tag == "Worker") 
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if(hitObject.tag == "Wheel_Barrow")
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if (hitObject.tag == "Safe_Route")
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if (hitObject.tag == "Shortcut")
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if (hitObject.tag == "Bricks_Pile_2")
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				//Debug.Log ("3");


				//if object is not outlined
				//  turn off all outlines
				//  turn off all sound files
				//  turn on outline
				//  start sound file

				//Debug.Log ("4");
				if (hitObject.GetComponent<Toggle>() != null)
				{
					if (hitObject.GetComponent<Toggle>().isViewed == false)
					{
						TurnOffAllOutlines();
						TurnOffAllSounds();
						TurnOnOutlines(hitObject);
						TurnOnSound(hitObject);
						//Debug.Log ("5");
						return;
					}
				}

				if (hitObject.GetComponentsInChildren<Toggle>().Length != 0)
				{
					if (hitObject.GetComponentsInChildren<Toggle>()[0].isViewed == false)
					{
						TurnOffAllOutlines();
						TurnOffAllSounds();
						TurnOnOutlines(hitObject);
						TurnOnSound(hitObject);
						//Debug.Log ("6");
						return;
					}
				}

				//Debug.Log ("7");


				if (hitObject.GetComponent<ToggleSound>().soundFinished == true)
				{
					//Debug.Log ("10");
					if (Timer5Active)
					{
						//Debug.Log ("11");
						if ((Time.time - GazeDelay) > TimerStart)
						{
							//Debug.Log ("12");
							Timer5Complete = true;
						}
						//Debug.Log ("13");
						if (Timer5Complete)
						{
							//Debug.Log ("14");
							TurnOffAllOutlines();
							PerformAction(hitObject.tag);
							Timer5Active = false;
							Timer5Complete = false;
						}
						//Debug.Log ("15");
					}
					else
					{
						//Debug.Log ("16");
						Timer5Active = true;
						TimerStart = Time.time;
					}
				}


			}
			else
			{ //user not look at object
				//turn off all outlines an sound files, turn off 5s timer
				TurnOffAllOutlines();
				TurnOffAllSounds();
				Timer5Active = false;
				Timer5Complete = false;
			}

		}
		void Task4() {

			if (Wheel_Barrow_Actioned) {
				Wheel_Barrow_Attached_To_Camera.transform.position = new Vector3 (60.95f, 1.2f, 40.11f);
			}

			if (Materials_Actioned) {
				Materials_Attached_To_Camera.transform.position = new Vector3 (63.35f, 2.6f, 40.11f);
			}

			if (transform.position != new Vector3 (63.71f, 3, 40.11f)) {
				transform.position = new Vector3 (63.71f, 3, 40.11f);
				soundFileName = "7";
				Debug.Log("position wasnt exact");
			}

			if (!Intro7_Actioned)
			{
				if (PlaySound(soundFileName) != true)
				{
					return;
				}
			}

			Material_Storage_Area.GetComponent<Animator> ().SetBool ("Material_Storage_Area_Trigger", true);

			if (Material_Storage_Area_Actioned)
			{
				Debug.Log("About to play 5s of silence");
				soundFileName = "5sSilence";
				if (PlaySound(soundFileName) == true)
				{
					alpha = 1;
					FadeIn = true;
					Debug.Log("Have set fade in to true");
					Stage = 6;
				};
			}

			if (Physics.Raycast(transform.position, transform.forward, out hit))
			{ //user looks at object
				//if object has been actioned
				//turn off all outlines
				//turn off all sound files
				Debug.Log("1");

				GameObject hitObject = hit.collider.gameObject;
				if (hitObject.transform.parent != null)
				{
					hitObject = hitObject.transform.parent.gameObject;
				}

				////Debug.Log("2");
				//Debug.Log (hitObject.GetComponent<Toggle> ());
				////Debug.Log("2.1");
				//Debug.Log (hitObject.GetComponentsInChildren<Toggle> ().Length);
				////Debug.Log("2.2");
				if ((hitObject.GetComponent<Toggle>() == null) && (hitObject.GetComponentsInChildren<Toggle>().Length == 0))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if(hitObject.tag == "Worker") 
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if(hitObject.tag == "Wheel_Barrow")
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if (hitObject.tag == "Safe_Route")
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if (hitObject.tag == "Shortcut")
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if (hitObject.tag == "Bricks_Pile_1")
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				if ((hitObject.tag == "Material_Storage_Area") && (Material_Storage_Area_Actioned))
				{
					TurnOffAllOutlines();
					TurnOffAllSounds();
					return;
				}

				//Debug.Log ("3");


				//if object is not outlined
				//  turn off all outlines
				//  turn off all sound files
				//  turn on outline
				//  start sound file

				//Debug.Log ("4");
				if (hitObject.GetComponent<Toggle>() != null)
				{
					if (hitObject.GetComponent<Toggle>().isViewed == false)
					{
						TurnOffAllOutlines();
						TurnOffAllSounds();
						TurnOnOutlines(hitObject);
						TurnOnSound(hitObject);
						//Debug.Log ("5");
						return;
					}
				}

				if (hitObject.GetComponentsInChildren<Toggle>().Length != 0)
				{
					if (hitObject.GetComponentsInChildren<Toggle>()[0].isViewed == false)
					{
						TurnOffAllOutlines();
						TurnOffAllSounds();
						TurnOnOutlines(hitObject);
						TurnOnSound(hitObject);
						//Debug.Log ("6");
						return;
					}
				}

				//Debug.Log ("7");


				if (hitObject.GetComponent<ToggleSound>().soundFinished == true)
				{
					//Debug.Log ("10");
					if (Timer5Active)
					{
						//Debug.Log ("11");
						if ((Time.time - GazeDelay) > TimerStart)
						{
							//Debug.Log ("12");
							Timer5Complete = true;
						}
						//Debug.Log ("13");
						if (Timer5Complete)
						{
							//Debug.Log ("14");
							TurnOffAllOutlines();
							PerformAction(hitObject.tag);
							Timer5Active = false;
							Timer5Complete = false;
						}
						//Debug.Log ("15");
					}
					else
					{
						//Debug.Log ("16");
						Timer5Active = true;
						TimerStart = Time.time;
					}
				}


			}
			else
			{ //user not look at object
				//turn off all outlines an sound files, turn off 5s timer
				TurnOffAllOutlines();
				TurnOffAllSounds();
				Timer5Active = false;
				Timer5Complete = false;
			}

		}
		void AchievementSystem()
		{

			if (transform.position != new Vector3(51.76f, 3, 27.57f))
			{
				transform.position = new Vector3(51.76f, 3, 27.57f);
				transform.rotation = Quaternion.Euler(0, 90, 0);

			}

//			finalReport ();
		}

        void TurnOnOutlines(GameObject hitObject)
        {
            if (hitObject.transform.childCount > 0)
            {
                foreach (Toggle t in hitObject.GetComponentsInChildren<Toggle>())
                {
                    if (t.isViewed == false)
                        t.isViewed = true;
                }
            }
            else
            {
                hitObject.GetComponent<Toggle>().isViewed = true;
            }
        }

        void TurnOffAllOutlines()
        {
//			if (Toolbox.activeInHierarchy)
//			{
//				foreach (Toggle t in Toolbox.GetComponentsInChildren<Toggle>())
//				{
//					if (t.isViewed == true)
//						t.isViewed = false;
//				}
//			}
			if (Shortcut.activeInHierarchy) Shortcut.GetComponent<Toggle>().isViewed = false;
			if (Safe_Route.activeInHierarchy) Safe_Route.GetComponent<Toggle>().isViewed = false;
			if (Material_Storage_Area.activeInHierarchy) Material_Storage_Area.GetComponent<Toggle>().isViewed = false;
//			if (Board_Wall.activeInHierarchy) Board_Wall.GetComponent<Toggle>().isViewed = false;
//            if (Arms_Wall.activeInHierarchy)
//            {
//                foreach (Toggle t in Arms_Wall.GetComponentsInChildren<Toggle>())
//                {
//                    if (t.isViewed == true)
//                        t.isViewed = false;
//                }
//            }
//            if (Cones_Pile.activeInHierarchy)
//            {
//                foreach (Toggle t in Cones_Pile.GetComponentsInChildren<Toggle>())
//                {
//                    if (t.isViewed == true)
//                        t.isViewed = false;
//                }
//            }
//            if (Barricades_Wall.activeInHierarchy)
//            {
//                foreach (Toggle t in Barricades_Wall.GetComponentsInChildren<Toggle>())
//                {
//                    if (t.isViewed == true)
//                        t.isViewed = false;
//                }
//            }
//            if (Bricks_Pile.activeInHierarchy)
//            {
//                foreach (Toggle t in Bricks_Pile.GetComponentsInChildren<Toggle>())
//                {
//                    if (t.isViewed == true)
//                        t.isViewed = false;
//                }
//            }

			if (Materials.activeInHierarchy)
			{
				foreach (Toggle t in Materials.GetComponentsInChildren<Toggle>())
				{
					if (t.isViewed == true)
						t.isViewed = false;
				}
			}
			if (Wheel_Barrow.activeInHierarchy)
			{
				foreach (Toggle t in Wheel_Barrow.GetComponentsInChildren<Toggle>())
				{
					if (t.isViewed == true)
						t.isViewed = false;
				}
			}
			if (Worker.activeInHierarchy)
			{
				foreach (Toggle t in Worker.GetComponentsInChildren<Toggle>())
				{
					if (t.isViewed == true)
						t.isViewed = false;
				}
			}
			if (Bricks_Pile_1.activeInHierarchy)
			{
				foreach (Toggle t in Bricks_Pile_1.GetComponentsInChildren<Toggle>())
				{
					if (t.isViewed == true)
						t.isViewed = false;
				}
			}
			if (Bricks_Pile_2.activeInHierarchy)
			{
				foreach (Toggle t in Bricks_Pile_2.GetComponentsInChildren<Toggle>())
				{
					if (t.isViewed == true)
						t.isViewed = false;
				}
			}
			if (Yellow_Hardhat.activeInHierarchy)
			{
				foreach (Toggle t in Yellow_Hardhat.GetComponentsInChildren<Toggle>())
				{
					if (t.isViewed == true)
						t.isViewed = false;
				}
			}
			if (White_Hardhat.activeInHierarchy)
			{
				foreach (Toggle t in White_Hardhat.GetComponentsInChildren<Toggle>())
				{
					if (t.isViewed == true)
						t.isViewed = false;
				}
			}
			if (Green_Hardhat.activeInHierarchy)
			{
				foreach (Toggle t in Green_Hardhat.GetComponentsInChildren<Toggle>())
				{
					if (t.isViewed == true)
						t.isViewed = false;
				}
			}
			if (Brown_Hardhat.activeInHierarchy)
			{
				foreach (Toggle t in Brown_Hardhat.GetComponentsInChildren<Toggle>())
				{
					if (t.isViewed == true)
						t.isViewed = false;
				}
			}
			if (Blue_Hardhat.activeInHierarchy)
			{
				foreach (Toggle t in Blue_Hardhat.GetComponentsInChildren<Toggle>())
				{
					if (t.isViewed == true)
						t.isViewed = false;
				}
			}
			if (Grey_Hardhat.activeInHierarchy)
			{
				foreach (Toggle t in Grey_Hardhat.GetComponentsInChildren<Toggle>())
				{
					if (t.isViewed == true)
						t.isViewed = false;
				}
			}
			if (Grey_Hardhat_2.activeInHierarchy)
			{
				foreach (Toggle t in Grey_Hardhat_2.GetComponentsInChildren<Toggle>())
				{
					if (t.isViewed == true)
						t.isViewed = false;
				}
			}
			if (Door.activeInHierarchy)
			{
				foreach (Toggle t in Door.GetComponentsInChildren<Toggle>())
				{
					if (t.isViewed == true)
						t.isViewed = false;
				}
			}
        }

        void TurnOffAllSounds()
        {
			if (Grey_Hardhat.activeInHierarchy) Grey_Hardhat.GetComponent<ToggleSound>().playNow = false;
			if (Yellow_Hardhat.activeInHierarchy) Yellow_Hardhat.GetComponent<ToggleSound>().playNow = false;
			if (White_Hardhat.activeInHierarchy) White_Hardhat.GetComponent<ToggleSound>().playNow = false;
			if (Green_Hardhat.activeInHierarchy) Green_Hardhat.GetComponent<ToggleSound>().playNow = false;
			if (Brown_Hardhat.activeInHierarchy) Brown_Hardhat.GetComponent<ToggleSound>().playNow = false;
			if (Blue_Hardhat.activeInHierarchy) Blue_Hardhat.GetComponent<ToggleSound>().playNow = false;
			if (Grey_Hardhat_2.activeInHierarchy) Grey_Hardhat_2.GetComponent<ToggleSound>().playNow = false;
			if (Worker3.activeInHierarchy) Worker3.GetComponent<ToggleSound>().playNow = false;
//            if (Board_Wall.activeInHierarchy) Board_Wall.GetComponent<ToggleSound>().playNow = false;
//            if (Arms_Wall.activeInHierarchy) Arms_Wall.GetComponent<ToggleSound>().playNow = false;
//            if (Cones_Pile.activeInHierarchy) Cones_Pile.GetComponent<ToggleSound>().playNow = false;
//            if (Barricades_Wall.activeInHierarchy) Barricades_Wall.GetComponent<ToggleSound>().playNow = false;
//            if (Bricks_Pile.activeInHierarchy) Bricks_Pile.GetComponent<ToggleSound>().playNow = false;
			if (Materials.activeInHierarchy) Materials.GetComponent<ToggleSound>().playNow = false;
			if (Worker.activeInHierarchy) Worker.GetComponent<ToggleSound>().playNow = false;
			if (Wheel_Barrow.activeInHierarchy) Wheel_Barrow.GetComponent<ToggleSound>().playNow = false;
			if (Safe_Route.activeInHierarchy) Safe_Route.GetComponent<ToggleSound>().playNow = false;
			if (Shortcut.activeInHierarchy) Shortcut.GetComponent<ToggleSound>().playNow = false;
			if (Bricks_Pile_1.activeInHierarchy) Bricks_Pile_1.GetComponent<ToggleSound>().playNow = false;
			if (Bricks_Pile_2.activeInHierarchy) Bricks_Pile_2.GetComponent<ToggleSound>().playNow = false;
			if (Material_Storage_Area.activeInHierarchy) Material_Storage_Area.GetComponent<ToggleSound>().playNow = false;
//			if (Bricks_Pile_2.activeInHierarchy) Bricks_Pile_2.GetComponent<ToggleSound>().playNow = false;
        }

        void TurnOnSound(GameObject hitObject)
        {
            hitObject.GetComponent<ToggleSound>().playNow = true;
        }

//		void finalReport()
//		{
//			if (!Board_Trench.activeInHierarchy) {
//				Rep_0.SetActive (true);
//				Rep_1.SetActive (false);
//				StartCoroutine (StartWait ());
//
//			}
//			if (Board_Trench.activeInHierarchy) {
//				Rep_1.SetActive (true);
//				Rep_0.SetActive (false);
//			}
//			if (Board_Trench.activeInHierarchy && (Cones_Trench.activeInHierarchy||Barricades_Trench.activeInHierarchy)) {
//				Rep_2.SetActive (true);
//				Rep_1.SetActive (false);
//				Rep_0.SetActive (false);
//			}
//			if (Board_Trench.activeInHierarchy && Arms_Attached_To_Trench_Board.activeInHierarchy) {
//				Rep_3.SetActive (true);	
//				Rep_2.SetActive (false);
//				Rep_1.SetActive (false);
//				Rep_0.SetActive (false);
//			}
//			if (Board_Trench.activeInHierarchy && Arms_Attached_To_Trench_Board.activeInHierarchy && Barricades_Trench.activeInHierarchy)
//			{
//				Rep_4.SetActive (true);	
//			    Rep_3.SetActive (false);	
//			    Rep_1.SetActive (false);
//				Rep_0.SetActive (false);
//		    }
//				
//		}

		IEnumerator StartWait()
		{
			//Debug.Log ("123");
			yield return new WaitForSeconds (15);
			Stage = 2;

		}
			
		void OnGUI()
		{
			if (FadeIn) {
				alpha += -1 * fadespeed * Time.deltaTime;
				//alpha = Mathf.Clamp01 (alpha);

				Color newColor = GUI.color; 
				newColor.a = alpha;

				GUI.color = newColor;

				GUI.depth = drawDepth;

				GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeTexture);

				//StartCoroutine (SetBool ());

                if (alpha < 0)
                {
                    FadeIn = false;
                }
			}
            if (FadeOut)
            {
                alpha += fadespeed * Time.deltaTime;
                //alpha = Mathf.Clamp01(alpha);

                Color newColor = GUI.color;
                newColor.a = alpha;

                GUI.color = newColor;

                GUI.depth = drawDepth;

                GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeTexture);

                //StartCoroutine (SetBool ());
                Debug.Log(alpha);
                if (alpha > 1)
                {
                    FadeOut = false;
                }
            }
        }
			
        void PerformAction(string tag)
        {
            //Debug.Log("Performing action");

            switch (tag)
            {
			   
//			    case "Toolbox": //toolbox animation, successful speech, make door appear
//                    foreach (Animator anim in Toolbox.GetComponentsInChildren<Animator>())
//                    {
//                        anim.SetBool("Toolbox Trigger", true);
//                    }
//                    Toolbox_Actioned = true;
//                    break;
			    case "Grey_Hardhat":
				    Grey_Hardhat_Actioned=true;
				    //Stage = 2;
				    break;

                case "Worker3":
                    Worker3_Actioned = true;
                    alpha = 0;
                    FadeOut = true;
                    //Stage = 2;
                    break;
//                case "Board_Wall":
//                    Board_Wall.SetActive(false);
//                    Board_Trench.SetActive(true);
//                    if (Arms_Wall_Actioned)
//                    {
//                        Arms_Attached_To_Wall_Board.SetActive(false);
//                        Arms_Attached_To_Trench_Board.SetActive(true);
//                    }
//                    Board_Wall_Actioned = true;
//                    break;
//                case "Arms_Wall":
//                    Arms_Wall.SetActive(false);
//                    if (Board_Wall_Actioned)
//                    {
//                        Arms_Attached_To_Trench_Board.SetActive(true);
//                    }
//                    else
//                    {
//                        Arms_Attached_To_Wall_Board.SetActive(true);
//                    }
//                    Arms_Wall_Actioned = true;
//                    break;
//                case "Cones_Pile":
//                    Cones_Pile.SetActive(false);
//                    Cones_Trench.SetActive(true);
//                    Cones_Pile_Actioned = true;
//				    Barricades_Wall.SetActive(false);
//                    break;
//                case "Barricades_Wall":
//                    Barricades_Wall.SetActive(false);
//                    Barricades_Trench.SetActive(true);
//				    Cones_Pile.SetActive(false);
//                    Barricades_Wall_Actioned = true;
//                    break;
			
			case "Materials":
				Materials_Actioned = true;
				Debug.Log ("Materials");
				alpha = 0;
				Materials.SetActive (false);
				FadeOut = true;
				//Stage = 3;
				break;

			case "Worker":
				Materials.SetActive (false);
				Worker_Actioned = true;
				break;

			case "Wheel_Barrow":
				Wheel_Barrow_Actioned = true;
				alpha = 0;
				Wheel_Barrow.SetActive (false);
				FadeOut = true;
				//Stage = 2;
				break;

			case "Shortcut":
				Shortcut_Actioned = true;
				alpha = 0;
				FadeOut = true;
				//Stage = 2;
				break;

			case "Safe_Route":
				Safe_Route_Actioned = true;
				alpha = 0;
				FadeOut = true;
				//Stage = 2;
				break;

			case "Bricks_Pile_1":
				Bricks_Pile_1_Actioned = true;
				Bricks_Pile_1.SetActive(false);
				//Stage = 2;
				break;
			
			case "Bricks_Pile_2":
				Bricks_Pile_2_Actioned = true;
				Bricks_Pile_2.SetActive(false);
				//Stage = 2;
				break;

			case "Material_Storage_Area":
				Material_Storage_Area_Actioned = true;
				Material_Storage_Area.GetComponent<Animator> ().enabled = false;
				alpha = 0;
				FadeOut = true;
				//Stage = 2;
				break;

			case "Yellow_Hardhat":
				Yellow_Hardhat_Actioned = true;
				Yellow_Hardhat.SetActive(false);
				//Stage = 2;
				break;

			case "White_Hardhat":
				White_Hardhat_Actioned = true;
				White_Hardhat.SetActive(false);
				//Stage = 2;
				break;

			case "Green_Hardhat":
				Green_Hardhat_Actioned = true;
				Green_Hardhat.SetActive(false);
				//Stage = 2;
				break;

			case "Brown_Hardhat":
				Brown_Hardhat_Actioned = true;
				Brown_Hardhat.SetActive(false);
				//Stage = 2;
				break;

			case "Blue_Hardhat":
				Blue_Hardhat_Actioned = true;
				Blue_Hardhat.SetActive(false);
				//Stage = 2;
				break;

			case "Grey_Hardhat_2":
				Grey_Hardhat_2_Actioned = true;
				Grey_Hardhat_2.SetActive(false);
				//Stage = 2;
				break;

//			case "Bricks_Pile":
//				Bricks_Pile_Actioned = true;
//				Debug.Log ("Bricks_Pile");
//				alpha = 0;
//				FadeOut = true;
//				Bricks_Pile.SetActive (false);
//				    //Stage = 3;
//                    break;
            };
        }
    }
}