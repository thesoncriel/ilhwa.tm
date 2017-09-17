/*
 * Created by SharpDevelop.
 * User: JHSON
 * Date: 2012-10-04
 * Time: 오전 11:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Theson.Util
{
	/// <summary>
	/// AppVersion 및 BuildDate 출처: http://www.enjoydev.com/xe/989
	/// </summary>
	public class Util
	{
		
		
		/// <summary>
        /// 파일의 (제품)버전을 구한다.
        /// </summary>
        /// <returns>파일 (제품)버전</returns>
        static public string AppVersion
        {
            get
            {
                return System.Windows.Forms.Application.ProductVersion;
            }
        }
 
        /// <summary>
        /// 컴파일한 날짜를 구한다.
        ///   단, AssemblyInfo.cs 파일에서 AssemblyVersion는 다음 형식으로 되어있어야만한다.
        ///   [assembly: AssemblyVersion("1.0.*")]
        /// </summary>
        /// <returns>컴파일한 날짜</returns>
        static public DateTime BuildDate
        {
            get
            {
                System.Version assemblyVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                // assemblyVersion.Build = days after 2000-01-01
                // assemblyVersion.Revision*2 = seconds after 0-hour  (NEVER daylight saving time) 
                DateTime buildDate = new DateTime(2000, 1, 1).AddDays(assemblyVersion.Build).AddSeconds(assemblyVersion.Revision * 2);
 
                return buildDate;
            }
        }
	}
}
