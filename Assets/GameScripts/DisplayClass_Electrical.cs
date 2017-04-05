using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using com.microeyes.admob;
public class DisplayClass_Electrical : MonoBehaviour {

	public Text QuestionField;
	public Text OptionAField;
	public Text OptionBField;
	public Text OptionCField;
	public Text OptionDField;
	public Text QuestionCountText;
	public Text ScoreFieldText;

	public Button NextButton;
	public Button AButton;
	public Button BButton;
	public Button CButton;
	public Button DButton;

	public Button NextSceneButton;
	public Image transprentLayer;

	List<QuestionTemplate> Questions;

	public float ramdomNumber;
	public int QuestionCount = 0;

	public int TotalQuestionPerRound = 7;
	public int TotalQuestionsInDataBase = 92;
	
	void Start () {


		GameControl.control.TotalRounds = GameControl.control.TotalRounds + 1;
		NextSceneButton.gameObject.SetActive (false);
		transprentLayer.gameObject.SetActive (false);
		NextButton.gameObject.SetActive (false);
		Questions = new List<QuestionTemplate> ();

		Questions.Add (new QuestionTemplate (1," Which of the following is not the trans-mission voltage in America ?","66 kV","l32kV","264 kV","400 kV","264 kV"));
		Questions.Add (new QuestionTemplate (2," Which of the following is usually not the generating voltage  ?","6.6 kV","9.9kV","11 kV","13.2 kV","9.9kV"));
		Questions.Add (new QuestionTemplate (3," Boosters are basically ?","inductors"," capacitors","transformers","synchronous motors","transformers"));
		Questions.Add (new QuestionTemplate (4," Which of the following is not the distribution system normally used ?","3 phase-4 wire","3 phase-3 wire","Single phase - 3 wire","Single phase -4 wire","Single phase -4 wire"));
		Questions.Add (new QuestionTemplate (5," Conductors for high voltage transmission lines are suspended from towers ?","To reduce clearance from ground","To increase clearance from ground","To reduce wind and snow loads","To take care of extension in length during summer","To increase clearance from ground"));
		Questions.Add (new QuestionTemplate (6," Transmission efficiency increases as?"," voltage and power factor both increase ","voltage and power factor both increase"," voltage increases but power factor decreases","voltage decreases but power factor increases","voltage and power factor both increase"));
		Questions.Add (new QuestionTemplate (7," With same maximum voltage to earth, which ac system (with p.f. 0.8) will require more copper as compared to dc 2 wire system ?"," single phase. 2 wire (mid point earthed) "," single phase. 3 wire (neutral=1/2 outer) "," three phase three wire "," three phase-four wire (neutral = outer) "," three phase-four wire (neutral = outer) "));
		Questions.Add (new QuestionTemplate (8," When alternating current passes through a conductor?"," it remains uniformly distributed throughout the section of conductor "," portion of conductor near the surface carries more current as compared to the core "," portion of conductor near the surface carries less current as compared to the core "," entire current passes through the core of the conductor "," portion of conductor near the surface carries more current as compared to the core "));
		Questions.Add (new QuestionTemplate (9," The fact that a conductor carries more current on the surface as compared to core, is known as?","Skin effect","Corona","Permeability","Unsymmetrical fault","Skin effect"));
		Questions.Add (new QuestionTemplate (10," The effective resistance of a conductor will be the same as ohmic resistance when ?"," current is in true sine wave form "," voltage is low "," power factor is unity "," Current is uniformly distributed in the conductor cross-section "," Current is uniformly distributed in the conductor cross-section "));
		Questions.Add (new QuestionTemplate (11," Skin effect results in ?"," reduced effective resistance but increased effective internal reactance of the conductor "," increased effective resistance but reduced effective internal reactance of. the conductor ","  reduced effective resistance as well as effective internal reactance "," increased effective resistance as well as effective internal reactance "," increased effective resistance but reduced effective internal reactance of. the conductor "));
		Questions.Add (new QuestionTemplate (12," Skin effect depends on ?"," size of the conductor "," frequency of the current "," resistivity of the conductor material "," all of the above "," all of the above "));
		Questions.Add (new QuestionTemplate (13," The skin effect of a conductor will reduce as the ?"," diameter increases "," frequency increases "," permeability of conductor material increases "," resistivity of conductor material increases "," resistivity of conductor material increases "));
		Questions.Add (new QuestionTemplate (14,"Skin effect is proportional to ?","Diameter of conductor","(Diameter of conductor)1/2","(Diameter of conductor)3","(Diameter of conductor)2","(Diameter of conductor)2"));
		Questions.Add (new QuestionTemplate (15," In overhead transmission lines the effect of capacitance can be neglected when the length of line is less than ?"," 200 km","160 km","100 km","80 km","80 km"));
		Questions.Add (new QuestionTemplate (16," For constant voltage transmission the voltage drop is compensated by installing ?"," synchronous motors","capacitors","inductors","all of the above."," synchronous motors"));
		Questions.Add (new QuestionTemplate (17," The disadvantage of constant voltage transmission is ?"," short circuit current of the system is increased","load power factor in heavy loads"," large conductor area is required for same power transmission"," air of the above"," short circuit current of the system is increased")); 
		Questions.Add (new QuestionTemplate (18," The surge impedance for over head line is taken as ?"," 10-20 ohms","50-60 ohms","100-200 ohms","1000-2000 ohms","100-200 ohms")); 
		Questions.Add (new QuestionTemplate (19," Pin insulators are normally used up to voltage of about","100kV"," 66 kV","33 kV","25 kV","25 kV")); 
		Questions.Add (new QuestionTemplate (20," Strain type insulator arc used where the conductors arc ?","Dead ended","At intermediate anchor towers","Any of the above","None of the above","Any of the above")); 
		Questions.Add (new QuestionTemplate (21," For 66 kV lines the number of insulator discs used are ?","3","5","8","12","5")); 
		Questions.Add (new QuestionTemplate (22," Ten discs usually suggest that the transmission line voltage is ?"," 11 kV "," 33 kV "," 66 kV "," 132 kV "," 132 kV ")); 
		Questions.Add (new QuestionTemplate (23," The effect of corona is ","Increased energy loss","Increased reactance","Increased inductance","All of the above","Increased energy loss")); 
		Questions.Add (new QuestionTemplate (24," Corona usually occurs when the electrostatic stress in the air around the conductor succeeds ?"," 30 kV (maximum value)/cm "," 22 kV (maximum value)/cm "," 11 kV (rms value)/cm "," 6.6 kv (rms value)/cm. "," 30 kV (maximum value)/cm ")); 
		Questions.Add (new QuestionTemplate (25," Corona effect can be detected by ?"," hissing sound "," faint luminous flow of bluish color "," presence of ozone detected by odor "," all of the above "," all of the above "));
		Questions.Add (new QuestionTemplate (26," The current drawn by the line due to corona losses is ?"," sinusoidal ","  square "," non-sinusoidal ","none of the above"," non-sinusoidal "));
		Questions.Add (new QuestionTemplate (27," Presence of ozone as a result of corona is harmful because?"," it gives bad odor","it corrodes the material","it transfers energy to the ground","reduces power factor","it corrodes the material"));
		Questions.Add (new QuestionTemplate (28," Between two supports, due to sag the conductor takes the form of?","Catenary","Triangle","Ellipse","Semi-circle","Catenary"));
		Questions.Add (new QuestionTemplate (29," The inductance of a single phase two wire line is given by (D is the distance between conductors and 2v is the diameter of conductor)?"," 0.4 loge (D/r) mH/km"," 0.55 loge (D/r) mH/km"," 0.4 loge (r/D) mH/km","  0.55 loge (r/D) mH/km"," 0.4 loge (D/r) mH/km")); 
		Questions.Add (new QuestionTemplate (30," The effect of ice deposition on conductor is?"," increased skin effect","  reduced corona losses"," ellipse  increased weight "," reduced sag"," reduced sag"));
		Questions.Add (new QuestionTemplate (31," The effect of wind pressure is more predominant on?","  transmission lines "," neutral wires"," insulator"," supporting towers"," supporting towers"));
		Questions.Add (new QuestionTemplate (32," Which of the following statement is correct ?","Wind pressure reduces corona effects","Ice on conductors improves power factor","Wind pressure is taken to act in a direction at right angles to that for ice","Wind pressure and ice on conductors together improve regulation of power transmitted","Wind pressure is taken to act in a direction at right angles to that for ice"));
		Questions.Add (new QuestionTemplate (33," Which of the following statements is incorrect?","As the temperature rises the tension in the transmission line decreases","As temperature rises the sag in transmission lines reduces","Tension and sag in transmission lines are complementary to each other","None of the above","Tension and sag in transmission lines are complementary to each other"));
		Questions.Add (new QuestionTemplate (34," Wooden poles for supporting transmission lines are used for voltages up to?"," 440 V "," 11 kV "," 22 kV"," 66 kV"," 22 kV"));
		Questions.Add (new QuestionTemplate (35," If K is the volume of cable conductor material required to transmit power, then for the transmission of the same power, the volume of cable conductor required for single phase 2 wise AC system is?"," 2k "," k cosφ"," k/ cos2φ "," 2k/ cos2p "," 2k/ cos2p "));
		Questions.Add (new QuestionTemplate (36," Maximum permissible span for wooden poles is?"," 10 meter "," 20 meters "," 60 meters "," 200 meters "," 60 meters "));
		Questions.Add (new QuestionTemplate (37," When transformers or switchgears are to be installed in a transmission line, the poles used are?"," I type "," J type "," H type "," L type "," H type "));
		Questions.Add (new QuestionTemplate (38," For improving life, steel poles are galvanized. Galvanizing is the process of applying a layer of?"," paint "," varnish "," tar coal "," zinc "," zinc "));
		Questions.Add (new QuestionTemplate (39," The disadvantage of transmission lines as compared to cables is?"," exposure to lightening "," exposure to atmospheric hazards like smoke, ice, etc. "," inductive interference between power and communication circuits "," all of the above "," all of the above "));
		Questions.Add (new QuestionTemplate (40," ACSR conductor implies?"," All conductors surface treated and realigned "," Aluminum conductor steel reinforced "," Anode current sinusoidally run "," Anodized Core Smooth Run "," Aluminum conductor steel reinforced "));
		Questions.Add (new QuestionTemplate (41," The surge resistance of transmission lines is about?"," 50 ohms "," 100 ohms "," 250 ohms "," 500 ohms "," 500 ohms "));
		Questions.Add (new QuestionTemplate (42," During storm the live conductor of public electric supply breaks down and touches the earth. The consequences will be?"," supply voltage will drop "," supply voltage will increase "," current will flow to earth "," no current will flow in the conductor "," current will flow to earth "));
		Questions.Add (new QuestionTemplate (43," In transmission system a feeder feeds power to?"," service mains"," generating stations"," distributors"," all of the above"," distributors"));
		Questions.Add (new QuestionTemplate (44," For transmission lines the standing wave ratio is the ratio of?","Maximum voltage to minimum voltage","Maximum current to minimum voltage","Peak voltage to rms voltage","Maximum reactance to minimum reactance","Maximum voltage to minimum voltage"));
		Questions.Add (new QuestionTemplate (45," In a transmission line following arc the distributed constants?"," resistance and inductance only"," resistance, inductance and capacitance"," resistance, inductance, capacitance and short conductance"," any of the above "," resistance, inductance, capacitance and short conductance"));
		Questions.Add (new QuestionTemplate (46," The bundling of conductors is done primarily to?"," reduce reactance"," increase reactance"," increase ratio interference"," reduce radio interference"," reduce reactance"));
		Questions.Add (new QuestionTemplate (47," Which of the following regulation is considered to be the best?"," 2% "," 30% "," 70%"," 98%."," 2% "));
		Questions.Add (new QuestionTemplate (48," The characteristic impedance of a transmission line depends upon?","Shape of the conductor","Surface treatment of the conductors","Conductivity of the material","Geometrical configuration. of the conductors","Geometrical configuration. of the conductors"));
		Questions.Add (new QuestionTemplate (49," For a distortion-less transmission line (G = shunt conductance between two wires)?","R/L = G/C","RL=GC","RG=LC","RLGC=0 ","R/L = G/C"));
		Questions.Add (new QuestionTemplate (50," Guard ring transmission line?"," Improves power factor ","Reduces earth capacitance of the lowest unit"," Reduces transmission losses"," Improves regulation ","Reduces earth capacitance of the lowest unit"));
		Questions.Add (new QuestionTemplate (51," When the power is to be transmitted over a distance of 500 km, the transmission voltage should be in the range?"," 33 kV - 66 kV "," 66 kV - 100 kV "," 110 kV - 150 kV"," 150kV - 220kV "," 150kV - 220kV "));
		Questions.Add (new QuestionTemplate (52," A relay used on long transmission lines is?"," mho's relay"," reactance relay "," impedance relay"," no relay is used "," mho's relay"));
		Questions.Add (new QuestionTemplate (53," Total load transmitted through a 3 phase transmission line is 10,000 kW at 0.8 power factor lagging. The I2R losses are 900 kW. The efficiency of transmission line is?"," 60% "," 90% "," 95%"," 99% "," 90% "));
		Questions.Add (new QuestionTemplate (54," Litz wires are used for intermediate frequencies.to overcome?"," corona effect "," skin effect "," radio interference "," all of the above "," skin effect "));
		Questions.Add (new QuestionTemplate (55," In order to reduce skin effect at UHF?"," conductors are painted "," conductors are anodized "," copper lubes with silver plating are used "," copper rods with silver plating are used "," copper lubes with silver plating are used "));
		Questions.Add (new QuestionTemplate (56," Shunt capacitance is usually neglected in the analysis of?"," Short transmission lines "," Medium transmission lines "," Long transmission lines "," Medium as well as long transmission lines "," Short transmission lines "));
		Questions.Add (new QuestionTemplate (57," The chances of corona are maximum during?"," summer heat "," winter "," dry weather "," humid weather "," humid weather "));
		Questions.Add (new QuestionTemplate (58," The power transmitted will be maximum when?"," Sending end voltage is more "," Receiving end voltage is more "," Reactance is high "," Corona losses are least "," Sending end voltage is more "));
		Questions.Add (new QuestionTemplate (59," Neglecting losses in a transmission system, if the voltage is doubled, for the same power transmission, the weight of conductor material required will be?"," four times "," double "," half "," one fourth "," one fourth "));
		Questions.Add (new QuestionTemplate (60," When two conductors each of radius r are at a distance D, the capacitance between the two is proportional to?"," loge (D/r) "," loge (r/D) "," 1/loge (D/r) "," 1/loge (r/D) "," 1/loge (D/r) "));
		Questions.Add (new QuestionTemplate (61," In a transmission line having negligible resistance the surge impedance is?"," (L+C)1/2 "," (C/L)1/2 "," (1/LC)1/2 "," (L/C)1/2 "," (L/C)1/2 "));
		Questions.Add (new QuestionTemplate (62," A relay used on short transmission lines is "," Reactance relay "," Mho's relay "," Impedance relay "," None of the above "," Reactance relay "));
		Questions.Add (new QuestionTemplate (63," In case the characteristic impedance of the line is equal to the load impedance?"," all the energy will pass to the earth "," all the energy will be lost in transmission losses "," the system will resonate badly "," all the energy sent will be absorbed by the load "," all the energy sent will be absorbed by the load "));
		Questions.Add (new QuestionTemplate (64," For a properly terminated line?"," ZR=ZO "," Z/R > ZO "," ZR < ZO "," ZR =Z0 = 0 "," ZR =Z0 = 0 "));
		Questions.Add (new QuestionTemplate (65," The dielectric strength of air at 250C and 76 cm/Hg is?"," 1 kV/cm "," 1 kV/mm "," 3 kV/cm "," 30 kV/cm "," 30 kV/cm "));
		Questions.Add (new QuestionTemplate (66," The chances of corona are maximum in?"," domestic wiring "," distribution lines "," transmission lines "," all of the above "," transmission lines "));
		Questions.Add (new QuestionTemplate (67," Transmission lines link?"," service points to consumer premises "," distribution transformer to consumer premises "," receiving end station to distribution transformer "," generating station to receiving end station "," generating station to receiving end station "));
		Questions.Add (new QuestionTemplate (68," In case of open circuit transmission lines the reflection coefficient is?"," 1 ","0.5 "," -1 "," zero "," zero "));
		Questions.Add (new QuestionTemplate (69," Impedance relay is used on?"," Short transmission lines "," Medium transmission lines "," Long transmission line "," All the transmission lines "," Medium transmission lines "));
		Questions.Add (new QuestionTemplate (70," Which type of insulators are used on 132 kV transmission lines ?","Pin type","Disc type","Shackle type","Pin and shackle type","Disc type"));
		Questions.Add (new QuestionTemplate (71," String efficiency can be improved by?"," Using Longer cross arm "," Grading the insulator "," Using a guard ring ","Any of the above","Any of the above"));
		Questions.Add (new QuestionTemplate (72," Minimum horizontal clearance of a low voltage transmission line from residential buildings must be?"," 11/2 feet "," 3 feet "," 4 feet "," 8 feet "," 4 feet "));
		Questions.Add (new QuestionTemplate (73," If a 66 kV lines passes over a residential building, the minimum vertical clearance from the roof of the building must be?"," 8 feet "," 12 feet "," 13 feet "," 16 feet "," 13 feet "));
		Questions.Add (new QuestionTemplate (74," Alternating current power is transmitted at high voltage?"," to safeguard against pilferage "," to minimize transmission losses "," to reduce cost of generation "," to make the system reliable "," to minimize transmission losses "));
		Questions.Add (new QuestionTemplate (75," Stranded conductors arc used for transmitting, power at high voltages because of?"," increased tensile strength "," better wind resistance"," ease-in handling "," low cost "," ease-in handling "));
		Questions.Add (new QuestionTemplate (76," For the same resistance of line the ratio, weight of copper conductor/ weight of aluminium conductor , is?"," 0.50 "," 0.75 "," 1.50 "," 2.0 "," 2.0 "));
		Questions.Add (new QuestionTemplate (77," The function of steel wire in a ACSR conductor is?"," to take care of surges "," to prevent corona "," to reduce inductance and hence improve power factor "," to provide additional mechanical strength "," to provide additional mechanical strength "));
		Questions.Add (new QuestionTemplate (78," In high voltage transmission lines the top most conductor is?"," R-phase conductor "," Y- phase conductor "," B-phase conductor "," Earth conductor "," Earth conductor "));
		Questions.Add (new QuestionTemplate (79," For 11 kV line the inductance per km per phase will be of the order of?"," 1 H "," 0.1 H ","1 mH"," 0.1 mH ","1 mH"));
		Questions.Add (new QuestionTemplate (80," For 11 kV. line the capacitance per km per phase will be of the order of?"," 1 Farad ","0.1 Farad ","0.01 Farad","0.01 microF ","0.01 Farad"));
		Questions.Add (new QuestionTemplate (81," If 3000 kW power is to be transmitted over a distance of 30 km, the desirable transmission voltage will be?"," 11 kV ","33 kV ","66 kV ","132 kV ","33 kV "));
		Questions.Add (new QuestionTemplate (82," The permissible voltage variation in transmission and distribution system is?"," ± 0.1% ","± 1% ","±10% ","± 25% ","±10% "));
		Questions.Add (new QuestionTemplate (83," The voltage of transmission can be regulated by?"," use of tap changing transformers ","switching in shunt capacitors at the receiving end during heavy loads ","use of series capacitors to neutralize the effect of series reactance ","any of the above methods ","any of the above methods "));
		Questions.Add (new QuestionTemplate (84," The most economic voltage for transmitting given power over a known distance by overhead transmission line is approximately?"," 3.6 kV/km ","1.6 kV/km ","2.6 kV/km ","3.6 kVkm "," 3.6 kV/km "));
		Questions.Add (new QuestionTemplate (85," String efficiency is given by?","(voltage across the string) / ((numbers of discs on the string) x (voltage across disc nearest to the conductor))","((voltage across the string) x (numbers of discs on the string)) / (voltage across disc nearest to the conductor)","( (voltage across disc nearest to the conductor) x (numbers of discs on the string)) / (voltage across the string) ","(voltage across disc nearest to the conductor))/ ((numbers of discs on the string) x (voltage across the string) ","(voltage across the string) / ((numbers of discs on the string) x (voltage across disc nearest to the conductor))"));
		Questions.Add (new QuestionTemplate (86," For a 66 kV line having span of 200 meters between towers the approximate sag will be?"," 0.02 m ","0.2 m ","2 m ","20 m ","2 m "));
		Questions.Add (new QuestionTemplate (87," In the above case if the span is doubled, the sag will be ?","2 m ","4m ","8m ","1 m ","8m "));
		Questions.Add (new QuestionTemplate (88," The reflection coefficient for a short circuit line is?"," 1 ","Zero ","0.5 ","- 1 ","- 1 "));
		Questions.Add (new QuestionTemplate (89," In case the height of transmission tower is increased?"," the line capacitance and inductance will not change ","the line capacitance will decrease but line inductance will decrease ","the line capacitance will decrease and line inductance will increase ","the line capacitance will decrease but line inductance will remain unaltered ","the line capacitance will decrease but line inductance will remain unaltered "));
		Questions.Add (new QuestionTemplate (90," In a transmission line if booster transformer are to be used, preferred location will be?","At the receiving end","At the sending end ","At the intermediate point","Any where in the line ","At the intermediate point"));
		Questions.Add (new QuestionTemplate (91," The sag of the conductors of a transmission line is 1.5 m when the span is 100 m. Now if the height of supporting towers is increased by 20%, the sag will?"," increase by 20%","increase by 20%"," reduced by 20%","remain unchanged","remain unchanged"));
		Questions.Add (new QuestionTemplate (92," ACSR conductor having 7 steel stands surrounded by 25 aluminum conductor will be specified as?"," 7/25","7/32","25/7","25/32","25/7"));
		Questions.Add (new QuestionTemplate (93," Which of the following relationships is not valid for short transmission lines?","B = Z = C","A = D = 1","Is = I","None of the above","B = Z = C"));
		Questions.Add (new QuestionTemplate (94," In order to improve the steady state stability of an overhead transmission lines, which of the following methods can be adopted?"," Reducing impedance between the stations","Adopting quick response excitation systems","Using series capacitors to make X = (3 R)1/2","Any of the above","Any of the above"));
		Questions.Add (new QuestionTemplate (95," Transient disturbances arc due to?"," Switching operations","Load variations","Faults","Any of the above","Any of the above"));
		Questions.Add (new QuestionTemplate (96," Which of the following short circuit is the most dangerous?"," Line to line short circuit","Dead short circuit","Line to ground short circuit","Line to line and ground short circuit","Dead short circuit"));
		Questions.Add (new QuestionTemplate (97," In case line to line fault occurs, the short circuit current of an alternator will .depend on its?","Synchronous reactance","Transient reactance","Short circuit resistance","All of the above","Synchronous reactance"));
		Questions.Add (new QuestionTemplate (98," Transient state stability is generally improved by?","Using high speed governors on machines by","Using low inertia machines","Dispensing with neutral grounding","Any of the above","Using high speed governors on machines by"));
		Questions.Add (new QuestionTemplate (99," Aluminium is being favored as bus-bar material mainly because of?"," case of fabrication","low density","low cost","non availability of copper","low cost"));
		Questions.Add (new QuestionTemplate (100," A 70/6 ACSR conduction is an aluminium conductor steel reinforced, having?"," cross sectional area of aluminium as 70 mm2 and the cross-sectional area of steel as 6 mm2 ","cross-sectional area of steel as 70 mm2 and the cross-sections area of aluminium as 6 mm2 ","70 aluminium conductors and 6 steel conductors","80 steel conductors and 6 aluminium conductors ","70 aluminium conductors and 6 steel conductors"));
		Questions.Add (new QuestionTemplate (101," In aluminium conductors steel reinforced, the insulation between aluminium and steel conductors is?"," any insulator ","bitumen ","insulin ","no insulation is required ","no insulation is required "));
		Questions.Add (new QuestionTemplate (102," Under no load conditions the current in a transmission line is due to?"," corona effects ","capacitance of the line ","back flow from earth ","spinning reserve ","capacitance of the line "));
		Questions.Add (new QuestionTemplate (103," Which distribution system is more reliable?","Ring main system","Tree system","Radial system ","All are equally reliable ","Ring main system"));
		Questions.Add (new QuestionTemplate (104," Out of the following systems of distribution, which system offers the best economy?","Direct current system","AC single phase system","AC 3 phase 3 wire system","AC 3 phase 4 wire system","Direct current system"));
		Questions.Add (new QuestionTemplate (105," What are the advantages of dc transmission system over ac transmission system?"," DC system is economical ","There is no skin effect in dc system ","Corona limits are highest for dc circuits as compared to ac circuits ","All of the above ","All of the above "));
		Questions.Add (new QuestionTemplate (106," The main advantage of ac. transmission system over d.c. transmission system is?"," Easy transformation ","Less losses in transmission over long distances ","Less insulation problems ","Less problem of instability ","Less losses in transmission over long distances "));
		Questions.Add (new QuestionTemplate (107," Step-up substations are associated with?"," distributors ","consumer location ","concentrated load ","generating stations ","generating stations "));
		Questions.Add (new QuestionTemplate (108," An isolator is represented by?"," A ","B ","C ","A and D ","A and D "));
		Questions.Add (new QuestionTemplate (109," C represents?","Circuit breaker","Mho's relay","Earth switch","None of the above","Circuit breaker"));
		Questions.Add (new QuestionTemplate (110," When an alternator is connected to the infinite but bar and its excitation is gradually increased?"," the terminal voltage will rise ","the terminal voltage will drop ","the terminal voltage will remain unaltered ","the terminal voltage will vary rapidly ","the terminal voltage will remain unaltered "));
		Questions.Add (new QuestionTemplate (111," Consumers having low power factor equipment are advised to install?"," tap changing transformer ","capacitor bank ","synchronous condensers ","none of the above ","capacitor bank "));
		Questions.Add (new QuestionTemplate (112," A bus bar is rated by?"," current only ","current and voltage only ","current, voltage, frequency ","current, voltage, frequency and short time current ","current, voltage, frequency and short time current "));
		Questions.Add (new QuestionTemplate (113," Material generally used for bus bar is?"," copper ","aluminium ","steel ","tungsten ","aluminium "));
		Questions.Add (new QuestionTemplate (114," Which of following properties has got higher value for aluminium as compared to copper?"," Melting point ","Specific gravity ","Electrical resistivity ","Thermal conductivity ","Electrical resistivity "));
		Questions.Add (new QuestionTemplate (115," For carrying a 100 A (rms) current the cross-sectional area of aluminium bus bar should be at least?"," 1 mm2 ","10 mm 2 ","25 mm 2 ","50 mm2 ","25 mm 2 "));
		Questions.Add (new QuestionTemplate (116," Isolators are used to disconnect a circuit when?"," line is on full load ","line is energized ","circuit breaker is not open "," there is no current in the line "," there is no current in the line "));
		Questions.Add (new QuestionTemplate (117," Tap changing transformers are used for?"," stepping up the voltage ","stepping up the voltage ","both stepping up and stepping down the voltage ","supplying low voltage current for instruments. ","both stepping up and stepping down the voltage "));
		Questions.Add (new QuestionTemplate (118,"  Which device automatically interrupts the supply in the event of surges?"," Earthing switch "," Series reactor ","Isolator ","Circuit breaker ","Circuit breaker "));
		Questions.Add (new QuestionTemplate (119," In a substation the equipment used to limit short circuit current level is?","Series reactor","Coupling capacitor","Lightening switch","Isolator","Series reactor"));
		Questions.Add (new QuestionTemplate (120," Which of the following equipment is not installed in a substation?"," Shunt reactors ","Exciters ","Voltage transformers ","Series capacitors ","Exciters "));
		Questions.Add (new QuestionTemplate (121," Which bus bar scheme offers the lowest cost?","Single bus bar scheme","Ring bus bar scheme","Breaker and a half scheme","Main and transfer scheme","Single bus bar scheme"));
		Questions.Add (new QuestionTemplate (122," Which is the most expensive bus bar scheme?"," Single bus bar scheme ","Ring bus bar scheme ","Double bus bar double breaker ","Main and transfer scheme ","Double bus bar double breaker "));
		Questions.Add (new QuestionTemplate (123," Current rating is not necessary in case of?","Isolators","Circuit breakers","Load break switches","Circuit breakers and load break switches","Isolators"));
		Questions.Add (new QuestionTemplate (124," Which of the following correctly represents the sequence of operations of isolator circuit breaker and earthing switch while opening a circuit?"," Close earthing switch - open circuit breaker open isolator ","Open isolator - close circuit breaker - open earthing switch ","Open circuit breaker - open isolator - close earthing switch ","Close circuit breaker - close isolator - open earthing switch ","Open circuit breaker - open isolator - close earthing switch "));
		Questions.Add (new QuestionTemplate (125," Which of the following correctly presents the sequence of operations of isolator circuit breaker and earthing switch while closing a circuit?"," Ensure circuit breaker is closed - close isolator - open earthing switch ","Ensure circuit breaker is open - close isolator - open earthing switch if any close circuit breaker ","Ensure circuit breaker is open - open isolator - open earthing switch if any - close circuit breaker","None of the above ","Ensure circuit breaker is open - close isolator - open earthing switch if any close circuit breaker "));
		Questions.Add (new QuestionTemplate (126," Which of the following type tests are conducted on isolators?"," Temperature rise test ","Impulse stage with stand test ","Short time current test ","All of the above ","All of the above "));
		Questions.Add (new QuestionTemplate (127," In a balance 3 φ , 4 wire AC system, the phase sequence is RYB. If the voltage of R phase is 230 < 0° V, then for Y phase?"," 230 < 0 V ","230 < 60° V ","230 < 90°V ","230 < 120° V ","230 < 120° V "));
		Questions.Add (new QuestionTemplate (128," The relation between traveling voltage wave and current wave is?","e = i (L/C) 1/2","e = i (C/L) 1/2","e = i (iL/C) 1/2","(L/iC) 1/2","e = i (L/C) 1/2"));
		Questions.Add (new QuestionTemplate (129,"? Steepness of the traveling waves is attenuated by","resistance of the line","inductance of the line"," capacitance of the line","all of the above","resistance of the line"));
		Questions.Add (new QuestionTemplate (130," The protection against direct lightening strokes and high voltage steep waves is provided by?"," earthing of neutral","lightening arresters","ground wires"," lightening arresters and ground wires"," lightening arresters and ground wires"));
		Questions.Add (new QuestionTemplate (131," Voltages under Extra High Voltage are?"," 1 kV and above","11 kV and above","132 kV and above","330 kV and above","330 kV and above"));
		Questions.Add (new QuestionTemplate (132," In outdoor substation, the lightening arresters is placed nearer to?"," the isolator","the current transformer","the power transformer","the current breaker","the power transformer"));
		Questions.Add (new QuestionTemplate (133," Stability of a system is not affected by?"," Reactance of line","Losses","Reactance of generator","Output torque","Losses"));
		Questions.Add (new QuestionTemplate (134," A 10 MVA generator has power factor 0.866 lagging. The reactive power produced will be?"," 10 MVA","8 MVA","5 MVA","1.34 MVA","5 MVA"));
		Questions.Add (new QuestionTemplate (135," In order to increase the limit of distance of transmission line?","series resistances are used","synchronous condensers are used","shunt capacitors and series reactors are used","series capacitors and shunt reactors are used","series capacitors and shunt reactors are used"));
		Questions.Add (new QuestionTemplate (136," A 30 km transmission line carrying power at 33 kV is known as?","short transmission line","long transmission line","high power line","ultra high voltage line","short transmission line"));
		Questions.Add (new QuestionTemplate (137," If K is the volume of conductor material required for 2 wire dc system with one conductor earthed, then the volume of cable conductor material required for transmission of same power in single phase 3 wire system is (A) K/3 cos φ?"," 5K cos2φ","K/3 cos φ","K/ 5 cos2φ","5K/ 8 cos2φ","K/ 5 cos2φ"));
		Questions.Add (new QuestionTemplate (138," The permissible voltage variable in voltage in distribution is?","  0.1%","1%","10%","50%","10%"));
		Questions.Add (new QuestionTemplate (139," Surge impedance of transmission line is given by?","(L/C)1/2","(C/L)1/2","(CL)1/2","1/(CL)1/2","(L/C)1/2"));
		Questions.Add (new QuestionTemplate (140," 750 kV is termed as?"," Medium high voltage","High voltage","Extra high voltage","Ultra high voltage","Ultra high voltage"));
		Questions.Add (new QuestionTemplate (141," In case of transmission line conductors with the increase in atmospheric temperature?"," length increase but stress decreases","length increases and stress also increases","length decreases but stress increases","both length as well as stress decreases."," length increase but stress decreases"));
		Questions.Add (new QuestionTemplate (142," If the height of transmission towers is increased, which of the following parameters is likely to change?"," Resistance","Inductance","Capacitance"," None of the above","Capacitance"));
		Questions.Add (new QuestionTemplate (143," For increasing the capacity of a transmission line to transmit power which of the following must be decreased?"," Voltage","Capacitance","Line inductance","All of the above","Line inductance"));
		Questions.Add (new QuestionTemplate (144," In terms of constants A, B, C and D for short transmission lines, which of the following relation is valid?"," A = B = 1","B = D = 0","A = C = 1","C=0","C=0"));
		Questions.Add (new QuestionTemplate (145," Which of the following is reduced due to the use of bundled conductors?"," Capacitance of the circuit","lnductance of the circuit","Power loss due to corona","All of the above","Power loss due to corona"));
		Questions.Add (new QuestionTemplate (146," The ratio of capacitance from line to line capacitance from line to neutral is nearly?","1/4","1/2","1","2","1/4"));
		Questions.Add (new QuestionTemplate (147," The sag of a transmission line is least affected by?"," self weight of conductors","temperature of surrounding air","current through conductor","voltage through conductor","current through conductor"));

		/*foreach (QuestionTemplate Ques in Questions) 
		{
			//Debug.Log(Ques.Question);
		}*/
		NextButtonClick ();
	}
	public void NextScreen()
	{
		Intestinal_Ad_Load ();
		Application.LoadLevel ("GreetScene");

	}

	public void NextButtonClick()
	{
		Debug.Log ("=========================              "+Questions.Count);
		timeLeft = 10f;
		transprentLayer.gameObject.SetActive (false);
		NextButton.gameObject.SetActive (false);
		GameControl.control.ACorrectAnswer = false;
		GameControl.control.BCorrectAnswer = false;
		GameControl.control.CCorrectAnswer = false;
		GameControl.control.DCorrectAnswer = false;
		GameControl.control.AWrongAnswer = false;
		GameControl.control.BWrongAnswer = false;
		GameControl.control.CWrongAnswer = false;
		GameControl.control.DWrongAnswer = false;

		GameControl.control.isACorrect = false;
		GameControl.control.isBCorrect = false;
		GameControl.control.isCCorrect = false;
		GameControl.control.isDCorrect = false;

		AButton.interactable = true;
		BButton.interactable = true;
		CButton.interactable = true;
		DButton.interactable = true;

		QuestionCount = QuestionCount + 1;
		QuestionCountText.text = QuestionCount + "/"+TotalQuestionPerRound;

		if (QuestionCount == TotalQuestionPerRound) 
		{
			NextButton.interactable = false;
			NextButton.gameObject.SetActive(false);
			NextSceneButton.gameObject.SetActive (true);
		}

		ramdomNumber = UnityEngine.Random.Range(0, Questions.Count);
		Debug.Log ("random number =              "+ramdomNumber);
		for(int i = 0; i < Questions.Count; i++)
		{

			if (ramdomNumber == i)
			{
				QuestionField.text = Questions[i].Question;
				OptionAField.text = Questions[i].OptionA;
				OptionBField.text = Questions[i].OptionB;
				OptionCField.text = Questions[i].OptionC;
				OptionDField.text = Questions[i].OptionD;
			}
		}

	}
	public Text TimerText;
	public float timeLeft = 10f;

	IEnumerator TimerScript(){
		if (QuestionCount == TotalQuestionPerRound + 1) 
		{
			NextButton.interactable = false;
			NextButton.gameObject.SetActive(false);
			NextSceneButton.gameObject.SetActive (true);
			timeLeft = -1f;
			NextScreen();
		}
		yield return new WaitForSeconds(1f);
		timeLeft -= Time.deltaTime;
		TimerText.text = Mathf.Round(timeLeft).ToString();
		if ( Mathf.Round(timeLeft) == 0 )
		{
			NextButtonClick();

			//yield return new WaitForSeconds(1f);
			timeLeft = 10f;
		}

	}

	void Update () {

		StartCoroutine ("TimerScript");

		ScoreFieldText.text = "#:" + GameControl.control.score;
	}

	public void OptionAButton()
	{
		Correcting ();
	}
	public void OptionBButton()
	{
		Correcting ();
	}
	public void OptionCButton()
	{
		Correcting ();
	}
	public void OptionDButton()
	{
		Correcting ();
	}
	void Correcting()
	{
		for (int i = 0; i < Questions.Count; i++) {
			if (ramdomNumber == i) {

				if (Questions [i].OptionA == Questions [i].CorrectAnswer) {
					GameControl.control.ACorrectAnswer = true;
					GameControl.control.isACorrect = true;

				} else {
					GameControl.control.AWrongAnswer = true;
					GameControl.control.isACorrect = false;
				}

				if (Questions [i].OptionB == Questions [i].CorrectAnswer) {
					GameControl.control.BCorrectAnswer = true;
					GameControl.control.isBCorrect = true;
					//WrongSoundAS.clip = WrongSoundAC;
					//WrongSoundAS.Play ();
				} else {
					GameControl.control.BWrongAnswer = true;
					GameControl.control.isBCorrect = false;
				}

				if (Questions [i].OptionC == Questions [i].CorrectAnswer) {
					GameControl.control.CCorrectAnswer = true;
					GameControl.control.isCCorrect = true;
					//WrongSoundAS.clip = WrongSoundAC;
					//WrongSoundAS.Play ();
				} else {
					GameControl.control.CWrongAnswer = true;
					GameControl.control.isCCorrect = false;
				}

				if (Questions [i].OptionD == Questions [i].CorrectAnswer) {
					GameControl.control.DCorrectAnswer = true;
					GameControl.control.isDCorrect = true;
					//WrongSoundAS.clip = WrongSoundAC;
					//WrongSoundAS.Play ();
				} else {
					GameControl.control.DWrongAnswer = true;
					GameControl.control.isDCorrect = false;
				}

				RemoveQuestionsAfterDisplay ();
			}
		}

	}


	void RemoveQuestionsAfterDisplay()
	{
		transprentLayer.gameObject.SetActive (true);
		NextButton.gameObject.SetActive (true);
		for (int i = 0; i < Questions.Count; i++) {
			if (ramdomNumber == i) {
				Questions.Remove (Questions [i]);
			}
		}

	}


	public void Intestinal_Ad_Create () {
		InterstitialAd l_interAd = AdmobManager.PrepareInterstitialAd("Interstitial_1");
		l_interAd.AdUnitId = "ca-app-pub-6065714673957825/2806333668";
		l_interAd.Create();
	}
	public void Intestinal_Ad_Load () {
		InterstitialAd l_interAd = AdmobManager.Get<InterstitialAd>("Interstitial_1");
		l_interAd.Load();
	}
	public void Intestinal_Ad_Show () {
		InterstitialAd l_interAd = AdmobManager.Get<InterstitialAd>("Interstitial_1");
		l_interAd.Show();
	}

}
