
using System.Text.RegularExpressions;

namespace refreashOnCsharp.CustomConstraints
{
    public class MonthsCustomConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (!values.ContainsKey(routeKey))
            {
                return false;
            }

            Regex regex = new("^(apr|jul|oct|jan)$");
            string? monthValue = Convert.ToString(values[routeKey]);
            if (regex.IsMatch(monthValue))
            {
                return true;
            }
            return false;
        }
    }
}