﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAPNet.Tests {
    using System;
    
    
    /// <summary>
    ///   Klasa zasobu wymagająca zdefiniowania typu do wyszukiwania zlokalizowanych ciągów itd.
    /// </summary>
    // Ta klasa została automatycznie wygenerowana za pomocą klasy StronglyTypedResourceBuilder
    // przez narzędzie, takie jak ResGen lub Visual Studio.
    // Aby dodać lub usunąć składową, edytuj plik ResX, a następnie ponownie uruchom narzędzie ResGen
    // z opcją /str lub ponownie utwórz projekt VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Xml {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Xml() {
        }
        
        /// <summary>
        /// Zwraca buforowane wystąpienie ResourceManager używane przez tę klasę.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CAPNet.Tests.Xml", typeof(Xml).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Przesłania właściwość CurrentUICulture bieżącego wątku dla wszystkich
        ///   przypadków przeszukiwania zasobów za pomocą tej klasy zasobów wymagającej zdefiniowania typu.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;alert xmlns=&quot;urn:oasis:names:tc:emergency:cap:1.2&quot;&gt;
        ///  &lt;identifier&gt;43b080713727&lt;/identifier&gt;
        ///  &lt;sender&gt;hsas@dhs.gov&lt;/sender&gt;
        ///  &lt;sent&gt;2003-04-02T14:39:01-05:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;source&gt;source&lt;/source&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;restriction&gt;restriction&lt;/restriction&gt;
        ///  &lt;addresses&gt;&quot;address 1&quot; address2 &quot; address 3&quot; address4&lt;/addresses&gt;
        ///  &lt;code&gt;code1&lt;/code&gt;
        ///  &lt;code&gt;code2&lt;/code&gt;
        ///  &lt;note&gt;note&lt;/note&gt;
        ///  &lt;references&gt;refer [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string AllElementsFilledAlert {
            get {
                return ResourceManager.GetString("AllElementsFilledAlert", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version = &quot;1.0&quot; encoding = &quot;UTF-8&quot;?&gt;
        ///&lt;alert xmlns = &quot;urn:oasis:names:tc:emergency:cap:1.1&quot;&gt;
        ///  &lt;identifier&gt;KAR0-0306112239-SW&lt;/identifier&gt;
        ///  &lt;sender&gt;KARO@CLETS.DOJ.CA.GOV&lt;/sender&gt;
        ///  &lt;sent&gt;2003-06-11T22:39:00-07:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;source&gt;SW&lt;/source&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;info&gt;
        ///    &lt;category&gt;Rescue&lt;/category&gt;
        ///    &lt;event&gt;Child Abduction&lt;/event&gt;
        ///    &lt;urgency&gt;Immediate&lt;/urgency&gt;
        ///    &lt;severity&gt;Severe&lt;/severity&gt;
        ///    &lt;certainty&gt;Likely&lt;/certainty [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string AmberAlertCap11 {
            get {
                return ResourceManager.GetString("AmberAlertCap11", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;alert xmlns = &quot;urn:oasis:names:tc:emergency:cap:1.2&quot;&gt;
        ///  &lt;identifier&gt;TRI13970876.2&lt;/identifier&gt; 
        ///  &lt;sender&gt;trinet@caltech.edu&lt;/sender&gt; 
        ///  &lt;sent&gt;2003-06-11T20:56:00-07:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt; 
        ///  &lt;msgType&gt;Update&lt;/msgType&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;references&gt;trinet@caltech.edu,TRI13970876.1,2003-06-11T20:30:00-07:00&lt;/references&gt;
        ///  &lt;info&gt;
        ///    &lt;category&gt;Geo&lt;/category&gt;
        ///    &lt;event&gt;Earthquake&lt;/event&gt;   
        ///    &lt;urgency&gt;Past&lt;/urgency&gt;   
        ///    &lt;severity&gt;Mi [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string circleXml {
            get {
                return ResourceManager.GetString("circleXml", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;alert xmlns=&quot;urn:oasis:names:tc:emergency:cap:1.1&quot;&gt;
        ///  &lt;identifier&gt;TRI13970876.1&lt;/identifier&gt;
        ///  &lt;sender&gt;trinet@caltech.edu&lt;/sender&gt;
        ///  &lt;sent&gt;2003-06-11T20:56:00-07:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;incidents&gt;13970876&lt;/incidents&gt;
        ///  &lt;info&gt;
        ///    &lt;category&gt;Geo&lt;/category&gt;
        ///    &lt;event&gt;Earthquake&lt;/event&gt;
        ///    &lt;urgency&gt;Past&lt;/urgency&gt;
        ///    &lt;severity&gt;Minor&lt;/severity&gt;
        ///    &lt;certainty&gt;Observed&lt;/certainty&gt;
        ///    &lt;sender [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string EarthquakeCap11 {
            get {
                return ResourceManager.GetString("EarthquakeCap11", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml-stylesheet href=&apos;http://alerts.weather.gov/cap/capatomproduct.xsl&apos; type=&apos;text/xsl&apos;?&gt;
        ///&lt;!--
        ///This atom/xml feed is an index to active advisories, watches and warnings 
        ///issued by the National Weather Service.  This index file is not the complete 
        ///Common Alerting Protocol (CAP) alert message.  To obtain the complete CAP 
        ///alert, please follow the links for each entry in this index.  Also note the 
        ///CAP message uses a style sheet to convey the information in a human readable 
        ///format.  Please view the s [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string ExpiredAlertXml {
            get {
                return ResourceManager.GetString("ExpiredAlertXml", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;alert xmlns=&quot;urn:oasis:names:tc:emergency:cap:1.1&quot;&gt;
        ///  &lt;identifier&gt;43b080713727&lt;/identifier&gt;
        ///  &lt;sender&gt;hsas@dhs.gov&lt;/sender&gt;
        ///  &lt;sent&gt;2003-04-02T14:39:01-05:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;info&gt;
        ///    &lt;category&gt;Security&lt;/category&gt;
        ///    &lt;event&gt;Homeland Security Advisory System Update&lt;/event&gt;
        ///    &lt;urgency&gt;Immediate&lt;/urgency&gt;
        ///    &lt;severity&gt;Severe&lt;/severity&gt;
        ///    &lt;certainty&gt;Likely&lt;/certainty&gt;
        ///    &lt;senderNam [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string HomeLandSecurityAlertCap11 {
            get {
                return ResourceManager.GetString("HomeLandSecurityAlertCap11", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version = &quot;1.0&quot; encoding = &quot;UTF-8&quot;?&gt;
        ///&lt;alerts&gt;
        ///&lt;alert xmlns = &quot;urn:oasis:names:tc:emergency:cap:1.2&quot;&gt;
        ///  &lt;identifier&gt;KSTO1055887203&lt;/identifier&gt;
        ///  &lt;sender&gt;KSTO@NWS.NOAA.GOV&lt;/sender&gt;
        ///  &lt;sent&gt;2003-06-17T14:57:00-07:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;info&gt;
        ///    &lt;category&gt;Met&lt;/category&gt;
        ///    &lt;event&gt;SEVERE THUNDERSTORM&lt;/event&gt;
        ///    &lt;responseType&gt;Shelter&lt;/responseType&gt;
        ///    &lt;urgency&gt;Immediate&lt;/urgency&gt;
        ///    &lt;severity&gt;Severe&lt;/severity&gt;
        ///    &lt;certa [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string MultipleAlertAndInfoThunderstorm {
            get {
                return ResourceManager.GetString("MultipleAlertAndInfoThunderstorm", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;alert xmlns=&quot;urn:oasis:names:tc:emergency:cap:1.2&quot;&gt;
        ///  &lt;identifier&gt;43b080713727&lt;/identifier&gt;
        ///  &lt;sender&gt;hsas@dhs.gov&lt;/sender&gt;
        ///  &lt;sent&gt;2003-04-02T14:39:01-05:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;source&gt;source&lt;/source&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;restriction&gt;restriction&lt;/restriction&gt;
        ///  &lt;addresses&gt;&quot;address 1&quot; address2 &quot; address 3&quot; address4&lt;/addresses&gt;
        ///  &lt;code&gt;code&lt;/code&gt;
        ///  &lt;code&gt;code2&lt;/code&gt;
        ///  &lt;note&gt;note&lt;/note&gt;
        ///  &lt;references&gt;refere [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string MultipleAlertXml {
            get {
                return ResourceManager.GetString("MultipleAlertXml", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;alert xmlns=&quot;urn:oasis:names:tc:emergency:cap:1.2&quot;&gt;
        ///  &lt;identifier&gt;TRI13970876.2&lt;/identifier&gt;
        ///  &lt;sender&gt;trinet@caltech.edu&lt;/sender&gt;
        ///  &lt;sent&gt;2003-06-11T20:56:00-07:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Update&lt;/msgType&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;references&gt;trinet@caltech.edu,TRI13970876.1,2003-06-11T20:30:00-07:00&lt;/references&gt;
        ///  &lt;info&gt;
        ///    &lt;category&gt;Geo&lt;/category&gt;
        ///    &lt;event&gt;Earthquake&lt;/event&gt;
        ///    &lt;urgency&gt;Past&lt;/urgency&gt;
        ///    &lt;severity&gt;Minor&lt;/severi [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string MultipleCircleXml {
            get {
                return ResourceManager.GetString("MultipleCircleXml", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version = &quot;1.0&quot; encoding = &quot;UTF-8&quot;?&gt;
        ///&lt;alert xmlns = &quot;urn:oasis:names:tc:emergency:cap:1.2&quot;&gt;
        ///  &lt;identifier&gt;KSTO1055887203&lt;/identifier&gt;
        ///  &lt;sender&gt;KSTO@NWS.NOAA.GOV&lt;/sender&gt;
        ///  &lt;sent&gt;2003-06-17T14:57:00-07:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;info&gt;
        ///    &lt;category&gt;Met&lt;/category&gt;
        ///    &lt;event&gt;SEVERE THUNDERSTORM&lt;/event&gt;
        ///    &lt;responseType&gt;Shelter&lt;/responseType&gt;
        ///    &lt;urgency&gt;Immediate&lt;/urgency&gt;
        ///    &lt;severity&gt;Severe&lt;/severity&gt;
        ///    &lt;certainty&gt;Obser [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string MultipleInfoThunderstorm {
            get {
                return ResourceManager.GetString("MultipleInfoThunderstorm", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;alert xmlns=&quot;urn:oasis:names:tc:emergency:cap:1.2&quot;&gt;
        ///  &lt;identifier&gt;43b080713727&lt;/identifier&gt;
        ///  &lt;sender&gt;hsas@dhs.gov&lt;/sender&gt;
        ///  &lt;sent&gt;2003-04-02T14:39:01-05:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;info&gt;
        ///    &lt;category&gt;Security&lt;/category&gt;
        ///    &lt;category&gt;Safety&lt;/category&gt;
        ///    &lt;event&gt;Homeland Security Advisory System Update&lt;/event&gt;
        ///    &lt;urgency&gt;Immediate&lt;/urgency&gt;
        ///    &lt;severity&gt;Severe&lt;/severity&gt;
        ///    &lt;certainty&gt;V [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string MultipleParameterTestXml {
            get {
                return ResourceManager.GetString("MultipleParameterTestXml", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version = &quot;1.0&quot; encoding = &quot;UTF-8&quot;?&gt;
        ///&lt;alerts&gt;
        ///&lt;alert xmlns = &quot;urn:oasis:names:tc:emergency:cap:1.2&quot;&gt;
        ///  &lt;identifier&gt;KSTO1055887203&lt;/identifier&gt; 
        ///  &lt;sender&gt;KSTO@NWS.NOAA.GOV&lt;/sender&gt; 
        ///  &lt;sent&gt;2003-06-17T14:57:00-07:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt; 
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt; 
        ///  &lt;info&gt;
        ///    &lt;category&gt;Met&lt;/category&gt;   
        ///    &lt;event&gt;SEVERE THUNDERSTORM&lt;/event&gt;
        ///    &lt;responseType&gt;Shelter&lt;/responseType&gt; 
        ///    &lt;urgency&gt;Immediate&lt;/urgency&gt;   
        ///    &lt;severity&gt;Severe&lt;/severity&gt;  [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string MultipleThunderstorm12Xml {
            get {
                return ResourceManager.GetString("MultipleThunderstorm12Xml", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;alert xmlns=&quot;urn:oasis:names:tc:emergency:cap:1.2&quot;&gt;
        ///  &lt;identifier&gt;43b080713727&lt;/identifier&gt;
        ///  &lt;sender&gt;hsas@dhs.gov&lt;/sender&gt;
        ///  &lt;sent&gt;2003-04-02T14:39:01-05:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;info&gt;
        ///    &lt;category&gt;Security&lt;/category&gt;
        ///    &lt;event&gt;Homeland Security Advisory System Update&lt;/event&gt;
        ///    &lt;urgency&gt;Immediate&lt;/urgency&gt;
        ///    &lt;severity&gt;Severe&lt;/severity&gt;
        ///    &lt;certainty&gt;Likely&lt;/certainty&gt;
        ///    &lt;senderNam [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string OrangeAlertXml {
            get {
                return ResourceManager.GetString("OrangeAlertXml", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;alert xmlns=&quot;urn:oasis:names:tc:emergency:cap:1.1&quot;&gt;
        ///  &lt;identifier&gt;KSTO1055887203&lt;/identifier&gt;
        ///  &lt;sender&gt;KSTO@NWS.NOAA.GOV&lt;/sender&gt;
        ///  &lt;sent&gt;2003-06-17T14:57:00-07:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;info&gt;
        ///    &lt;category&gt;Met&lt;/category&gt;
        ///    &lt;event&gt;SEVERE THUNDERSTORM&lt;/event&gt;
        ///    &lt;responseType&gt;Shelter&lt;/responseType&gt;
        ///    &lt;urgency&gt;Immediate&lt;/urgency&gt;
        ///    &lt;severity&gt;Severe&lt;/severity&gt;
        ///    &lt;certainty&gt;Observed&lt;/c [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string SevereThundertromCap11 {
            get {
                return ResourceManager.GetString("SevereThundertromCap11", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;alert xmlns=&quot;urn:oasis:names:tc:emergency:cap:1.2&quot;&gt;
        ///  &lt;identifier&gt;KSTO1055887203&lt;/identifier&gt;
        ///  &lt;sender&gt;KSTO@NWS.NOAA.GOV&lt;/sender&gt;
        ///  &lt;sent&gt;2003-06-17T14:57:00-07:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;info&gt;
        ///    &lt;category&gt;Met&lt;/category&gt;
        ///    &lt;event&gt;SEVERE THUNDERSTORM&lt;/event&gt;
        ///    &lt;responseType&gt;Shelter&lt;/responseType&gt;
        ///    &lt;urgency&gt;Immediate&lt;/urgency&gt;
        ///    &lt;severity&gt;Severe&lt;/severity&gt;
        ///    &lt;certainty&gt;Observed&lt;/c [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string Thunderstorm12AllDatesXml {
            get {
                return ResourceManager.GetString("Thunderstorm12AllDatesXml", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version = &quot;1.0&quot; encoding = &quot;UTF-8&quot;?&gt;
        ///&lt;alert xmlns = &quot;urn:oasis:names:tc:emergency:cap:1.2&quot;&gt;
        ///  &lt;identifier&gt;KSTO1055887203&lt;/identifier&gt; 
        ///  &lt;sender&gt;KSTO@NWS.NOAA.GOV&lt;/sender&gt; 
        ///  &lt;sent&gt;2003-06-17T14:57:00-07:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt; 
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt; 
        ///  &lt;info&gt;
        ///    &lt;category&gt;Met&lt;/category&gt;   
        ///    &lt;event&gt;SEVERE THUNDERSTORM&lt;/event&gt;
        ///    &lt;responseType&gt;Shelter&lt;/responseType&gt; 
        ///    &lt;urgency&gt;Immediate&lt;/urgency&gt;   
        ///    &lt;severity&gt;Severe&lt;/severity&gt;   
        ///    &lt;c [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string Thunderstorm12Xml {
            get {
                return ResourceManager.GetString("Thunderstorm12Xml", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version = &quot;1.0&quot; encoding = &quot;UTF-8&quot;?&gt;
        ///&lt;alert xmlns = &quot;urn:oasis:names:tc:emergency:cap:1.2&quot;&gt;
        ///  &lt;identifier&gt;KSTO1055887203&lt;/identifier&gt; 
        ///  &lt;sender&gt;KSTO@NWS.NOAA.GOV&lt;/sender&gt; 
        ///  &lt;sent&gt;2003-06-17T14:57:00-07:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Update&lt;/msgType&gt;
        ///  &lt;scope&gt;Restricted&lt;/scope&gt;
        ///  &lt;restriction&gt;Only people with glasses should receive this update.&lt;/restriction&gt;
        ///  &lt;info&gt;
        ///    &lt;category&gt;Met&lt;/category&gt;
        ///    &lt;event&gt;SEVERE THUNDERSTORM&lt;/event&gt;
        ///    &lt;responseType&gt;Shelter&lt;/responseType [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string ThunderstormUpdate12Xml {
            get {
                return ResourceManager.GetString("ThunderstormUpdate12Xml", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;alert xmlns=&quot;urn:oasis:names:tc:emergency:cap:1.2&quot;&gt;
        ///  &lt;identifier&gt;43b080713727&lt;/identifier&gt;
        ///  &lt;sender&gt;hsas@dhs.gov&lt;/sender&gt;
        ///  &lt;sent&gt;2003-04-02T14:39:01-05:00&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;info&gt;
        ///    &lt;category&gt;Security&lt;/category&gt;
        ///    &lt;event&gt;Homeland Security Advisory System Update&lt;/event&gt;
        ///    &lt;urgency&gt;Immediate&lt;/urgency&gt;
        ///    &lt;severity&gt;Severe&lt;/severity&gt;
        ///    &lt;certainty&gt;Very Likely&lt;/certainty&gt;
        ///    &lt;send [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string VeryLikelyOrangeAlertXml {
            get {
                return ResourceManager.GetString("VeryLikelyOrangeAlertXml", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;alert xmlns=&quot;urn:oasis:names:tc:emergency:cap:1.2&quot;&gt;
        ///  &lt;identifier&gt;43b080713727&lt;/identifier&gt;
        ///  &lt;sender&gt;hsas@dhs.gov&lt;/sender&gt;
        ///  &lt;sent&gt;date&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;source&gt;source&lt;/source&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;restriction&gt;restriction&lt;/restriction&gt;
        ///  &lt;addresses&gt;addresses&lt;/addresses&gt;
        ///  &lt;code&gt;code&lt;/code&gt;
        ///  &lt;note&gt;note&lt;/note&gt;
        ///  &lt;references&gt;references&lt;/references&gt;
        ///  &lt;incidents&gt;&lt;/incidents&gt;
        ///  &lt;info&gt;
        ///    &lt;language&gt;romani [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string WrongData {
            get {
                return ResourceManager.GetString("WrongData", resourceCulture);
            }
        }
        
        /// <summary>
        /// Wyszukuje zlokalizowany ciąg podobny do ciągu &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;alert xmlns=&quot;urn:oasis:names:tc:emergency:cap:1.2&quot;&gt;
        ///  &lt;identifier&gt;43b080713727&lt;/identifier&gt;
        ///  &lt;sender&gt;hsas@dhs.gov&lt;/sender&gt;
        ///  &lt;sent&gt;2003-04-02T14&lt;/sent&gt;
        ///  &lt;status&gt;Actual&lt;/status&gt;
        ///  &lt;msgType&gt;Alert&lt;/msgType&gt;
        ///  &lt;scope&gt;Public&lt;/scope&gt;
        ///  &lt;info&gt;
        ///    &lt;category&gt;Security&lt;/category&gt;
        ///    &lt;event&gt;Homeland Security Advisory System Update&lt;/event&gt;
        ///    &lt;urgency&gt;Immediate&lt;/urgency&gt;
        ///    &lt;severity&gt;Severe&lt;/severity&gt;
        ///    &lt;certainty&gt;Likely&lt;/certainty&gt;
        ///    &lt;senderName&gt;U.S. Gover [obcięto pozostałą część ciągu]&quot;;.
        /// </summary>
        internal static string WrongDateXml {
            get {
                return ResourceManager.GetString("WrongDateXml", resourceCulture);
            }
        }
    }
}
