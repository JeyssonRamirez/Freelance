using System.Web.Mvc;

namespace Presentacion.Mvc.Areas.Abogado
{
    public class AbogadoAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Abogado";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Abogado_default",
                "Abogado/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
