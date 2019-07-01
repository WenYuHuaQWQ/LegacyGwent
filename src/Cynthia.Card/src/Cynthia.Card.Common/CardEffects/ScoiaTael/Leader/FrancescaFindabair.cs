using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("51001")]//法兰茜丝卡
	public class FrancescaFindabair : CardEffect
	{//选择1张牌进行交换，交换所得的卡牌获得3点增益。
		public FrancescaFindabair(GameCard card) : base(card){}
		public override async Task<int> CardPlayEffect(bool isSpying,bool isReveal)
		{
			return 0;
		}
	}
}