using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("44017")]//弩炮
	public class Ballista : CardEffect
	{//对1个敌军单位和最多4个与它战力相同的其他敌军单位造成1点伤害。 驱动：再次触发此能力。
		public Ballista(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}