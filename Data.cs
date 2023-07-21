using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCharacterSheet
{
    public partial class Form1 : Form
    {
        public Dictionary<int, string> Grunt_Class_Features = new Dictionary<int, string>
        {
            {0, "In The Zone: \r\nWhenever in combat, you can activate In The Zone. While In The Zone is active, you gain the following ability." +
                "\r\nWet Work: At the start of every turn, you have 6AP that you can only use for offensive actions." +
                "\r\nIn The Zone can remain active up to a number of rounds equal to your level divided by 3 rounded down (minimum 1), You may cancel the ability and save whatever remaining rounds that you may have for later use. " +
                "You replenish all uses at the end of combat." },
            {1, "Run While You Can: \r\nWhenever you end a conversation and you get attacked as a direct result of it, you may make an Intimidate attempt against all " +
                "of the hostile NPCs. Whoever you succeed against becomes Panicked for 1 turn." },
            {2, "Fast Weapon Operation: \r\nYou may draw weapons that are in holsters or on sling at no AP cost. You may also switch firing modes and pull items out of your vest at no AP cost." },
            {3, "Covered: \r\nyou can take full cover for free as if you took an offensive action on your turn." },
            {4, "Lightning Hands: \r\nWhile In The Zone is active, you may reload one weapon for free every turn. Every reload thereafter will have its reload AP cost decreased by 2AP down to a minimum of 1AP." },
            {5, "Operator: \r\nIf In The Zone is active and you score a kill, its duration increases by one round. This can only happen once per turn. Canceling In The Zone will not allow you " +
                "to save rounds given to you by this ability." },
            {6, "Grit: \r\nIf something dealt enough damage to you to cause you to get knocked down, but not go unconscious or killed outright, you instead remain at 1HP and In The Zone will " +
                "immediately activate on your next turn. This In The Zone activation " +
                "does not consume your regular In The Zone turns, but only lasts for 1 turn. This may only activate once per day." },
            };
        public Dictionary<int, string> Grunt_Shocktrooper_Subclass_Features = new Dictionary<int, string>
        {
            {0, "Shockzone: \r\nYou gain an additional In The Zone ability.\r\nRun and Gun: You gain 6AP per turn that you may use for movement." },
            {1, "Hit and Run: \r\nAfter you kill an enemy, you may take any actions after sprinting on that turn." },
            {2, "Booming Start: \r\nOn your first turn of combat, you gain 4AP of movement, and 1 free offensive action." },
            {3, "Throwback: \r\nWhenever you succeed on a Dodge check to avoid taking damage from a thrown grenade (be it HE, Fragmentation, molotov, incendiary, etc.), you take the grenade and throw it 20m in a direction of your choosing, where it will explode as the grenade normally would, but with its save DC increased by 3." },
            {4, "Lightning Reflexes: \r\nIf you get attacked on your turn (eg. from a prepared attack), the enemy has a -10 penalty on the attack." },
            {5, "Twice as Bright, Half as Long: \r\nWhenever you deal a critical hit, you may choose to use a battleart and apply it to that hit instead of increasing the damage. You may pick any battleart from the list, even one you don’t have." },
            {6, "Onslaught: \r\nhen you kill an enemy on your turn, you get 6AP back. Cannot trigger more than once per turn." },
        };
        public string[] base_subclasses = { "Medic", "Squad Leader" };
        public Dictionary<int, string[]> specific_subclases = new Dictionary<int, string[]>{
            {0, new string[] { "Shock Trooper", "Juggernaut" } },
            {1, new string[] { "Demolitions", "Machine Gunner" } },
            {2, new string[] { "Infiltrator", "Scout" } },
            {3, new string[] { "Designated Marksman", "Sniper" } },
        };
        public int[] Feature_Levels = { 1, 4, 7, 9, 13, 17, 19 };
        public int[] Subclass_Feature_Levels = { 3, 5, 8, 11, 18, 20 };
        public Dictionary<int, string> Heavy_Class_Features = new Dictionary<int, string>
        {
            {0, "Havoc: \r\nYou start each turn in combat with a number of Havoc Charges(HC) equal to the current round of combat. HC do not persist between rounds. Multiple havoc abilities can be used at the same time as long as they all meet the requirements. You may not use the same Havoc ability multiple times in a single turn.\r\nBy using your charges you get access to a number of havoc abilities:\r\nLockdown. Spend 1 HC when making a suppression attempt to make it so if the enemy succeeds on their check and leaves cover or stands up until the beginning of your next turn, you can make a free attack against them using the same weapon you used to suppress if you’re still holding it, as long as you have a shot against the enemy. This shot does not use up any extra ammo, as you merely redirect your fire towards the foe.\r\nOverpower. Spend 2 HC when an enemy is forced to make a saving throw against you. The enemy suffers a penalty to it equal to half your level rounded up.\r\nReturn Fire. Spend 2 HC at the end of your turn to prepare to retaliate against an attacking opponent. If you’re attacked before the beginning of your next turn you can make an attack against the attacker using the weapon you’re holding in the selected fire mode.\r\nMow Through. Spend 3 HC when making an attack. If the attack kills the enemy, regain the AP spent on the attack.\r\n" },
            {1, "Intimidating Presence: \r\nIf an ally makes an Intimidate  attempt  in a conversation, but their Intimidation is lower than yours, they may use your intimidation -2. If their intimidation exceeds or matches yours, then the first successful intimidation attempt of a conversation decreases the NPCs CONF by 1 more than usual.\r\n" },
            {2, "Endless Suppression: \r\nYou can carry heavy items requiring two people to carry normally by yourself. Such items include but are not limited to: heavy stationary weaponry, big supply packs and bodies. Both of your hands are occupied until you drop the item.\r\nYour maximum load is also increased by 6 \r\n"},
            {3, "Transporter: \r\nYou can repeat a suppression attempt against the same target on the following turn by using only one full auto attack’s worth of ammo (or 8, if the weapon does not have a fully automatic mode). Otherwise treat it the same way as a normal suppression. \r\n"},
            {4, "Immovable Object: \r\nYou begin each combat with temporary HP equal to your level. Whenever you spend HC, gain temporary HP equal to the number of HC spent. Temporary HP gained from this ability lasts until the end of combat.\r\n"},
            {5, "Unstoppable Force: \r\nGain 1 HC for every time an enemy fails a saving throw caused by you. These HC persist between turns.\r\n"},
            {6, "Panicked Criticals: \r\nAny attack other than your own against an enemy that you suppressed has a +2 to crit range."},
        };
        public Dictionary<int, string> Heavy_MachineGunner_Subclass_Features = new Dictionary<int, string>
        {
            {0, "Lead Curtain: \r\nYou gain access to new havoc abilities.\r\n\r\nMass Suppression. Spend 1 HC when making a suppression attempt to make it so that instead of suppressing one" +
                " enemy you suppress all enemies in a 5 meter radius centered around the target enemy. You may increase the radius by spending additional HC (1HC/1m).\r\nFlush. Spend 2 HC when making a " +
                "full auto attack at an enemy in cover to make them make a resolve check with DC equal to 8 + your level. On a failed check, the enemy is forced to leave cover, moving up to 3 meters in the process. This attack does" +
                " no damage.\r\nRupture: Spend 3 HC when making a full auto attack. If you hit, the target’s AL is decreased by 1, their AT is decreased by 3 and they lose any resistances that they might have had.\r\nKillzone: At the cost of 10AP and 5HC, create a 45° cone of fire that goes up to the end of your maximum range. You may make 1 full auto attack or up to " +
                "6AP worth of semi auto or burst attacks against every enemy who moves, attacks or suppresses in that area. If you hit, the enemy action isn’t performed and the enemy’s AP is wasted. This cone remains in effect until the start of your next turn.\r\n"},
            {1, "Efficient Movement: \r\nWhenever you move for the amount of AP that it would take you to draw your gun, you may draw it. You may also do this while sprinting.\r\n"},
            {2, "Pedal to the Metal: \r\nWhen making a full auto attack you can add a number of shots to your fire rate at the cost of 1AP per shot.\r\n"},
            {3, "Precise Suppression: \r\nThe Steady Weapon action can now be used with Suppression to increase its DC by 2x the number of AP spent on that Steady Weapon action and decrease the number of rounds fired during Suppression equal to the number of AP spent on that Steady Weapon action. \r\n"},
            {4, "Bleed Me Dry: \r\nOnce per combat, when your HP is reduced below half of its maximum value, but doesn't get reduced below 0, you may immediately take 1 Suppress, Throw a Grenade, Perform a Martial Art or Attack action. You may also use Battlearts, Havoc and Lead Curtain abilities with this action and you gain 6HC that can only be used with this specific action.\r\nSelf-inflicted damage does not trigger this ability.\r\n"},
            {5, "Nerves of Steel: \r\nWhen you go below 25% of your maximum health, you gain a +8 bonus to Dodge, Resolve and Resilience in addition to ignoring the penalties of wounds. Both effects last for 2 turns or until you heal above 25% of your maximum health.\r\n"},
            {6, "Chaingunning: \r\nEach time you make a fully automatic attack or a suppression attempt, your critical range with fully automatic fire increases by 2. This increase to critical range is lost when you score a critical hit with fully automatic fire, don’t get an increase from this ability for a turn or the combat ends.\r\n"},
        };
        public Dictionary<int, string> Heavy_Demolitions_Subclass_Features = new Dictionary<int, string>
        {
            {0, "Scortched Earth: \r\nYou gain access to new havoc abilities.\r\nBiggest Booms: Spend 1HC whenever you launch or set off an explosion to increase its radius by 50%.\r\nShow of Force: When launching or setting off an explosive, spend 2 HC to make a suppression attempt with DC equal to 10 + your level against all affected targets.\r\nSmell the Napalm: Spend 3 HC whenever you launch or set off a debilitating explosive: incendiary, flashbang or similar. Affected targets spend one additional round affected by the condition caused by the explosive, even if they succeed on their save.\r\nShredding Shrapnel: Spend 5HC whenever you launch or set off an explosion to make it apply a heavy wound to everyone in the radius.\r\n"},
            {1, "Explosive Personality: \r\nEvery time that an NPC makes a statement and you don’t respond to it, you gain a +2 bonus to your next check in the conversation. The bonus is lost when the conversation ends or you make a check. \r\n"},
            {2, "Primed and Ready: \r\nYou can either pull out a hand grenade or pull out and load a single grenade into a grenade launcher at no AP cost if you throw or launch it right away afterwards.\r\nYou gain a +6 on Science and Engineering checks when handling or crafting explosives.\r\n"},
            {3, "Timing: \r\nYou may add ½ your level to the DC of your explosives. Damaging throwables/grenades/rockets do 3d6 additional damage in the first half of their radius."},
            {4, "Shred: \r\nExplosives decrease the AL of targets that they dealt damage to by 2. "},
            {5, "Salvo: \r\nYou may throw/launch one explosive per turn for free."},
            {6, "Mayhem: \r\nOnce per turn, when you kill an enemy with a throwable/grenade/rocket, you may replenish the AP that was necessary to throw/launch the explosive at the cost of 2HC."},
        };
        public Dictionary<int, string> Grunt_Juggernaut_Subclass_Features = new Dictionary<int, string>
        {
            {0, "Will To Survive: \r\nYou gain an additional In The Zone ability.\r\nSteadfast: You are immune to suppression and the exhausted, tired, berserked and terrified effects." },
            {1, "Self-Defense: \r\nWhenever someone uses a martial art against you and fails, you may attempt to use the same martial art against them. Additionally, once per round, whenever someone closes within melee range of you, you may attempt to make a bash attack against them, which, on a hit, knocks the target prone. " },
            {2, "Combat Survival: \r\nYou gain a bonus to Dodge, Resolve and Resilience equal to your AL."},
            {3, "Pushing through the Thunder: \r\nYour wound thresholds increase by 10."},
            {4, "Second Wind: \r\nWhen you get knocked down, you may decide to go into a Second Wind instead. While in second wind, you may partake in your turns as normal, other than the fact that you are prone and cannot stand up. You may stay in second wind for a number of turns equal to twice your Willpower score, but taking damage decreases the number of turns left by 2. \r\nOnce per combat, if you get a kill while in Second Wind, you go back to your regular state, as if you were helped up by an ally.\r\n"},
            {5, "Templar: \r\nWhen you take damage, but you don’t get knocked down or die outright, you may convert ½ the damage taken into temporary HP that lasts for 2 turns. \r\nThis ability may only be used once per combat\r\n"},
            {6, "Legacy of Benavidez: \r\nYou ignore the first critical hit of every round, turning it into a normal hit, you also get a free reaction attack against the enemy that fired the ignored critical shot.\r\n"},
        };
        public Dictionary<int, string> Sharpshooter_Class_Features = new Dictionary<int, string>
        {
            {0, "Eyes on the Prize: \r\nAt the start of your first turn of combat you can mark one enemy you can see, you have a +5 bonus to accuracy against this enemy. You can switch the target of this ability at the cost of 4AP or for free right after you kill the marked enemy. This enemy also gains a special “Marked” condition, which is necessary for some of the following abilities to work." },
            {1, "Subtle Signs: \r\nOnce per conversation, you may make one skill check, but count it as two different ways of convincing (out of lying, intimidation or persuasion). The BM will say which one of the two ways of convincing seemed to be more effective. Using this ability also lowers the NPCs Lie, Persuade and Intimidate DCs by 2 until their CONF is decreased by at least 1." },
            {2, "Trusty Sidearm: \r\nYou can pull out a close quarters firearm or a one-handed melee weapon and make an attack with it for free, as long as it is on a sling or in a holster. You can use this ability once per combat. (A close quarters firearm is any firearm that has a CQB handling of at least 1)"},
            {3, "Snapshot: \r\nOnce per turn, you may make a snapshot attack, which costs ½ (rounded down) of the AP cost to fire, but it has a -5 penalty to accuracy on sniper rifles. Can only be used with guns fired in semi-automatic mode."},
            {4, "Beholder: \r\nYou ignore Tired, Hungry and Thirsty conditions and effects of wounds (other than bleeding) if you haven’t moved in the last minute."},
            {5, "Persistent Precision: \r\nYour critical range increases by 1 with any firearm that is set to semi-automatic mode."},
            {6, "A Bullet With Your Name On It: \r\nWhen this ability is activated, your next shot with a weapon set to semi automatic mode against a marked target cannot miss and will cause the target to become Panicked, Terrified or Berserked (your choice). If the target dies, their next closest ally will have your chosen penalty applied instead. This ability can only be activated twice per combat, but only once per enemy. This condition lasts until the end of combat."},
        };
        public Dictionary<int, string> Sharpshooter_Sniper_Sublass_Features = new Dictionary<int, string>
        {
            {0, "Dead Certainty: \r\nYour first semi-automatic shot of the turn that doesn’t have any penalties to accuracy (excluding penalties imposed by the used weapon itself) deals maxed out damage against your marked target. " },
            {1, "Silver Tongue: \r\nWhenever a conversation starts, you may decrease the NPCs Lie, Intimidate or Persuade DC by your level divided by 5, rounded up. This penalty lasts for the entire conversation." },
            {2, "Low Profile: \r\nWhen an enemy at least 75 meters away from you aims to shoot you, your half cover is considered ¾ cover."},
            {3, "All Senses on the Prize: \r\nYou may switch your marked enemy for free once per turn, alternatively, if you do not have a marked enemy, you may mark an enemy for free."},
            {4, "Farsight: \r\nWhen using magnified optics, increase the range gained from the scope by half. You have a +4 bonus on Perception checks made through scopes and oculars.\r\nNote: Your effective range cannot exceed the weapon’s maximum range. The BM may choose to not allow you to use a scope to gain a bonus on a check if it doesn’t make sense (eg. the object you are trying to inspect is close enough as it is)\r\n"},
            {5, "And Stay Down!: \r\nWhen an enemy marked by Eyes on the Prize moves or attacks on their turn, you can make a single attack at them as long as you can see them. You can use this ability only once per each individual enemy every combat."},
            {6, "Serial Killer: \r\nWhenever you kill an enemy with a weapon set to semi automatic mode, the AP that was needed to fire the killing shot will be refunded. This can happen no more than 1 time per turn."},
        };
        public Dictionary<int, string> Sharpshooter_Designated_Marksman_Sublass_Features = new Dictionary<int, string>
        {
            {0, "Marksmanship: \r\nYou gain a +1 to your critical hit range and +5 to your critical hit damage (after doubling) against targets that are marked with Eyes on the Prize." },
            {1, "Social Studies: \r\nWhenever talking to an NPC, you can tell if their patience level is above or below 5." },
            {2, "Skirmisher: \r\nThe last enemy you shoot on your turn has a -4 penalty to accuracy on all of their attacks until the beginning of your next turn."},
            {3, "Outdoorsman: \r\nYou can use your Survival bonus in place of Stealth when hiding using camouflage. Your Stealth check bonus from having appropriate camouflage is doubled. "},
            {4, "Collective Marksmanship: \r\nYou may mark an additional target. Shots made by your allies against marked targets gain a +2 bonus to accuracy and a +2 bonus to critical damage."},
            {5, "Shadowshot: \r\nWhen you break concealment via attacking, at the end of your turn you can attempt to re-enter concealment by making a hide action at no AP cost. You get a -5 penalty on the check for every time this ability is used in combat."},
            {6, "Reactionary: \r\nWhenever you prepare semi-automatic shots, instead of specifying the area and amount of shots, you may simply “reserve” shots to fire off at will, whenever an opportunity arises, as if you were firing normally,  until the beginning of your next turn. In addition whenever multiple prepared shots, including yours,  are resolved at the same time, you can choose to make your shots first. You do not break concealment when you make shots this way."},
        };
        public Dictionary<int, string> Guerilla_Class_Features = new Dictionary<int, string>
        {
            {0, "Unseen Strike: \r\nOnce per turn when you make an attack you can deal extra damage equal to (your level + your 2x physical or 2x mental)/2 to any enemy that isn’t aware of your position, wasn’t suspecting an attack from you at the beginning of your turn or as long as you are concealed. This damage does not have a type, as such it cannot be modified in any way. A critical hit does not double the damage of Unseen Strike." },
            {1, "Speech Aficionado: \r\nWhenever you open a conversation with an NPC, the BM decides on a skill that, if used on a Persuade, Lie or Intimidate attempt, will decrease the enemy’s confidence by 5. You are not made aware of the exact skill. " },
            {2, "Guerilla Basics: \r\nIf you move to a different position at least 5 meters away on your turn without being seen or heard, you are considered concealed. Moving silently does not require a check for the purposes of this ability."},
            {3, "Takedown: \r\nWhenever you meet the requirements for Unseen Strike, you may make that attack into a Takedown. Takedowns apply additional effects, but cost a takedown charge. You have a number of takedown charges equal to your level divided by 4, rounded down.\r\nCritical Takedown: You cause a miniature critical hit. You cause a random light wound and one of your damage dice is maximized.\t\r\nGrenade Takedown: When you strike an enemy with a melee weapon, you may ask the BM if there is a visible grenade on the enemy’s body. If there is, you may pull the pin. The grenade will explode at the end of your turn. The explosion radius is halved for you. The enemy has a -5 on their Dodge check against this grenade.\r\nFlying Takedown: Whenever you attack someone with a melee weapon by jumping at them from an elevated position, you automatically score a critical hit.\r\nBackstab: When you strike someone from the back (regardless of whether or not it was with a melee weapon), the enemy gets medium bleeding and they take an additional 10 damage from that Unseen Strike.\r\nStunning Shot: Your attack stuns the enemy. If they fail a Resilience check (DC = 12 + Your Level).\r\n"},
            {4, "Silent Killer: \r\nWhen you use takedown with a silenced weapon or a silent melee weapon such as a knife and kill the enemy, you do not break your concealment."},
            {5, "Swift Strike: \r\nWhenever you apply Unseen Strike, your movement speed is increased by 1m/AP until the end of your turn."},
            {6, "Unseen Assasin: \r\nIf you use Unseen Strike against an enemy unseen by any of their allies or if their vision of them is obstructed (ie: by darkness or smoke), your Unseen Strike applies a Takedown of your choice without expending a charge."},
        };
        public Dictionary<int, string> Guerilla_Scout_Sublass_Features = new Dictionary<int, string>
        {
            {0, "Spotter: \r\nOnce per turn when you attack an enemy, you can mark them. The next allied attack made against them is made with +4 to accuracy." },
            {1, "Explorer: \r\nWhenever you’re traveling, you remember the path that you took and can spend 1 hour to note it down on any map, regardless of which role you fulfilled while traveling. You may also navigate in familiar terrain without the need to make a Survival check and as a part of any other role." },
            {2, "Both Flanks: \r\nUnseen strike works on any and all exposed enemies."},
            {3, "Specter: \r\nYou have a number of Specter meters equal to three times your level. Whenever you take the move or sprint action, you may make the movement into Specter movement, subtracting a number of meters from your Specter meters equal to the number of meters that you moved. During Specter movement, you cannot be spotted by enemies who haven’t spotted you already, you gain a +10 bonus to Stealth and you move at 1m/AP faster than usual. "},
            {4, "Deft Reflexes: \r\nYou can never be surprised. Once per combat round when an enemy makes an attack against you, you can choose to give them a -10 on the roll. You may do this even after they hit you, but before they take any other actions. "},
            {5, "Combat Alacrity: \r\nWhen you move for a number of AP required for a reload, you may reload for free. When you attack with your weapon, you may move a number of meters equal to the AP expended for free."},
            {6, "Dread Ambusher: \r\nAs long as you meet the criteria for Unseen Strike, using Takedown against enemies doesn’t cost a Takedown charge."},
        };
        public Dictionary<int, string> Guerilla_Infiltrator_Sublass_Features = new Dictionary<int, string>
        {
            {0, "Ghost: \r\nYou may enter a “Ghost” state while concealed. While it is active, you don’t need to make stealth checks in order to move silently and moving while sneaking no longer slows you down. In addition, killing shots on enemies also do not break your concealment and neither do melee attacks (the attacked individual will still notice you).\r\nYou may stay in ghost for a number of turns equal to your level/2 (rouded up)  per day.\r\n" },
            {1, "Investigator: \r\nWhenever you’re attempting to convince an NPC to give you information that they are withholding, every successful Persuade, Lie or Intimidate attempt decreases their CONF by double the usual amount. " },
            {2, "Saboteur: \r\nWhile concealed, explosives that are used by you have a +5 to their save DC. Throwing or launching an explosive will also not reveal you when you’re concealed."},
            {3, "The Poison Bullet: \r\nToxins that are coating your bullets and melee weapons always deal maximum damage as long as you are concealed."},
            {4, "Plan B: \r\nWhenever your concealment is broken, you gain a free 10AP worth of movement, even outside of your turn, but not during an enemy turn. (the movement is executed as if you were on the next spot in initiative) \r\nYou may use this ability once per combat.\r\n"},
            {5, "Unaware Targeting: \r\nWhenever you make an attack while concealed, you treat the enemy’s AL as if it were 0."},
            {6, "Rehearsed Assassination: \r\nOnce per combat if you meet the prerequisites for Unseen Assassin and use a Takedown charge, you can choose to kill your enemy as long as the enemy has an exposed vital organ."},
        };
        public Dictionary<int, string> Universal_Medic_Sublass_Features = new Dictionary<int, string>
        {
            {0, "Combat Medicine: \r\nUsing any medical item costs 2 less AP, down to a minimum of 1 AP. You can add your medicine skill to the amount of HP restored when using a medical item that restores HP. You can also pick up and carry a body at no AP cost and carrying a body in combat does not slow you down. Additionally, you may still climb ladders while carrying a body." },
            {1, "Emergency Care: \r\nYou may wake stable unconscious allies up with the use of 4AP.  As long as you have a doctor’s bag, you may stabilize an unconscious ally with 6AP, even if they are bleeding or ablaze. If these conditions are present, then they are also removed. " },
            {2, "Proper Dosage: \r\nYour allies cannot get addicted to drugs that are administered by you, additionally, they last twice as long."},
            {3, "Red Cross: \r\nAs long as you don’t take any offensive actions during your turn, your AT is increased by 6 until the start of your next turn."},
            {4, "Field Surgery: \r\nAs long as you have a Doctor’s Bag, you can spend 1 hour tending to a medium or a heavy wound to treat it."},
            {5, "Applied Physiology: \r\nWhenever you cause a wound, you may choose the specific wound of the same level, instead of deciding it randomly. Your critical range increases by 1 against enemies who have taken a wound."},
            {6, "Checkups: \r\nDuring a period of sleep, you can assess the physical condition of your squad, administering aid when needed. As long as you have a Doctor’s bag, all members of your squad regain 4d6 HP. Any restored HP that exceeds their maximum becomes temporary HP instead. Temporary HP from this ability lasts for the following day."},
        };
        public Dictionary<int, string> Universal_Squad_Leader_Sublass_Features = new Dictionary<int, string>
        {
            {0, "Squad Tactics: \r\nOn their turn, you can use your action points to shout commands at your squad members to let them execute additional maneuvers.\r\nShouting any commands requires Tactics Points (TP). You have an amount of TP equal to your Mental + your level. You regain your TP after combat ends.\r\nTake cover. Use 1AP and 1TP to let one of your allies take cover within 5 meters of them.\r\nMove. Use 2AP and 1TP to let one of your allies move up to 7AP worth of movement.\r\nAdvance. Use 6AP and 2TP to let all of your squad members move out of cover and sprint up to 3AP worth of movement and go into full cover.\r\nTactical Reload. Use 6AP and 2TP to let all of your allies fully reload their guns that they are holding.\r\nHeads Down. Use 3AP and 2TP to let everyone in your squad take full cover if they are in ½ cover.\r\nHeads Up. Use 2AP and 1TP to give everyone in your squad a +5 bonus to Dodge, Resolve and Resilience until the start of your next turn.\r\nRestrain. Use 3AP and 3TP to have an ally restrain an opponent within melee range.\r\nNote: Teammates who move due to a command cannot sprint during the command unless stated otherwise.\r\n" },
            {1, "Critical Thinking: \r\nYour and your squad’s bonus for using a skill other than Intimidation, Barter or Speechcraft during a conversation is doubled." },
            {2, "Morale Breaker:\r\nWhenever your or an ally takes an offensive action against an enemy, you may spend 3TP to make the enemy make a DC10 + 2x your Social + your Intimidation Resolve check, on a fail, the enemy becomes Panicked, Terrified or Breserked (your choice). Additionally, whenever an ally becomes Panicked, Berserked or Terrified, you may spend 6TP to end the effect."},
            {3, "Tip the Balance: \r\nYou regain 1TP whenever an enemy dies on the battlefield up to your regular maximum."},
            {4, "Traveler: \r\nWhile traveling, you move faster (Careful Travel: 3 km/h. March: 8 km/h. Jog: 12 km/h.)"},
            {5, "United We Stand: \r\nAs long as every squad member is within 40 meters of each other and all of them are conscious, they all gain a +3 bonus to all of their combat skills (not weapon skills). \r\nSharpshooters do not have to be within 40 meters, but they must still be actively engaging in the fight.\r\n"},
            {6, "Hold on, Brother: \r\nAs long as a knocked down ally can hear you, you can shout at them to bring them back up to 1HP at the cost of 3AP. Allies in a last stand (or another similar ability that replaces being knocked down) do not count. You can only use this perk once per individual ally per day. "},
        };
    }
}
