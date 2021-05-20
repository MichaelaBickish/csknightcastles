using kingdom.Repositories;

namespace knights.Services
{
  public class KnightsService
  {
    private readonly KnightsRepository _repo;

    public KnightsService(KnightsRepository repo)
    {
      _repo = repo;
    }
  }
}