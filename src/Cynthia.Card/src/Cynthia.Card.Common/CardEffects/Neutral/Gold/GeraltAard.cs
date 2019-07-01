using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("12021")]//杰洛特：阿尔德法印
	public class GeraltAard : CardEffect
	{//选择3个敌军单位各造成3点伤害，并将它们上移1排。
		public GeraltAard(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}