public class BreakfastService : IBreakfastService
{
    private static Dictionary<Guid, Breakfast> _breakfasts = new Dictionary<Guid, Breakfast>();
    public void CreateBreakfast(Breakfast breakfast)
    {
        _breakfasts.Add(breakfast.Id, breakfast);
    }

    Breakfast IBreakfastService.GetBreakfast(Guid id)
    {
        return _breakfasts[id];
    }
}




