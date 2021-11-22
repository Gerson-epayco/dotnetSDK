using EpaycoSdk.Models.Plans;
using Microsoft.AspNetCore.Mvc;

namespace epaycoTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : HomeController
    {
        [HttpGet]
        public FindAllPlansModel Get()
        {
            FindAllPlansModel plan = epayco.GetAllPlans();
            return plan;

        }

        [HttpGet("{id_plan}")]
        public FindPlanModel Get(string id_plan)
        {
            FindPlanModel plan = epayco.GetPlan(id_plan);
            return plan;

        }

        [HttpPost]
        public CreatePlanModel Post([FromBody] Models.Plan planData)
        {
            CreatePlanModel plan = epayco.PlanCreate(
                planData.id_plan,
                planData.name,
                planData.description,
                planData.amount,
                planData.currency,
                planData.interval,
                planData.interval_count,
                planData.trial_days
            );

            return plan;

        }

        [HttpDelete("{id_plan}")]
        public RemovePlanModel Delete(string id_plan)
        {
            RemovePlanModel plan = epayco.RemovePlan(id_plan);
            return plan;
        }
    }
}
