using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using InscryptionAPI.Sound;

namespace ExampleMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]

    public class Plugin : BaseUnityPlugin
    {
        Harmony harmony = new Harmony(PluginGuid);

        private const string PluginGuid = "creator.supermarioworld.gramophone.add.tracks";
        private const string PluginName = "SuperMarioWorldGramophoneMod";
        private const string PluginVersion = "1.0.0";

        //Initializes the configs
        public ConfigEntry<bool> configEnable1;
        public ConfigEntry<bool> configEnable2;
        public ConfigEntry<bool> configEnable3;
        public ConfigEntry<bool> configEnable4;
        public ConfigEntry<bool> configEnable5;
        public ConfigEntry<bool> configEnable6;
        public ConfigEntry<bool> configEnable7;
        public ConfigEntry<bool> configEnable8;
        public ConfigEntry<bool> configEnable9;
        public ConfigEntry<bool> configEnable10;
        public ConfigEntry<bool> configEnable11;
        public ConfigEntry<bool> configEnable12;
        public ConfigEntry<bool> configEnable13;
        public ConfigEntry<bool> configEnable14;
        public ConfigEntry<bool> configEnable15;
        public ConfigEntry<bool> configEnable16;
        public ConfigEntry<bool> configEnable17;
        public ConfigEntry<bool> configEnable18;
        public ConfigEntry<bool> configEnable19;
        public ConfigEntry<bool> configEnable20;
        public ConfigEntry<bool> configEnable21;
        public ConfigEntry<bool> configEnable22;
        public ConfigEntry<bool> configEnable23;
        public ConfigEntry<bool> configEnable24;
        public ConfigEntry<bool> configEnable25;
        public ConfigEntry<bool> configEnable26;
        public ConfigEntry<bool> configEnable27;
        public ConfigEntry<bool> configEnable28;
        public ConfigEntry<bool> configEnable29;
        public ConfigEntry<bool> configEnable30;
        public ConfigEntry<bool> configEnable31;
        public ConfigEntry<bool> configEnable32;
        public ConfigEntry<bool> configEnable33;
        public ConfigEntry<bool> configEnable34;
        public ConfigEntry<bool> configEnable35;
        public ConfigEntry<bool> configEnable36;
        public ConfigEntry<bool> configEnable37;
        public ConfigEntry<bool> configEnable38;
        public ConfigEntry<bool> configEnable39;
        public ConfigEntry<bool> configEnable40;
        public ConfigEntry<bool> configEnable41;
        public ConfigEntry<bool> configEnable42;
        public ConfigEntry<bool> configEnable43;
        public ConfigEntry<bool> configEnable44;
        public ConfigEntry<bool> configEnable45;
        public ConfigEntry<bool> configEnable46;
        public ConfigEntry<bool> configEnable47;
        public ConfigEntry<bool> configEnable48;
        public ConfigEntry<bool> configEnable49;
        public ConfigEntry<bool> configEnable50;
        public ConfigEntry<bool> configEnable51;
        public ConfigEntry<bool> configEnable52;
        public ConfigEntry<bool> configEnable53;
        public ConfigEntry<bool> configEnable54;
        public ConfigEntry<bool> configEnable55;
        public ConfigEntry<bool> configEnable56;
        public ConfigEntry<bool> configEnable57;
        public ConfigEntry<bool> configEnable58;
        public ConfigEntry<bool> configEnable59;
        public ConfigEntry<bool> configEnable60;
        public ConfigEntry<bool> configEnable61;
        public ConfigEntry<bool> configEnable62;
        public ConfigEntry<bool> configEnable63;
        public ConfigEntry<bool> configEnable64;
        public ConfigEntry<bool> configEnable65;
        public ConfigEntry<bool> configEnable66;

        public void Awake()
        {
            // Summpms The Config file
            configEnable1 = Config.Bind<bool>("Gramopone.Enable.Songs",
                        "Nintendo Logo?",
                        true,
                        "Should the 'Nintendo Logo' Track Show up on the Gramophone?");
            configEnable2 = Config.Bind<bool>("Gramopone.Enable.Songs",
                        "Title?",
                        true,
                        "Should the 'Title' Track Show up on the Gramophone?");
            configEnable3 = Config.Bind<bool>("Gramopone.Enable.Songs",
                        "Yoshis Island?",
                        true,
                        "Should the 'Yoshi's Island' Track Show up on the Gramophone?");
            configEnable4 = Config.Bind<bool>("Gramopone.Enable.Songs",
                        "Wandering the Plains?",
                        true,
                        "Should the 'Wandering the Plains' Track Show up on the Gramophone?");
            configEnable5 = Config.Bind<bool>("Gramopone.Enable.Songs",
                        "Vanilla Dome?",
                        true,
                        "Should the 'Vanilla Dome' Track Show up on the Gramophone?");
            configEnable6 = Config.Bind<bool>("Gramopone.Enable.Songs",
                        "Forest of Illusion?",
                        true,
                        "Should the 'Forest of Illusion' Track Show up on the Gramophone?");
            configEnable7 = Config.Bind<bool>("Gramopone.Enable.Songs",
                        "Bowsers Castle Emerges?",
                        true,
                        "Should the 'Bowser's Castle Emerges' Track Show up on the Gramophone?");
            configEnable8 = Config.Bind<bool>("Gramopone.Enable.Songs",
                        "Valley of Bowser?",
                        true,
                        "Should the 'Valley of Bowser' Track Show up on the Gramophone?");
            configEnable9 = Config.Bind<bool>("Gramopone.Enable.Songs",
                        "Star Road?",
                        true,
                        "Should the 'Star Road' Track Show up on the Gramophone?");
            configEnable10 = Config.Bind<bool>("Gramopone.Enable.Songs",
                        "a Special World?",
                        true,
                        "Should the 'a Special World' Track Show up on the Gramophone?");
            configEnable11 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "b Super Mario Bros. Remix?",
            true,
            "Should the 'b Super Mario Bros. Remix' Track Show up on the Gramophone?");
            configEnable12 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "a Overworld?",
            true,
            "Should the 'a Overworld' Track Show up on the Gramophone?");
            configEnable13 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "b Overworld (Yoshi)?",
            true,
            "Should the 'b Overworld (Yoshi)' Track Show up on the Gramophone?");
            configEnable14 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "c Overworld (Hurry)?",
            true,
            "Should the 'c Overworld (Hurry)' Track Show up on the Gramophone?");
            configEnable15 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "d Overworld (Hurry Yoshi)?",
            true,
            "Should the 'd Overworld (Hurry Yoshi)' Track Show up on the Gramophone?");
            configEnable16 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "a Athletic?",
            true,
            "Should the 'a Athletic' Track Show up on the Gramophone?");
            configEnable17 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "b Athletic (Yoshi)?",
            true,
            "Should the 'b Athletic (Yoshi)' Track Show up on the Gramophone?");
            configEnable18 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "c Athletic (Hurry)?",
            true,
            "Should the 'c Athletic (Hurry)' Track Show up on the Gramophone?");
            configEnable19 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "d Athletic (Hurry Yoshi)?",
            true,
            "Should the 'd Athletic (Hurry Yoshi)' Track Show up on the Gramophone?");
            configEnable20 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "a Underground?",
            true,
            "Should the 'a Underground' Track Show up on the Gramophone?");
            configEnable21 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "b Underground (Yoshi)?",
            true,
            "Should the 'b Underground (Yoshi)' Track Show up on the Gramophone?");
            configEnable22 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "c Underground (Hurry)?",
            true,
            "Should the 'c Underground (Hurry)' Track Show up on the Gramophone?");
            configEnable23 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "d Underground (Yoshi Hurry)?",
            true,
            "Should the 'd Underground (Yoshi Hurry)' Track Show up on the Gramophone?");
            configEnable24 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "a Swimming?",
            true,
            "Should the 'a Swimming' Track Show up on the Gramophone?");
            configEnable25 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "b Swimming (Yoshi)?",
            true,
            "Should the 'b Swimming (Yoshi)' Track Show up on the Gramophone?");
            configEnable26 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "c Swimming (Hurry)?",
            true,
            "Should the 'c Swimming (Hurry)' Track Show up on the Gramophone?");
            configEnable27 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "d Swimming (Hurry Yoshi)?",
            true,
            "Should the 'd Swimming (Hurry Yoshi)' Track Show up on the Gramophone?");
            configEnable28 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "a Haunted House?",
            true,
            "Should the 'a Haunted House' Track Show up on the Gramophone?");
            configEnable29 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "b Haunted House (Hurry)?",
            true,
            "Should the 'b Haunted House (Hurry)' Track Show up on the Gramophone?");
            configEnable30 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "a Fortress?",
            true,
            "Should the 'a Fortress' Track Show up on the Gramophone?");
            configEnable31 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "b Fortress (Hurry)?",
            true,
            "Should the 'b Fortress (Hurry)' Track Show up on the Gramophone?");
            configEnable32 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "a P-Switch?",
            true,
            "Should the 'a P-Switch' Track Show up on the Gramophone?");
            configEnable33 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "b P-Switch (Cave)?",
            true,
            "Should the 'b P-Switch (Cave)' Track Show up on the Gramophone?");
            configEnable34 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "c P-Switch (Hurry)?",
            true,
            "Should the 'c P-Switch (Hurry)' Track Show up on the Gramophone?");
            configEnable35 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "d P-Switch (Cave Hurry)?",
            true,
            "Should the 'd P-Switch (Cave Hurry)' Track Show up on the Gramophone?");
            configEnable36 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "a Invincible?",
            true,
            "Should the 'a Invincible' Track Show up on the Gramophone?");
            configEnable37 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "b Invincible (Cave)?",
            true,
            "Should the 'b Invincible (Cave)' Track Show up on the Gramophone?");
            configEnable38 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "c Invincible (Hurry)?",
            true,
            "Should the 'c Invincible (Hurry)' Track Show up on the Gramophone?");
            configEnable39 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "d Invincible (Cave Hurry)?",
            true,
            "Should the 'd Invincible (Cave Hurry)' Track Show up on the Gramophone?");
            configEnable40 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "a Bonus Game?",
            true,
            "Should the 'a Bonus Game' Track Show up on the Gramophone?");
            configEnable41 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "b Bonus Game (Hurry)?",
            true,
            "Should the 'b Bonus Game (Hurry)' Track Show up on the Gramophone?");
            configEnable42 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "Bonus Game Clear?",
            true,
            "Should the 'Bonus Game Clear' Track Show up on the Gramophone?");
            configEnable43 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "a Boss Battle?",
            true,
            "Should the 'a Boss Battle' Track Show up on the Gramophone?");
            configEnable44 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "b Boss Battle (Hurry)?",
            true,
            "Should the 'b Boss Battle (Hurry)' Track Show up on the Gramophone?");
            configEnable45 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "Egg is Rescued?",
            true,
            "Should the 'Egg is Rescued' Track Show up on the Gramophone?");
            configEnable46 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "World Clear?",
            true,
            "Should the 'World Clear' Track Show up on the Gramophone?");
            configEnable47 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "Course Clear?",
            true,
            "Should the 'Course Clear' Track Show up on the Gramophone?");
            configEnable48 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "Fade Out!?",
            true,
            "Should the 'Fade Out!' Track Show up on the Gramophone?");
            configEnable49 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "Secret Exit!?",
            true,
            "Should the 'Secret Exit!' Track Show up on the Gramophone?");
            configEnable50 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "Fortress Clear?",
            true,
            "Should the 'Fortress Clear' Track Show up on the Gramophone?");
            configEnable51 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "Player Down?",
            true,
            "Should the 'Player Down' Track Show up on the Gramophone?");
            configEnable52 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "Game Over?",
            true,
            "Should the 'Game Over' Track Show up on the Gramophone?");
            configEnable53 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "a The Evil King Bowser?",
            true,
            "Should the 'a The Evil King Bowser' Track Show up on the Gramophone?");
            configEnable54 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "b The Evil King Bowser (Intro)?",
            true,
            "Should the 'b The Evil King Bowser (Intro)' Track Show up on the Gramophone?");
            configEnable55 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "c Bowsers Last Attack?",
            true,
            "Should the 'c Bowser's Last Attack' Track Show up on the Gramophone?");
            configEnable56 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "d Bowsers Last Attack (Faster)?",
            true,
            "Should the 'd Bowser's Last Attack (Faster)' Track Show up on the Gramophone?");
            configEnable57 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "a Bowser Zoom?",
            true,
            "Should the 'a Bowser Zoom' Track Show up on the Gramophone?");
            configEnable58 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "b Bowser Zoom Out?",
            true,
            "Should the 'b Bowser Zoom Out' Track Show up on the Gramophone?");
            configEnable59 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "Peachs Item?",
            true,
            "Should the 'Peach's Item' Track Show up on the Gramophone?");
            configEnable60 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "Bowser Defeated?",
            true,
            "Should the 'Bowser Defeated' Track Show up on the Gramophone?");
            configEnable61 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "Princess Peach is Rescued?",
            true,
            "Should the 'Princess Peach is Rescued' Track Show up on the Gramophone?");
            configEnable62 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "Staff Roll?",
            true,
            "Should the 'Staff Roll' Track Show up on the Gramophone?");
            configEnable63 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "The Yoshis are Home?",
            true,
            "Should the 'The Yoshis are Home' Track Show up on the Gramophone?");
            configEnable64 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "a Cast List?",
            true,
            "Should the 'a Cast List' Track Show up on the Gramophone?");
            configEnable65 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "b Cast List (Looped)?",
            true,
            "Should the 'b Cast List (Looped)' Track Show up on the Gramophone?");
            configEnable66 = Config.Bind<bool>("Gramopone.Enable.Songs",
            "Yoshi?",
            true,
            "Should the 'Yoshi' Track Show up on the Gramophone?");

            //Music Num
            int MusicAmount = 0;

            // Apply our harmony patches.
            harmony.PatchAll(typeof(Plugin));

            //Summons the music
            if (configEnable1.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "01 Nintendo Logo.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable2.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "02 Title.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable3.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "03 Yoshi's Island.mp3", 0.5f);
                MusicAmount++;
            }
            if (configEnable4.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "04 Wandering the Plains.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable5.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "05 Vanilla Dome.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable6.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "06 Forest of Illusion.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable7.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "07 Bowser's Castle Emerges.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable8.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "08 Valley of Bowser.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable9.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "09 Star Road.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable10.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "10a Special World.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable11.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "10b Super Mario Bros. Remix.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable12.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "11a Overworld.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable13.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "11b Overworld (Yoshi).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable14.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "11c Overworld (Hurry).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable15.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "11d Overworld (Hurry Yoshi).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable16.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "12a Athletic.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable17.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "12b Athletic (Yoshi).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable18.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "12c Athletic (Hurry).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable19.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "12d Athletic (Hurry Yoshi).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable20.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "13a Underground.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable21.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "13b Underground (Yoshi).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable22.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "13c Underground (Hurry).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable23.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "13d Underground (Yoshi Hurry).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable24.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "14a Swimming.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable25.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "14b Swimming (Yoshi).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable26.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "14c Swimming (Hurry).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable27.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "14d Swimming (Hurry Yoshi).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable28.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "15a Haunted House.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable29.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "15b Haunted House (Hurry).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable30.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "16a Fortress.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable31.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "16b Fortress (Hurry).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable32.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "17a P-Switch.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable33.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "17b P-Switch (Cave).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable34.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "17c P-Switch (Hurry).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable35.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "17d P-Switch (Cave Hurry).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable36.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "18a Invincible.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable37.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "18b Invincible (Cave).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable38.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "18c Invincible (Hurry).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable39.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "18d Invincible (Cave Hurry).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable40.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "19a Bonus Game.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable41.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "19b Bonus Game (Hurry).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable42.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "20 Bonus Game Clear.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable43.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "21a Boss Battle.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable44.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "21b Boss Battle (Hurry).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable45.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "22 Egg is Rescued.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable46.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "23 World Clear.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable47.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "24 Course Clear.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable48.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "25 Fade Out!.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable49.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "26 Secret Exit!.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable50.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "27 Fortress Clear.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable51.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "28 Player Down.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable52.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "29 Game Over.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable53.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "30a The Evil King Bowser.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable54.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "30b The Evil King Bowser (Intro).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable55.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "30c Bowser's Last Attack.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable56.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "30d Bowser's Last Attack (Faster).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable57.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "31a Bowser Zoom.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable58.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "31b Bowser Zoom Out.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable59.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "32 Peach's Item.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable60.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "33 Bowser Defeated.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable61.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "34 Princess Peach is Rescued.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable62.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "35 Staff Roll.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable63.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "36 The Yoshis are Home.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable64.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "37a Cast List.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable65.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "37b Cast List (Looped).mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnable66.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "91 Yoshi.mp3", 0.5f);

                MusicAmount++;
            }
            // Was this sucsessful?
            Logger.LogInfo($"Sucsessfully Loaded {MusicAmount} Song(s)");


        }
    }
}
