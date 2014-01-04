//using System.Reflection;
//using System.Web.Mvc;

//namespace NGM.Abacus.Controllers {
//    public class InternalFormValueRequiredAttribute : ActionMethodSelectorAttribute
//    {
//        private readonly string _submitButtonName;

//        public InternalFormValueRequiredAttribute(string submitButtonName)
//        {
//            _submitButtonName = submitButtonName;
//        }

//        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
//        {
//            var value = controllerContext.HttpContext.Request.Form[_submitButtonName];
//            return !string.IsNullOrEmpty(value);
//        }
//    }
//}