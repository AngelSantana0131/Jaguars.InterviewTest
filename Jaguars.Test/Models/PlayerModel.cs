using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jaguars.Test.Models
{
	public class PlayerModel
	{
		/*
		 
		 */

		public string FullNameFormal { get; set; }

		public string Jersey { get; set; }

		// this is not the real player birthdate.  This is randomly generated
		public Nullable<System.DateTime> DOB { get; set; }

		public string HeadshotUrl { get; set; }

		public string SchoolCode { get; set; }

		public string ClubCode { get; set; }
		public string ClubName { get; set; }

		public Nullable<short> YearDraft { get; set; }

		// height is in the format FII8, where F is feet, I is inches and 8 is 1/8th of an inch.  5112 is 5'11" and 1/4
		public Nullable<short> Height { get; set; }

		public Nullable<short> Weight { get; set; }

		public Nullable<short> Hands { get; set; }
		public Nullable<short> Arms { get; set; }

		public Nullable<decimal> Speed { get; set; }

		// primary key
		public int PlayerId { get; set; }

		// Pro Club ID
		public Nullable<int> ClubId { get; set; }

		// College Club ID
		public Nullable<int> CollegeClubId { get; set; }

		public string PositionAbbrev { get; set; }

		public string PositionTypeAbbrev { get; set; }

		//Grades Are 1.0 to 9.0 (including 7.5 etc) but are stored as a short, so its necessary to divide by 10 to see the display grade
		public short LatestGrade { get; set; }

		public Nullable<bool> SpecialTeams { get; set; }

		public Nullable<bool> PuntReturner { get; set; }

		public Nullable<bool> KickReturner { get; set; }

		public string FavoriteIceCream { get; set; }

		public Nullable<bool> CanDunkBasketball { get; set; }

		public Nullable<bool> LikesIceCream { get; set; }

		public Nullable<bool> HasHotMom { get; set; }

		public string OtherThingsLikesToEat { get; set; }

		public Nullable<bool> InvitedToCombine { get; set; }

		public string RandomInfo { get; set; }

		public Nullable<bool> OnlyGmKnowsWhatThisMeans { get; set; }

		public Nullable<bool> PlayerIsTooSmart { get; set; }

		public Nullable<bool> IsScientologist { get; set; }

		public Nullable<bool> EatsBoogers { get; set; }

		public string WhoCaresWhatThisIs { get; set; }

		public Nullable<decimal> Arrests { get; set; }

		public Nullable<bool> IsFromNewJersey { get; set; }

		public Nullable<short> GradeVoicePitch { get; set; }

		public Nullable<short> GradeMiddleFingerLength { get; set; }

		public Nullable<short> GradeHair { get; set; }

		public Nullable<short> GradeFingerNails { get; set; }

		public Nullable<int> GamesPlayed { get; set; }
		public bool Inactive { get; set; }
		public bool Injured { get; set; }
		public Nullable<int> BenchPress { get; set; }
		public Nullable<int> VertJump { get; set; }
		public Nullable<int> BroadJump { get; set; }
		public Nullable<double> TwentyShuttle { get; set; }
		public Nullable<double> SixtyShuttle { get; set; }
		public Nullable<double> ThreeCone { get; set; }
		public short SPD { get; set; }
		public short ACC { get; set; }
		public short STR { get; set; }
		public short AGI { get; set; }
		public short AWR { get; set; }
		public short STA { get; set; }
		public short INJ { get; set; }
		public int FortniteSoloWins { get; set; }
		public int FortniteDuoWins { get; set; }
		public int FortniteTrioWins { get; set; }
		public int FortniteSquadsWins { get; set; }

		public PlayerModel()
		{

		}
	}
}