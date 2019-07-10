using System.Threading.Tasks;

namespace Bitcoin3
{
	public interface IBlockRepository
	{
		Task<Block> GetBlockAsync(uint256 blockId);
	}
}
