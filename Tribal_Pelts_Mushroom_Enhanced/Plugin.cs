using BepInEx;
using DiskCardGame;
using HarmonyLib;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;
using InscryptionAPI.Pelts;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace ExampleMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("tribes.libary", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        // --------------------------------------------------------------------------------------------------------------------------------------------------

        // Declare Harmony here for future Harmony patches. You'll use Harmony to patch the game's code outside of the scope of the API.
        Harmony harmony = new Harmony(PluginGuid);

        // These are variables that exist everywhere in the entire class.
        private const string PluginGuid = "creator.MushroomPelts";
        private const string PluginName = "MushroomPelts";
        private const string PluginVersion = "1.0.0";
        private const string PluginPrefix = "MushroomPelts";

        // For some things, like challenge icons, we need to add the art now instead of later.
        // We initialize the list here, in Awake() we'll add the sprites themselves.
        public static List<Sprite> art_sprites;
        // This is where you would run all of your other methods.
        private void Awake()
        {
            // Apply our harmony patches.
            int i = 0;
            harmony.PatchAll(typeof(Plugin));
            BlasterPelt();
            BlockPelt();
            BlooperPelt();
            BobOmbPelt();
            BooPelt();
            BronzePortrait();
            ChainChompPelt();
            CheepCheepPelt();
            ConkdorPelt();
            DragonPelt();
            DryBonesPelt();
            GoldPortrait();
            GoombaPelt();
            KoopaPelt();
            PiranhaPelt();
            PokeyPelt();
            PowerUpPelt();
            RamPelt();
            ShroobPelt();
            ShyGuyPelt();
            SilverPortrait();
            StarPelt();
            SpikePelt();
            TanukiPelt();
            ThwompPelt();
            WaddlewingPelt();
            WigglerPelt();
            PowerMoon();
            StarBits();
            ShineSprite();

            static CardInfo CreateCard(string displayName, string imagePath, string imagePathEmisive, int attack, int health, Tribe tribe)
            {
                CardInfo info = CardManager.New(Plugin.PluginGuid, displayName, displayName, attack, health);
                info.SetPortrait(TextureHelper.GetImageAsTexture(Path.Combine(imagePath)));
                info.SetEmissivePortrait(TextureHelper.GetImageAsTexture(Path.Combine(imagePathEmisive)));
                info.cardComplexity = CardComplexity.Simple;
                info.AddTraits(Trait.Pelt);
                if (tribe != Tribe.None) info.AddTribes(tribe);
                info.temple = CardTemple.Nature;
                info.AddSpecialAbilities(SpecialTriggeredAbility.SpawnLice);
                info.AddAppearances(CardAppearanceBehaviour.Appearance.TerrainBackground, CardAppearanceBehaviour.Appearance.TerrainLayout);

                return info;
            }
            static CardInfo CreateRareCard(string displayName, string imagePath, string imagePathEmisive, int attack, int health, Tribe tribe)
            {
                CardInfo info = CreateCard(displayName, imagePath, imagePathEmisive, attack, health, Tribe.None);
                info.AddAppearances(CardAppearanceBehaviour.Appearance.GoldEmission);

                return info;
            }

            static void BlasterPelt()
            {
                CardInfo info = CreateCard("Blaster Pelt", "Blaster Pelt.png", "Blaster Pelt_e.png", 0, 2, TribalLibary.Plugin.blasterTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.blasterTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void BlockPelt()
            {
                CardInfo info = CreateCard("Block Pelt", "Block Pelt.png", "Block Pelt_e.png", 0, 2, TribalLibary.Plugin.blockTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.blockTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void BlooperPelt()
            {
                CardInfo info = CreateCard("Blooper Pelt", "Blooper Pelt.png", "Blooper Pelt_e.png", 0, 2, TribalLibary.Plugin.blooperTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.blooperTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void BobOmbPelt()
            {
                CardInfo info = CreateCard("Bob-Omb Pelt", "Bob-Omb Pelt.png", "Bob-Omb Pelt_e.png", 0, 2, TribalLibary.Plugin.bombombTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.bombombTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void BooPelt()
            {
                CardInfo info = CreateCard("Boo Pelt", "Boo Pelt.png", "Boo Pelt_e.png", 0, 2, TribalLibary.Plugin.booTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.booTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void BronzePortrait()
            {
                CardInfo info = CreateCard("Bronze Portrait", "Bronze Portrait.png", "Bronze Portrait_e.png", 0, 2, Tribe.None);

                PeltManager.New(Plugin.PluginGuid, info, 3, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.ModPrefixIs("Gallery") && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void ChainChompPelt()
            {
                CardInfo info = CreateCard("Chain Chomp Pelt", "Chain Chomp Pelt.png", "Chain Chomp Pelt_e.png", 0, 2, TribalLibary.Plugin.chompTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.chompTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void CheepCheepPelt()
            {
                CardInfo info = CreateCard("Cheep-Cheep Pelt", "Cheep-Cheep Pelt.png", "Cheep-Cheep Pelt_e.png", 0, 2, TribalLibary.Plugin.cheepCheepTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.cheepCheepTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void ConkdorPelt()
            {
                CardInfo info = CreateCard("Conkdor Pelt", "Conkdor Pelt.png", "Conkdor Pelt_e.png", 0, 2, TribalLibary.Plugin.mbirdTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.mbirdTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void DragonPelt()
            {
                CardInfo info = CreateCard("Dragon Pelt", "Dragon Pelt.png", "Dragon Pelt_e.png", 0, 2, TribalLibary.Plugin.mreptileTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.mreptileTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void DryBonesPelt()
            {
                CardInfo info = CreateCard("Dry Bones Pelt", "Dry Bones Pelt.png", "Dry Bones Pelt_e.png", 0, 2, TribalLibary.Plugin.mskeletonTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.mskeletonTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void GoldPortrait()
            {
                CardInfo info = CreateRareCard("Gold Portrait", "Gold Portrait.png", "Gold Portrait_e.png", 0, 2, Tribe.None);

                PeltManager.New(Plugin.PluginGuid, info, 11, 0, 4,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.ModPrefixIs("Gallery") && a.HasAnyOfCardMetaCategories(CardMetaCategory.Rare));
                    }
                );
            }
            i++;
            static void GoombaPelt()
            {
                CardInfo info = CreateCard("Goomba Pelt", "Goomba Pelt.png", "Goomba Pelt_e.png", 0, 2, TribalLibary.Plugin.goombaTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.goombaTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void KoopaPelt()
            {
                CardInfo info = CreateCard("Koopa Pelt", "Koopa Pelt.png", "Koopa Pelt_e.png", 0, 2, TribalLibary.Plugin.koopaTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.koopaTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void PiranhaPelt()
            {
                CardInfo info = CreateCard("Piranha Plant Pelt", "Piranha Pelt.png", "Piranha Pelt_e.png", 0, 2, TribalLibary.Plugin.piranhaPlantTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.piranhaPlantTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void PokeyPelt()
            {
                CardInfo info = CreateCard("Pokey Pelt", "Pokey Pelt.png", "Pokey Pelt_e.png", 0, 2, TribalLibary.Plugin.pokeyTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.pokeyTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void PowerUpPelt()
            {
                CardInfo info = CreateCard("Power-Up Pelt", "Power-Up Pelt.png", "Power-Up Pelt_e.png", 0, 2, TribalLibary.Plugin.powerUpTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.powerUpTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void RamPelt()
            {
                CardInfo info = CreateCard("Ram Pelt", "Ram Pelt.png", "Ram Pelt_e.png", 0, 2, TribalLibary.Plugin.mhoovedTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.mhoovedTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void ShroobPelt()
            {
                CardInfo info = CreateCard("Shroob Pelt", "Shroob Pelt.png", "Shroob Pelt_e.png", 0, 2, TribalLibary.Plugin.shroobTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.shroobTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void ShyGuyPelt()
            {
                CardInfo info = CreateCard("Shy Guy Pelt", "Shy Guy Pelt.png", "Shy Guy Pelt_e.png", 0, 2, TribalLibary.Plugin.shyGuyTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.shyGuyTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void SilverPortrait()
            {
                CardInfo info = CreateCard("Silver Portrait", "Silver Portrait.png", "Silver Portrait_e.png", 0, 2, Tribe.None);

                PeltManager.New(Plugin.PluginGuid, info, 7, 1, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.ModPrefixIs("Gallery") && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void SpikePelt()
            {
                CardInfo info = CreateCard("Spike Pelt", "Spike Pelt.png", "Spike Pelt_e.png", 0, 2, TribalLibary.Plugin.spikeTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.spikeTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void StarPelt()
            {
                CardInfo info = CreateCard("Star Pelt", "Star Pelt.png", "Star Pelt_e.png", 0, 2, TribalLibary.Plugin.starTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.starTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void TanukiPelt()
            {
                CardInfo info = CreateCard("Tanuki Pelt", "Tanuki Pelt.png", "Tanuki Pelt_e.png", 0, 2, Tribe.None);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.name.Contains("Takuni") && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void ThwompPelt()
            {
                CardInfo info = CreateCard("Thwomp Pelt", "Thwomp Pelt.png", "Thwomp Pelt_e.png", 0, 2, TribalLibary.Plugin.crusherTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.crusherTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void WaddlewingPelt()
            {
                CardInfo info = CreateCard("Waddlewing Pelt", "Waddlewing Pelt.png", "Waddlewing Pelt_e.png", 0, 2, TribalLibary.Plugin.rodentTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.rodentTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void WigglerPelt()
            {
                CardInfo info = CreateCard("Wiggler Pelt", "Wiggler Pelt.png", "Wiggler Pelt_e.png", 0, 2, TribalLibary.Plugin.minsectTribe);

                PeltManager.New(Plugin.PluginGuid, info, 5, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.IsOfTribe(TribalLibary.Plugin.minsectTribe) && (a.ModPrefixIs("Mushroom") || a.ModPrefixIs("Gallery")) && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void PowerMoon()
            {
                CardInfo info = CreateCard("Power Moon", "Power Moon.png", "Power Moon_e.png", 0, 2, Tribe.None);

                PeltManager.New(Plugin.PluginGuid, info, 7, 1, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.ModPrefixIs("Mushroom") && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void StarBits()
            {
                CardInfo info = CreateCard("Star Bits", "Star Bits.png", "Star Bits_e.png", 0, 2, Tribe.None);

                PeltManager.New(Plugin.PluginGuid, info, 3, 0, 8,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.ModPrefixIs("Mushroom") && a.HasAnyOfCardMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer));
                    }
                );
            }
            i++;
            static void ShineSprite()
            {
                CardInfo info = CreateCard("Shine Sprite", "Shine Sprite.png", "Shine Sprite_e.png", 0, 2, Tribe.None);

                PeltManager.New(Plugin.PluginGuid, info, 11, 0, 4,
                    () =>
                    {
                        return CardManager.AllCardsCopy.FindAll((a) =>
                        a.ModPrefixIs("Mushroom") && a.HasAnyOfCardMetaCategories(CardMetaCategory.Rare));
                    }
                );
            }
            i++;
            Logger.LogInfo($"Sucsessfully Loaded {i} Pelt(s)!");
        }
    }
}