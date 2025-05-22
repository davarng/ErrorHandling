namespace ErrorHandling.Web.Services
{
    public class SlowService
    {

        public static async Task DoSlowWork()
        {

            await Task.Delay(3000);

        }
    }
}
