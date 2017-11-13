using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using Android.Content.Res;
using Java.IO;
using XamarinContext =  Xamarin.Forms;
using Android.Support.V4.App;
using Android.Icu.Util;
using JoanZapata.XamarinIconify.Fonts;
using graphics = Android.Graphics;
using iconify = JoanZapata.XamarinIconify;

namespace NavDrawer.Android.Templates
{
    public class TemplateManager
    {
        public static Typeface FontIconttf = Typeface.CreateFromAsset(XamarinContext.Forms.Context.Assets, "Fonts/fontawesome-webfont.ttf");
        public static iconify.IconDrawable FontIcon(Context context, FontAwesomeIcons fontIcon, graphics.Color color, int size = 25)
        {
            var icon = new JoanZapata.XamarinIconify.IconDrawable(context, fontIcon.ToString()).color(color);
            icon.sizeDp(size);
            icon.sizePx(size);
            return icon;
        }
        #region Repeating Action
        public static void AlarmAction()
        {
            //your repeating action
        }
        //Start the repeating action
        public void StartRepeatingAction(long milliseconds = 43200000)//12 hours default
        {
            //15 * 1000 = 15 seconds
            long halfday = milliseconds;
            Context context = Xamarin.Forms.Forms.Context;
            var intent = new Intent(MainActivity.Current, typeof(Templates.AlarmReceiver));
            var source = PendingIntent.GetBroadcast(XamarinContext.Forms.Context, 0, intent, PendingIntentFlags.UpdateCurrent);
            // Schedule the alarm!
            var am = (AlarmManager)context.GetSystemService(Context.AlarmService);
            am.SetRepeating(AlarmType.ElapsedRealtimeWakeup,
                    SystemClock.ElapsedRealtime() + halfday,
                    halfday,
                    source);
        } 
        #endregion

    }
    #region BroadcastReceiver
    [BroadcastReceiver]
    [IntentFilter(new string[] { "android.intent.action.BOOT_COMPLETED" }, Priority = (int)IntentFilterPriority.LowPriority)]
    public class AlarmReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            var notIntent = new Intent(context, typeof(MainActivity));
            var contentIntent = PendingIntent.GetActivity(context, 0, notIntent, PendingIntentFlags.CancelCurrent);
            TemplateManager.AlarmAction();
        }
    }
    #endregion
    #region Static Font Icon Text
    public class FontText
    {
        public static string FAGlass = "\uf000";

        public static string FAMusic = "\uf001";

        public static string FASearch = "\uf002";

        public static string FAEnvelopeO = "\uf003";

        public static string FAHeart = "\uf004";

        public static string FAStar = "\uf005";

        public static string FAStarO = "\uf006";

        public static string FAUser = "\uf007";

        public static string FAFilm = "\uf008";

        public static string FAThLarge = "\uf009";

        public static string FATh = "\uf00a";

        public static string FAThList = "\uf00b";

        public static string FACheck = "\uf00c";

        public static string FATimes = "\uf00d";

        public static string FASearchPlus = "\uf00e";

        public static string FASearchMinus = "\uf010";

        public static string FAPowerOff = "\uf011";

        public static string FASignal = "\uf012";

        public static string FACog = "\uf013";

        public static string FATrashO = "\uf014";

        public static string FAHome = "\uf015";

        public static string FAFileO = "\uf016";

        public static string FAClockO = "\uf017";

        public static string FARoad = "\uf018";

        public static string FADownload = "\uf019";

        public static string FAArrowCircleODown = "\uf01a";

        public static string FAArrowCircleOUp = "\uf01b";

        public static string FAInbox = "\uf01c";

        public static string FAPlayCircleO = "\uf01d";

        public static string FARepeat = "\uf01e";

        public static string FARefresh = "\uf021";

        public static string FAListAlt = "\uf022";

        public static string FALock = "\uf023";

        public static string FAFlag = "\uf024";

        public static string FAHeadphones = "\uf025";

        public static string FAVolumeOff = "\uf026";

        public static string FAVolumeDown = "\uf027";

        public static string FAVolumeUp = "\uf028";

        public static string FAQrcode = "\uf029";

        public static string FABarcode = "\uf02a";

        public static string FATag = "\uf02b";

        public static string FATags = "\uf02c";

        public static string FABook = "\uf02d";

        public static string FABookmark = "\uf02e";

        public static string FAPrint = "\uf02f";

        public static string FACamera = "\uf030";

        public static string FAFont = "\uf031";

        public static string FABold = "\uf032";

        public static string FAItalic = "\uf033";

        public static string FATextHeight = "\uf034";

        public static string FATextWidth = "\uf035";

        public static string FAAlignLeft = "\uf036";

        public static string FAAlignCenter = "\uf037";

        public static string FAAlignRight = "\uf038";

        public static string FAAlignJustify = "\uf039";

        public static string FAList = "\uf03a";

        public static string FAOutdent = "\uf03b";

        public static string FAIndent = "\uf03c";

        public static string FAVideoCamera = "\uf03d";

        public static string FAPictureO = "\uf03e";

        public static string FAPencil = "\uf040";

        public static string FAMapMarker = "\uf041";

        public static string FAAdjust = "\uf042";

        public static string FATint = "\uf043";

        public static string FAPencilSquareO = "\uf044";

        public static string FAShareSquareO = "\uf045";

        public static string FACheckSquareO = "\uf046";

        public static string FAArrows = "\uf047";

        public static string FAStepBackward = "\uf048";

        public static string FAFastBackward = "\uf049";

        public static string FABackward = "\uf04a";

        public static string FAPlay = "\uf04b";

        public static string FAPause = "\uf04c";

        public static string FAStop = "\uf04d";

        public static string FAForward = "\uf04e";

        public static string FAFastForward = "\uf050";

        public static string FAStepForward = "\uf051";

        public static string FAEject = "\uf052";

        public static string FAChevronLeft = "\uf053";

        public static string FAChevronRight = "\uf054";

        public static string FAPlusCircle = "\uf055";

        public static string FAMinusCircle = "\uf056";

        public static string FATimesCircle = "\uf057";

        public static string FACheckCircle = "\uf058";

        public static string FAQuestionCircle = "\uf059";

        public static string FAInfoCircle = "\uf05a";

        public static string FACrosshairs = "\uf05b";

        public static string FATimesCircleO = "\uf05c";

        public static string FACheckCircleO = "\uf05d";

        public static string FABan = "\uf05e";

        public static string FAArrowLeft = "\uf060";

        public static string FAArrowRight = "\uf061";

        public static string FAArrowUp = "\uf062";

        public static string FAArrowDown = "\uf063";

        public static string FAShare = "\uf064";

        public static string FAExpand = "\uf065";

        public static string FACompress = "\uf066";

        public static string FAPlus = "\uf067";

        public static string FAMinus = "\uf068";

        public static string FAAsterisk = "\uf069";

        public static string FAExclamationCircle = "\uf06a";

        public static string FAGift = "\uf06b";

        public static string FALeaf = "\uf06c";

        public static string FAFire = "\uf06d";

        public static string FAEye = "\uf06e";

        public static string FAEyeSlash = "\uf070";

        public static string FAExclamationTriangle = "\uf071";

        public static string FAPlane = "\uf072";

        public static string FACalendar = "\uf073";

        public static string FARandom = "\uf074";

        public static string FAComment = "\uf075";

        public static string FAMagnet = "\uf076";

        public static string FAChevronUp = "\uf077";

        public static string FAChevronDown = "\uf078";

        public static string FARetweet = "\uf079";

        public static string FAShoppingCart = "\uf07a";

        public static string FAFolder = "\uf07b";

        public static string FAFolderOpen = "\uf07c";

        public static string FAArrowsV = "\uf07d";

        public static string FAArrowsH = "\uf07e";

        public static string FABarChart = "\uf080";

        public static string FATwitterSquare = "\uf081";

        public static string FAFacebookSquare = "\uf082";

        public static string FACameraRetro = "\uf083";

        public static string FAKey = "\uf084";

        public static string FACogs = "\uf085";

        public static string FAComments = "\uf086";

        public static string FAThumbsOUp = "\uf087";

        public static string FAThumbsODown = "\uf088";

        public static string FAStarHalf = "\uf089";

        public static string FAHeartO = "\uf08a";

        public static string FASignOut = "\uf08b";

        public static string FALinkedinSquare = "\uf08c";

        public static string FAThumbTack = "\uf08d";

        public static string FAExternalLink = "\uf08e";

        public static string FASignIn = "\uf090";

        public static string FATrophy = "\uf091";

        public static string FAGithubSquare = "\uf092";

        public static string FAUpload = "\uf093";

        public static string FALemonO = "\uf094";

        public static string FAPhone = "\uf095";

        public static string FASquareO = "\uf096";

        public static string FABookmarkO = "\uf097";

        public static string FAPhoneSquare = "\uf098";

        public static string FATwitter = "\uf099";

        public static string FAFacebook = "\uf09a";

        public static string FAGithub = "\uf09b";

        public static string FAUnlock = "\uf09c";

        public static string FACreditCard = "\uf09d";

        public static string FARss = "\uf09e";

        public static string FAHddO = "\uf0a0";

        public static string FABullhorn = "\uf0a1";

        public static string FABell = "\uf0f3";

        public static string FACertificate = "\uf0a3";

        public static string FAHandORight = "\uf0a4";

        public static string FAHandOLeft = "\uf0a5";

        public static string FAHandOUp = "\uf0a6";

        public static string FAHandODown = "\uf0a7";

        public static string FAArrowCircleLeft = "\uf0a8";

        public static string FAArrowCircleRight = "\uf0a9";

        public static string FAArrowCircleUp = "\uf0aa";

        public static string FAArrowCircleDown = "\uf0ab";

        public static string FAGlobe = "\uf0ac";

        public static string FAWrench = "\uf0ad";

        public static string FATasks = "\uf0ae";

        public static string FAFilter = "\uf0b0";

        public static string FABriefcase = "\uf0b1";

        public static string FAArrowsAlt = "\uf0b2";

        public static string FAUsers = "\uf0c0";

        public static string FALink = "\uf0c1";

        public static string FACloud = "\uf0c2";

        public static string FAFlask = "\uf0c3";

        public static string FAScissors = "\uf0c4";

        public static string FAFilesO = "\uf0c5";

        public static string FAPaperclip = "\uf0c6";

        public static string FAFloppyO = "\uf0c7";

        public static string FASquare = "\uf0c8";

        public static string FABars = "\uf0c9";

        public static string FAListUl = "\uf0ca";

        public static string FAListOl = "\uf0cb";

        public static string FAStrikethrough = "\uf0cc";

        public static string FAUnderline = "\uf0cd";

        public static string FATable = "\uf0ce";

        public static string FAMagic = "\uf0d0";

        public static string FATruck = "\uf0d1";

        public static string FAPinterest = "\uf0d2";

        public static string FAPinterestSquare = "\uf0d3";

        public static string FAGooglePlusSquare = "\uf0d4";

        public static string FAGooglePlus = "\uf0d5";

        public static string FAMoney = "\uf0d6";

        public static string FACaretDown = "\uf0d7";

        public static string FACaretUp = "\uf0d8";

        public static string FACaretLeft = "\uf0d9";

        public static string FACaretRight = "\uf0da";

        public static string FAColumns = "\uf0db";

        public static string FASort = "\uf0dc";

        public static string FASortDesc = "\uf0dd";

        public static string FASortAsc = "\uf0de";

        public static string FAEnvelope = "\uf0e0";

        public static string FALinkedin = "\uf0e1";

        public static string FAUndo = "\uf0e2";

        public static string FAGavel = "\uf0e3";

        public static string FATachometer = "\uf0e4";

        public static string FACommentO = "\uf0e5";

        public static string FACommentsO = "\uf0e6";

        public static string FABolt = "\uf0e7";

        public static string FASitemap = "\uf0e8";

        public static string FAUmbrella = "\uf0e9";

        public static string FAClipboard = "\uf0ea";

        public static string FALightbulbO = "\uf0eb";

        public static string FAExchange = "\uf0ec";

        public static string FACloudDownload = "\uf0ed";

        public static string FACloudUpload = "\uf0ee";

        public static string FAUserMd = "\uf0f0";

        public static string FAStethoscope = "\uf0f1";

        public static string FASuitcase = "\uf0f2";

        public static string FABellO = "\uf0a2";

        public static string FACoffee = "\uf0f4";

        public static string FACutlery = "\uf0f5";

        public static string FAFileTextO = "\uf0f6";

        public static string FABuildingO = "\uf0f7";

        public static string FAHospitalO = "\uf0f8";

        public static string FAAmbulance = "\uf0f9";

        public static string FAMedkit = "\uf0fa";

        public static string FAFighterJet = "\uf0fb";

        public static string FABeer = "\uf0fc";

        public static string FAHSquare = "\uf0fd";

        public static string FAPlusSquare = "\uf0fe";

        public static string FAAngleDoubleLeft = "\uf100";

        public static string FAAngleDoubleRight = "\uf101";

        public static string FAAngleDoubleUp = "\uf102";

        public static string FAAngleDoubleDown = "\uf103";

        public static string FAAngleLeft = "\uf104";

        public static string FAAngleRight = "\uf105";

        public static string FAAngleUp = "\uf106";

        public static string FAAngleDown = "\uf107";

        public static string FADesktop = "\uf108";

        public static string FALaptop = "\uf109";

        public static string FATablet = "\uf10a";

        public static string FAMobile = "\uf10b";

        public static string FACircleO = "\uf10c";

        public static string FAQuoteLeft = "\uf10d";

        public static string FAQuoteRight = "\uf10e";

        public static string FASpinner = "\uf110";

        public static string FACircle = "\uf111";

        public static string FAReply = "\uf112";

        public static string FAGithubAlt = "\uf113";

        public static string FAFolderO = "\uf114";

        public static string FAFolderOpenO = "\uf115";

        public static string FASmileO = "\uf118";

        public static string FAFrownO = "\uf119";

        public static string FAMehO = "\uf11a";

        public static string FAGamepad = "\uf11b";

        public static string FAKeyboardO = "\uf11c";

        public static string FAFlagO = "\uf11d";

        public static string FAFlagCheckered = "\uf11e";

        public static string FATerminal = "\uf120";

        public static string FACode = "\uf121";

        public static string FAReplyAll = "\uf122";

        public static string FAStarHalfO = "\uf123";

        public static string FALocationArrow = "\uf124";

        public static string FACrop = "\uf125";

        public static string FACodeFork = "\uf126";

        public static string FAChainBroken = "\uf127";

        public static string FAQuestion = "\uf128";

        public static string FAInfo = "\uf129";

        public static string FAExclamation = "\uf12a";

        public static string FASuperscript = "\uf12b";

        public static string FASubscript = "\uf12c";

        public static string FAEraser = "\uf12d";

        public static string FAPuzzlePiece = "\uf12e";

        public static string FAMicrophone = "\uf130";

        public static string FAMicrophoneSlash = "\uf131";

        public static string FAShield = "\uf132";

        public static string FACalendarO = "\uf133";

        public static string FAFireExtinguisher = "\uf134";

        public static string FARocket = "\uf135";

        public static string FAMaxcdn = "\uf136";

        public static string FAChevronCircleLeft = "\uf137";

        public static string FAChevronCircleRight = "\uf138";

        public static string FAChevronCircleUp = "\uf139";

        public static string FAChevronCircleDown = "\uf13a";

        public static string FAHtml5 = "\uf13b";

        public static string FACss3 = "\uf13c";

        public static string FAAnchor = "\uf13d";

        public static string FAUnlockAlt = "\uf13e";

        public static string FABullseye = "\uf140";

        public static string FAEllipsisH = "\uf141";

        public static string FAEllipsisV = "\uf142";

        public static string FARssSquare = "\uf143";

        public static string FAPlayCircle = "\uf144";

        public static string FATicket = "\uf145";

        public static string FAMinusSquare = "\uf146";

        public static string FAMinusSquareO = "\uf147";

        public static string FALevelUp = "\uf148";

        public static string FALevelDown = "\uf149";

        public static string FACheckSquare = "\uf14a";

        public static string FAPencilSquare = "\uf14b";

        public static string FAExternalLinkSquare = "\uf14c";

        public static string FAShareSquare = "\uf14d";

        public static string FACompass = "\uf14e";

        public static string FACaretSquareODown = "\uf150";

        public static string FACaretSquareOUp = "\uf151";

        public static string FACaretSquareORight = "\uf152";

        public static string FAEur = "\uf153";

        public static string FAGbp = "\uf154";

        public static string FAUsd = "\uf155";

        public static string FAInr = "\uf156";

        public static string FAJpy = "\uf157";

        public static string FARub = "\uf158";

        public static string FAKrw = "\uf159";

        public static string FABtc = "\uf15a";

        public static string FAFile = "\uf15b";

        public static string FAFileText = "\uf15c";

        public static string FASortAlphaAsc = "\uf15d";

        public static string FASortAlphaDesc = "\uf15e";

        public static string FASortAmountAsc = "\uf160";

        public static string FASortAmountDesc = "\uf161";

        public static string FASortNumericAsc = "\uf162";

        public static string FASortNumericDesc = "\uf163";

        public static string FAThumbsUp = "\uf164";

        public static string FAThumbsDown = "\uf165";

        public static string FAYoutubeSquare = "\uf166";

        public static string FAYoutube = "\uf167";

        public static string FAXing = "\uf168";

        public static string FAXingSquare = "\uf169";

        public static string FAYoutubePlay = "\uf16a";

        public static string FADropbox = "\uf16b";

        public static string FAStackOverflow = "\uf16c";

        public static string FAInstagram = "\uf16d";

        public static string FAFlickr = "\uf16e";

        public static string FAAdn = "\uf170";

        public static string FABitbucket = "\uf171";

        public static string FABitbucketSquare = "\uf172";

        public static string FATumblr = "\uf173";

        public static string FATumblrSquare = "\uf174";

        public static string FALongArrowDown = "\uf175";

        public static string FALongArrowUp = "\uf176";

        public static string FALongArrowLeft = "\uf177";

        public static string FALongArrowRight = "\uf178";

        public static string FAApple = "\uf179";

        public static string FAWindows = "\uf17a";

        public static string FAAndroid = "\uf17b";

        public static string FALinux = "\uf17c";

        public static string FADribbble = "\uf17d";

        public static string FASkype = "\uf17e";

        public static string FAFoursquare = "\uf180";

        public static string FATrello = "\uf181";

        public static string FAFemale = "\uf182";

        public static string FAMale = "\uf183";

        public static string FAGratipay = "\uf184";

        public static string FASunO = "\uf185";

        public static string FAMoonO = "\uf186";

        public static string FAArchive = "\uf187";

        public static string FABug = "\uf188";

        public static string FAVk = "\uf189";

        public static string FAWeibo = "\uf18a";

        public static string FARenren = "\uf18b";

        public static string FAPagelines = "\uf18c";

        public static string FAStackExchange = "\uf18d";

        public static string FAArrowCircleORight = "\uf18e";

        public static string FAArrowCircleOLeft = "\uf190";

        public static string FACaretSquareOLeft = "\uf191";

        public static string FADotCircleO = "\uf192";

        public static string FAWheelchair = "\uf193";

        public static string FAVimeoSquare = "\uf194";

        public static string FATry = "\uf195";

        public static string FAPlusSquareO = "\uf196";

        public static string FASpaceShuttle = "\uf197";

        public static string FASlack = "\uf198";

        public static string FAEnvelopeSquare = "\uf199";

        public static string FAWordpress = "\uf19a";

        public static string FAOpenid = "\uf19b";

        public static string FAUniversity = "\uf19c";

        public static string FAGraduationCap = "\uf19d";

        public static string FAYahoo = "\uf19e";

        public static string FAGoogle = "\uf1a0";

        public static string FAReddit = "\uf1a1";

        public static string FARedditSquare = "\uf1a2";

        public static string FAStumbleuponCircle = "\uf1a3";

        public static string FAStumbleupon = "\uf1a4";

        public static string FADelicious = "\uf1a5";

        public static string FADigg = "\uf1a6";

        public static string FAPiedPiperPp = "\uf1a7";

        public static string FAPiedPiperAlt = "\uf1a8";

        public static string FADrupal = "\uf1a9";

        public static string FAJoomla = "\uf1aa";

        public static string FALanguage = "\uf1ab";

        public static string FAFax = "\uf1ac";

        public static string FABuilding = "\uf1ad";

        public static string FAChild = "\uf1ae";

        public static string FAPaw = "\uf1b0";

        public static string FASpoon = "\uf1b1";

        public static string FACube = "\uf1b2";

        public static string FACubes = "\uf1b3";

        public static string FABehance = "\uf1b4";

        public static string FABehanceSquare = "\uf1b5";

        public static string FASteam = "\uf1b6";

        public static string FASteamSquare = "\uf1b7";

        public static string FARecycle = "\uf1b8";

        public static string FACar = "\uf1b9";

        public static string FATaxi = "\uf1ba";

        public static string FATree = "\uf1bb";

        public static string FASpotify = "\uf1bc";

        public static string FADeviantart = "\uf1bd";

        public static string FASoundcloud = "\uf1be";

        public static string FADatabase = "\uf1c0";

        public static string FAFilePdfO = "\uf1c1";

        public static string FAFileWordO = "\uf1c2";

        public static string FAFileExcelO = "\uf1c3";

        public static string FAFilePowerpointO = "\uf1c4";

        public static string FAFileImageO = "\uf1c5";

        public static string FAFileArchiveO = "\uf1c6";

        public static string FAFileAudioO = "\uf1c7";

        public static string FAFileVideoO = "\uf1c8";

        public static string FAFileCodeO = "\uf1c9";

        public static string FAVine = "\uf1ca";

        public static string FACodepen = "\uf1cb";

        public static string FAJsfiddle = "\uf1cc";

        public static string FALifeRing = "\uf1cd";

        public static string FACircleONotch = "\uf1ce";

        public static string FARebel = "\uf1d0";

        public static string FAEmpire = "\uf1d1";

        public static string FAGitSquare = "\uf1d2";

        public static string FAGit = "\uf1d3";

        public static string FAHackerNews = "\uf1d4";

        public static string FATencentWeibo = "\uf1d5";

        public static string FAQq = "\uf1d6";

        public static string FAWeixin = "\uf1d7";

        public static string FAPaperPlane = "\uf1d8";

        public static string FAPaperPlaneO = "\uf1d9";

        public static string FAHistory = "\uf1da";

        public static string FACircleThin = "\uf1db";

        public static string FAHeader = "\uf1dc";

        public static string FAParagraph = "\uf1dd";

        public static string FASliders = "\uf1de";

        public static string FAShareAlt = "\uf1e0";

        public static string FAShareAltSquare = "\uf1e1";

        public static string FABomb = "\uf1e2";

        public static string FAFutbolO = "\uf1e3";

        public static string FATty = "\uf1e4";

        public static string FABinoculars = "\uf1e5";

        public static string FAPlug = "\uf1e6";

        public static string FASlideshare = "\uf1e7";

        public static string FATwitch = "\uf1e8";

        public static string FAYelp = "\uf1e9";

        public static string FANewspaperO = "\uf1ea";

        public static string FAWifi = "\uf1eb";

        public static string FACalculator = "\uf1ec";

        public static string FAPaypal = "\uf1ed";

        public static string FAGoogleWallet = "\uf1ee";

        public static string FACcVisa = "\uf1f0";

        public static string FACcMastercard = "\uf1f1";

        public static string FACcDiscover = "\uf1f2";

        public static string FACcAmex = "\uf1f3";

        public static string FACcPaypal = "\uf1f4";

        public static string FACcStripe = "\uf1f5";

        public static string FABellSlash = "\uf1f6";

        public static string FABellSlashO = "\uf1f7";

        public static string FATrash = "\uf1f8";

        public static string FACopyright = "\uf1f9";

        public static string FAAt = "\uf1fa";

        public static string FAEyedropper = "\uf1fb";

        public static string FAPaintBrush = "\uf1fc";

        public static string FABirthdayCake = "\uf1fd";

        public static string FAAreaChart = "\uf1fe";

        public static string FAPieChart = "\uf200";

        public static string FALineChart = "\uf201";

        public static string FALastfm = "\uf202";

        public static string FALastfmSquare = "\uf203";

        public static string FAToggleOff = "\uf204";

        public static string FAToggleOn = "\uf205";

        public static string FABicycle = "\uf206";

        public static string FABus = "\uf207";

        public static string FAIoxhost = "\uf208";

        public static string FAAngellist = "\uf209";

        public static string FACc = "\uf20a";

        public static string FAIls = "\uf20b";

        public static string FAMeanpath = "\uf20c";

        public static string FABuysellads = "\uf20d";

        public static string FAConnectdevelop = "\uf20e";

        public static string FADashcube = "\uf210";

        public static string FAForumbee = "\uf211";

        public static string FALeanpub = "\uf212";

        public static string FASellsy = "\uf213";

        public static string FAShirtsinbulk = "\uf214";

        public static string FASimplybuilt = "\uf215";

        public static string FASkyatlas = "\uf216";

        public static string FACartPlus = "\uf217";

        public static string FACartArrowDown = "\uf218";

        public static string FADiamond = "\uf219";

        public static string FAShip = "\uf21a";

        public static string FAUserSecret = "\uf21b";

        public static string FAMotorcycle = "\uf21c";

        public static string FAStreetView = "\uf21d";

        public static string FAHeartbeat = "\uf21e";

        public static string FAVenus = "\uf221";

        public static string FAMars = "\uf222";

        public static string FAMercury = "\uf223";

        public static string FATransgender = "\uf224";

        public static string FATransgenderAlt = "\uf225";

        public static string FAVenusDouble = "\uf226";

        public static string FAMarsDouble = "\uf227";

        public static string FAVenusMars = "\uf228";

        public static string FAMarsStroke = "\uf229";

        public static string FAMarsStrokeV = "\uf22a";

        public static string FAMarsStrokeH = "\uf22b";

        public static string FANeuter = "\uf22c";

        public static string FAGenderless = "\uf22d";

        public static string FAFacebookOfficial = "\uf230";

        public static string FAPinterestP = "\uf231";

        public static string FAWhatsapp = "\uf232";

        public static string FAServer = "\uf233";

        public static string FAUserPlus = "\uf234";

        public static string FAUserTimes = "\uf235";

        public static string FABed = "\uf236";

        public static string FAViacoin = "\uf237";

        public static string FATrain = "\uf238";

        public static string FASubway = "\uf239";

        public static string FAMedium = "\uf23a";

        public static string FAYCombinator = "\uf23b";

        public static string FAOptinMonster = "\uf23c";

        public static string FAOpencart = "\uf23d";

        public static string FAExpeditedssl = "\uf23e";

        public static string FABatteryFull = "\uf240";

        public static string FABatteryThreeQuarters = "\uf241";

        public static string FABatteryHalf = "\uf242";

        public static string FABatteryQuarter = "\uf243";

        public static string FABatteryEmpty = "\uf244";

        public static string FAMousePointer = "\uf245";

        public static string FAICursor = "\uf246";

        public static string FAObjectGroup = "\uf247";

        public static string FAObjectUngroup = "\uf248";

        public static string FAStickyNote = "\uf249";

        public static string FAStickyNoteO = "\uf24a";

        public static string FACcJcb = "\uf24b";

        public static string FACcDinersClub = "\uf24c";

        public static string FAClone = "\uf24d";

        public static string FABalanceScale = "\uf24e";

        public static string FAHourglassO = "\uf250";

        public static string FAHourglassStart = "\uf251";

        public static string FAHourglassHalf = "\uf252";

        public static string FAHourglassEnd = "\uf253";

        public static string FAHourglass = "\uf254";

        public static string FAHandRockO = "\uf255";

        public static string FAHandPaperO = "\uf256";

        public static string FAHandScissorsO = "\uf257";

        public static string FAHandLizardO = "\uf258";

        public static string FAHandSpockO = "\uf259";

        public static string FAHandPointerO = "\uf25a";

        public static string FAHandPeaceO = "\uf25b";

        public static string FATrademark = "\uf25c";

        public static string FARegistered = "\uf25d";

        public static string FACreativeCommons = "\uf25e";

        public static string FAGg = "\uf260";

        public static string FAGgCircle = "\uf261";

        public static string FATripadvisor = "\uf262";

        public static string FAOdnoklassniki = "\uf263";

        public static string FAOdnoklassnikiSquare = "\uf264";

        public static string FAGetPocket = "\uf265";

        public static string FAWikipediaW = "\uf266";

        public static string FASafari = "\uf267";

        public static string FAChrome = "\uf268";

        public static string FAFirefox = "\uf269";

        public static string FAOpera = "\uf26a";

        public static string FAInternetExplorer = "\uf26b";

        public static string FATelevision = "\uf26c";

        public static string FAContao = "\uf26d";

        public static string FA500px = "\uf26e";

        public static string FAAmazon = "\uf270";

        public static string FACalendarPlusO = "\uf271";

        public static string FACalendarMinusO = "\uf272";

        public static string FACalendarTimesO = "\uf273";

        public static string FACalendarCheckO = "\uf274";

        public static string FAIndustry = "\uf275";

        public static string FAMapPin = "\uf276";

        public static string FAMapSigns = "\uf277";

        public static string FAMapO = "\uf278";

        public static string FAMap = "\uf279";

        public static string FACommenting = "\uf27a";

        public static string FACommentingO = "\uf27b";

        public static string FAHouzz = "\uf27c";

        public static string FAVimeo = "\uf27d";

        public static string FABlackTie = "\uf27e";

        public static string FAFonticons = "\uf280";

        public static string FARedditAlien = "\uf281";

        public static string FAEdge = "\uf282";

        public static string FACreditCardAlt = "\uf283";

        public static string FACodiepie = "\uf284";

        public static string FAModx = "\uf285";

        public static string FAFortAwesome = "\uf286";

        public static string FAUsb = "\uf287";

        public static string FAProductHunt = "\uf288";

        public static string FAMixcloud = "\uf289";

        public static string FAScribd = "\uf28a";

        public static string FAPauseCircle = "\uf28b";

        public static string FAPauseCircleO = "\uf28c";

        public static string FAStopCircle = "\uf28d";

        public static string FAStopCircleO = "\uf28e";

        public static string FAShoppingBag = "\uf290";

        public static string FAShoppingBasket = "\uf291";

        public static string FAHashtag = "\uf292";

        public static string FABluetooth = "\uf293";

        public static string FABluetoothB = "\uf294";

        public static string FAPercent = "\uf295";

        public static string FAGitlab = "\uf296";

        public static string FAWpbeginner = "\uf297";

        public static string FAWpforms = "\uf298";

        public static string FAEnvira = "\uf299";

        public static string FAUniversalAccess = "\uf29a";

        public static string FAWheelchairAlt = "\uf29b";

        public static string FAQuestionCircleO = "\uf29c";

        public static string FABlind = "\uf29d";

        public static string FAAudioDescription = "\uf29e";

        public static string FAVolumeControlPhone = "\uf2a0";

        public static string FABraille = "\uf2a1";

        public static string FAAssistiveListeningSystems = "\uf2a2";

        public static string FAAmericanSignLanguageInterpreting = "\uf2a3";

        public static string FADeaf = "\uf2a4";

        public static string FAGlide = "\uf2a5";

        public static string FAGlideG = "\uf2a6";

        public static string FASignLanguage = "\uf2a7";

        public static string FALowVision = "\uf2a8";

        public static string FAViadeo = "\uf2a9";

        public static string FAViadeoSquare = "\uf2aa";

        public static string FASnapchat = "\uf2ab";

        public static string FASnapchatGhost = "\uf2ac";

        public static string FASnapchatSquare = "\uf2ad";

        public static string FAPiedPiper = "\uf2ae";

        public static string FAFirstOrder = "\uf2b0";

        public static string FAYoast = "\uf2b1";

        public static string FAThemeisle = "\uf2b2";

        public static string FAGooglePlusOfficial = "\uf2b3";

        public static string FAFontAwesome = "\uf2b4";

        public static string FAHandshakeO = "\uf2b5";

        public static string FAEnvelopeOpen = "\uf2b6";

        public static string FAEnvelopeOpenO = "\uf2b7";

        public static string FALinode = "\uf2b8";

        public static string FAAddressBook = "\uf2b9";

        public static string FAAddressBookO = "\uf2ba";

        public static string FAAddressCard = "\uf2bb";

        public static string FAAddressCardO = "\uf2bc";

        public static string FAUserCircle = "\uf2bd";

        public static string FAUserCircleO = "\uf2be";

        public static string FAUserO = "\uf2c0";

        public static string FAIdBadge = "\uf2c1";

        public static string FAIdCard = "\uf2c2";

        public static string FAIdCardO = "\uf2c3";

        public static string FAQuora = "\uf2c4";

        public static string FAFreeCodeCamp = "\uf2c5";

        public static string FATelegram = "\uf2c6";

        public static string FAThermometerFull = "\uf2c7";

        public static string FAThermometerThreeQuarters = "\uf2c8";

        public static string FAThermometerHalf = "\uf2c9";

        public static string FAThermometerQuarter = "\uf2ca";

        public static string FAThermometerEmpty = "\uf2cb";

        public static string FAShower = "\uf2cc";

        public static string FABath = "\uf2cd";

        public static string FAPodcast = "\uf2ce";

        public static string FAWindowMaximize = "\uf2d0";

        public static string FAWindowMinimize = "\uf2d1";

        public static string FAWindowRestore = "\uf2d2";

        public static string FAWindowClose = "\uf2d3";

        public static string FAWindowCloseO = "\uf2d4";

        public static string FABandcamp = "\uf2d5";

        public static string FAGrav = "\uf2d6";

        public static string FAEtsy = "\uf2d7";

        public static string FAImdb = "\uf2d8";

        public static string FARavelry = "\uf2d9";

        public static string FAEercast = "\uf2da";

        public static string FAMicrochip = "\uf2db";

        public static string FASnowflakeO = "\uf2dc";

        public static string FASuperpowers = "\uf2dd";

        public static string FAWpexplorer = "\uf2de";

        public static string FAMeetup = "\uf2e0";
    }
    #endregion
    #region RandomColor
    public class RandomColor
    {
        public Color ColorLight { get; set; }
        public Color ColorDark { get; set; }
        public Color ColorDefault { get; set; }
        public RandomColor()
        {
            ColorDefault = GetRandomDefaultColor();
            ColorDark = GetRandomDarkColor();
            ColorLight = GetRandomLightColor();
        }
        public static Color GetRandomDarkColor()
        {
            var solid = Color.IndianRed;
            Random random = new Random();
            var num = random.Next(1, 48);
            switch (num)
            {
                case 1:
                    solid = Color.Navy;
                    break;
                case 2:
                    solid = Color.MidnightBlue;
                    break;
                case 3:
                    solid = Color.Olive;
                    break;
                case 4:
                    solid = Color.OrangeRed;
                    break;
                case 5:
                    solid = Color.OliveDrab;
                    break;
                case 6:
                    solid = Color.PaleVioletRed;
                    break;
                case 7:
                    solid = Color.MediumVioletRed;
                    break;
                case 8:
                    solid = Color.Maroon;
                    break;
                case 9:
                    solid = Color.MediumBlue;
                    break;
                case 10:
                    solid = Color.YellowGreen;
                    break;
                case 11:
                    solid = Color.Purple;
                    break;
                case 12:
                    solid = Color.Red;
                    break;
                case 13:
                    solid = Color.SlateBlue;
                    break;
                case 14:
                    solid = Color.RoyalBlue;
                    break;
                case 15:
                    solid = Color.Salmon;
                    break;
                case 16:
                    solid = Color.SeaGreen;
                    break;
                case 17:
                    solid = Color.Sienna;
                    break;
                case 18:
                    solid = Color.SaddleBrown;
                    break;
                case 19:
                    solid = Color.Crimson;
                    break;
                case 20:
                    solid = Color.DarkCyan;
                    break;
                case 21:
                    solid = Color.DarkGoldenrod;
                    break;
                case 22:
                    solid = Color.DarkGreen;
                    break;
                case 23:
                    solid = Color.DarkMagenta;
                    break;
                case 24:
                    solid = Color.DarkOliveGreen;
                    break;
                case 25:
                    solid = Color.DarkOrange;
                    break;
                case 26:
                    solid = Color.DarkOrchid;
                    break;
                case 27:
                    solid = Color.DarkRed;
                    break;
                case 28:
                    solid = Color.CornflowerBlue;
                    break;
                case 29:
                    solid = Color.Chocolate;
                    break;
                case 30:
                    solid = Color.Blue;
                    break;
                case 31:
                    solid = Color.BlueViolet;
                    break;
                case 32:
                    solid = Color.Brown;
                    break;
                case 33:
                    solid = Color.DarkSlateBlue;
                    break;
                case 34:
                    solid = Color.DarkBlue;
                    break;
                case 35:
                    solid = Color.HotPink;
                    break;
                case 36:
                    solid = Color.IndianRed;
                    break;
                case 37:
                    solid = Color.Indigo;
                    break;
                case 38:
                    solid = Color.DarkSlateGray;
                    break;
                case 39:
                    solid = Color.Green;
                    break;
                case 40:
                    solid = Color.DarkViolet;
                    break;
                case 41:
                    solid = Color.DeepPink;
                    break;
                case 42:
                    solid = Color.DeepSkyBlue;
                    break;
                case 43:
                    solid = Color.DodgerBlue;
                    break;
                case 44:
                    solid = Color.Firebrick;
                    break;
                case 45:
                    solid = Color.Fuchsia;
                    break;
                case 46:
                    solid = Color.Goldenrod;
                    break;
                case 47:
                    solid = Color.Gold;
                    break;
                case 48:
                    solid = Color.ForestGreen;
                    break;

                default:
                    solid = Color.IndianRed;
                    break;


            }
            return solid;
        }
        public static Color GetRandomLightColor()
        {
            var solid = Color.MistyRose;
            Random random = new Random();
            var num = random.Next(1, 37);
            switch (num)
            {
                case 1:
                    solid = Color.Moccasin;
                    break;
                case 2:
                    solid = Color.NavajoWhite;
                    break;
                case 3:
                    solid = Color.PaleGoldenrod;
                    break;
                case 4:
                    solid = Color.PaleGreen;
                    break;
                case 5:
                    solid = Color.PaleTurquoise;
                    break;
                case 6:
                    solid = Color.MediumSpringGreen;
                    break;
                case 7:
                    solid = Color.LightSkyBlue;
                    break;
                case 8:
                    solid = Color.LightSteelBlue;
                    break;
                case 9:
                    solid = Color.LightYellow;
                    break;
                case 10:
                    solid = Color.MediumTurquoise;
                    break;
                case 11:
                    solid = Color.Linen;
                    break;
                case 12:
                    solid = Color.MediumAquamarine;
                    break;
                case 13:
                    solid = Color.PapayaWhip;
                    break;
                case 14:
                    solid = Color.Tan;
                    break;
                case 15:
                    solid = Color.Thistle;
                    break;
                case 16:
                    solid = Color.Wheat;
                    break;
                case 17:
                    solid = Color.Turquoise;
                    break;
                case 18:
                    solid = Color.PeachPuff;
                    break;
                case 19:
                    solid = Color.SkyBlue;
                    break;
                case 20:
                    solid = Color.Pink;
                    break;
                case 21:
                    solid = Color.Plum;
                    break;
                case 22:
                    solid = Color.PowderBlue;
                    break;
                case 23:
                    solid = Color.RosyBrown;
                    break;
                case 24:
                    solid = Color.LightSalmon;
                    break;
                case 25:
                    solid = Color.LightGreen;
                    break;
                case 26:
                    solid = Color.LightPink;
                    break;
                case 27:
                    solid = Color.Aqua;
                    break;
                case 28:
                    solid = Color.Aquamarine;
                    break;
                case 29:
                    solid = Color.Bisque;
                    break;
                case 30:
                    solid = Color.Coral;
                    break;
                case 31:
                    solid = Color.BurlyWood;
                    break;
                case 32:
                    solid = Color.CadetBlue;
                    break;
                case 33:
                    solid = Color.DarkTurquoise;
                    break;
                case 34:
                    solid = Color.Khaki;
                    break;
                case 35:
                    solid = Color.Lavender;
                    break;
                case 36:
                    solid = Color.LavenderBlush;
                    break;
                case 37:
                    solid = Color.LightBlue;
                    break;
                default:
                    solid = Color.Coral;
                    break;
            }
            return solid;
        }
        public static Color GetRandomDefaultColor()
        {
            var solid = Color.IndianRed;
            Random random = new Random();
            var num = random.Next(1, 48);
            switch (num)
            {
                case 1:
                    solid = Color.Navy;
                    break;
                case 2:
                    solid = Color.MidnightBlue;
                    break;
                case 3:
                    solid = Color.Olive;
                    break;
                case 4:
                    solid = Color.OrangeRed;
                    break;
                case 5:
                    solid = Color.OliveDrab;
                    break;
                case 6:
                    solid = Color.PaleVioletRed;
                    break;
                case 7:
                    solid = Color.MediumVioletRed;
                    break;
                case 8:
                    solid = Color.Maroon;
                    break;
                case 9:
                    solid = Color.MediumBlue;
                    break;
                case 10:
                    solid = Color.YellowGreen;
                    break;
                case 11:
                    solid = Color.Purple;
                    break;
                case 12:
                    solid = Color.Red;
                    break;
                case 13:
                    solid = Color.SlateBlue;
                    break;
                case 14:
                    solid = Color.RoyalBlue;
                    break;
                case 15:
                    solid = Color.Salmon;
                    break;
                case 16:
                    solid = Color.SeaGreen;
                    break;
                case 17:
                    solid = Color.Sienna;
                    break;
                case 18:
                    solid = Color.SaddleBrown;
                    break;
                case 19:
                    solid = Color.Crimson;
                    break;
                case 20:
                    solid = Color.DarkCyan;
                    break;
                case 21:
                    solid = Color.DarkGoldenrod;
                    break;
                case 22:
                    solid = Color.DarkGreen;
                    break;
                case 23:
                    solid = Color.DarkMagenta;
                    break;
                case 24:
                    solid = Color.DarkOliveGreen;
                    break;
                case 25:
                    solid = Color.DarkOrange;
                    break;
                case 26:
                    solid = Color.DarkOrchid;
                    break;
                case 27:
                    solid = Color.DarkRed;
                    break;
                case 28:
                    solid = Color.CornflowerBlue;
                    break;
                case 29:
                    solid = Color.Chocolate;
                    break;
                case 30:
                    solid = Color.Blue;
                    break;
                case 31:
                    solid = Color.BlueViolet;
                    break;
                case 32:
                    solid = Color.Brown;
                    break;
                case 33:
                    solid = Color.DarkSlateBlue;
                    break;
                case 34:
                    solid = Color.DarkBlue;
                    break;
                case 35:
                    solid = Color.HotPink;
                    break;
                case 36:
                    solid = Color.IndianRed;
                    break;
                case 37:
                    solid = Color.Indigo;
                    break;
                case 38:
                    solid = Color.DarkSlateGray;
                    break;
                case 39:
                    solid = Color.Green;
                    break;
                case 40:
                    solid = Color.DarkViolet;
                    break;
                case 41:
                    solid = Color.DeepPink;
                    break;
                case 42:
                    solid = Color.DeepSkyBlue;
                    break;
                case 43:
                    solid = Color.DodgerBlue;
                    break;
                case 44:
                    solid = Color.Firebrick;
                    break;
                case 45:
                    solid = Color.Fuchsia;
                    break;
                case 46:
                    solid = Color.Goldenrod;
                    break;
                case 47:
                    solid = Color.Gold;
                    break;
                case 48:
                    solid = Color.ForestGreen;
                    break;

                default:
                    solid = Color.IndianRed;
                    break;


            }
            return solid;
        }
        public static List<ColorItem> GetSystemColorList()
        {
            var colors = new List<ColorItem>();
            colors.Add(new ColorItem() { Color = Color.AliceBlue, Name = "AliceBlue" });
            colors.Add(new ColorItem() { Color = Color.MintCream, Name = "MintCream" });
            colors.Add(new ColorItem() { Color = Color.MistyRose, Name = "MistyRose" });
            colors.Add(new ColorItem() { Color = Color.Moccasin, Name = "Moccasin" });
            colors.Add(new ColorItem() { Color = Color.NavajoWhite, Name = "NavajoWhite" });
            colors.Add(new ColorItem() { Color = Color.Navy, Name = "Navy" });
            colors.Add(new ColorItem() { Color = Color.OldLace, Name = "OldLace" });
            colors.Add(new ColorItem() { Color = Color.MidnightBlue, Name = "MidnightBlue" });
            colors.Add(new ColorItem() { Color = Color.Olive, Name = "Olive" });
            colors.Add(new ColorItem() { Color = Color.Orange, Name = "Orange" });
            colors.Add(new ColorItem() { Color = Color.OrangeRed, Name = "OrangeRed" });
            colors.Add(new ColorItem() { Color = Color.Orchid, Name = "Orchid" });
            colors.Add(new ColorItem() { Color = Color.PaleGoldenrod, Name = "PaleGoldenrod" });
            colors.Add(new ColorItem() { Color = Color.PaleGreen, Name = "PaleGreen" });
            colors.Add(new ColorItem() { Color = Color.PaleTurquoise, Name = "PaleTurquoise" });
            colors.Add(new ColorItem() { Color = Color.OliveDrab, Name = "OliveDrab" });
            colors.Add(new ColorItem() { Color = Color.PaleVioletRed, Name = "PaleVioletRed" });
            colors.Add(new ColorItem() { Color = Color.MediumVioletRed, Name = "MediumVioletRed" });
            colors.Add(new ColorItem() { Color = Color.MediumSpringGreen, Name = "MediumSpringGreen" });
            colors.Add(new ColorItem() { Color = Color.LightSkyBlue, Name = "LightSkyBlue" });
            colors.Add(new ColorItem() { Color = Color.LightSlateGray, Name = "LightSlateGray" });
            colors.Add(new ColorItem() { Color = Color.LightSteelBlue, Name = "LightSteelBlue" });
            colors.Add(new ColorItem() { Color = Color.LightYellow, Name = "LightYellow" });
            colors.Add(new ColorItem() { Color = Color.Lime, Name = "Lime" });
            colors.Add(new ColorItem() { Color = Color.LimeGreen, Name = "LimeGreen" });
            colors.Add(new ColorItem() { Color = Color.MediumTurquoise, Name = "MediumTurquoise" });
            colors.Add(new ColorItem() { Color = Color.Linen, Name = "Linen" });
            colors.Add(new ColorItem() { Color = Color.Maroon, Name = "Maroon" });
            colors.Add(new ColorItem() { Color = Color.MediumAquamarine, Name = "MediumAquamarine" });
            colors.Add(new ColorItem() { Color = Color.MediumBlue, Name = "MediumBlue" });
            colors.Add(new ColorItem() { Color = Color.MediumOrchid, Name = "MediumOrchid" });
            colors.Add(new ColorItem() { Color = Color.MediumSeaGreen, Name = "MediumSeaGreen" });
            colors.Add(new ColorItem() { Color = Color.MediumSlateBlue, Name = "MediumSlateBlue" });
            colors.Add(new ColorItem() { Color = Color.Magenta, Name = "Magenta" });
            colors.Add(new ColorItem() { Color = Color.LightSeaGreen, Name = "LightSeaGreen" });
            colors.Add(new ColorItem() { Color = Color.PapayaWhip, Name = "PapayaWhip" });
            colors.Add(new ColorItem() { Color = Color.Peru, Name = "Peru" });
            colors.Add(new ColorItem() { Color = Color.SpringGreen, Name = "SpringGreen" });
            colors.Add(new ColorItem() { Color = Color.SteelBlue, Name = "SteelBlue" });
            colors.Add(new ColorItem() { Color = Color.Tan, Name = "Tan" });
            colors.Add(new ColorItem() { Color = Color.Teal, Name = "Teal" });
            colors.Add(new ColorItem() { Color = Color.Thistle, Name = "Thistle" });
            colors.Add(new ColorItem() { Color = Color.Tomato, Name = "Tomato" });
            colors.Add(new ColorItem() { Color = Color.Snow, Name = "Snow" });
            colors.Add(new ColorItem() { Color = Color.Transparent, Name = "Transparent" });
            colors.Add(new ColorItem() { Color = Color.Violet, Name = "Violet" });
            colors.Add(new ColorItem() { Color = Color.Wheat, Name = "Wheat" });
            colors.Add(new ColorItem() { Color = Color.White, Name = "White" });
            colors.Add(new ColorItem() { Color = Color.WhiteSmoke, Name = "WhiteSmoke" });
            colors.Add(new ColorItem() { Color = Color.Yellow, Name = "Yellow" });
            colors.Add(new ColorItem() { Color = Color.YellowGreen, Name = "YellowGreen" });
            colors.Add(new ColorItem() { Color = Color.Turquoise, Name = "Turquoise" });
            colors.Add(new ColorItem() { Color = Color.PeachPuff, Name = "PeachPuff" });
            colors.Add(new ColorItem() { Color = Color.SlateGray, Name = "SlateGray" });
            colors.Add(new ColorItem() { Color = Color.SkyBlue, Name = "SkyBlue" });
            colors.Add(new ColorItem() { Color = Color.Pink, Name = "Pink" });
            colors.Add(new ColorItem() { Color = Color.Plum, Name = "Plum" });
            colors.Add(new ColorItem() { Color = Color.PowderBlue, Name = "PowderBlue" });
            colors.Add(new ColorItem() { Color = Color.Purple, Name = "Purple" });
            colors.Add(new ColorItem() { Color = Color.Red, Name = "Red" });
            colors.Add(new ColorItem() { Color = Color.RosyBrown, Name = "RosyBrown" });
            colors.Add(new ColorItem() { Color = Color.SlateBlue, Name = "SlateBlue" });
            colors.Add(new ColorItem() { Color = Color.RoyalBlue, Name = "RoyalBlue" });
            colors.Add(new ColorItem() { Color = Color.Salmon, Name = "Salmon" });
            colors.Add(new ColorItem() { Color = Color.SandyBrown, Name = "SandyBrown" });
            colors.Add(new ColorItem() { Color = Color.SeaGreen, Name = "SeaGreen" });
            colors.Add(new ColorItem() { Color = Color.SeaShell, Name = "SeaShell" });
            colors.Add(new ColorItem() { Color = Color.Sienna, Name = "Sienna" });
            colors.Add(new ColorItem() { Color = Color.Silver, Name = "Silver" });
            colors.Add(new ColorItem() { Color = Color.SaddleBrown, Name = "SaddleBrown" });
            colors.Add(new ColorItem() { Color = Color.LightSalmon, Name = "LightSalmon" });
            colors.Add(new ColorItem() { Color = Color.MediumPurple, Name = "MediumPurple" });
            colors.Add(new ColorItem() { Color = Color.LightGreen, Name = "LightGreen" });
            colors.Add(new ColorItem() { Color = Color.Crimson, Name = "Crimson" });
            colors.Add(new ColorItem() { Color = Color.Cyan, Name = "Cyan" });
            colors.Add(new ColorItem() { Color = Color.LightPink, Name = "LightPink" });
            colors.Add(new ColorItem() { Color = Color.DarkCyan, Name = "DarkCyan" });
            colors.Add(new ColorItem() { Color = Color.DarkGoldenrod, Name = "DarkGoldenrod" });
            colors.Add(new ColorItem() { Color = Color.DarkGray, Name = "DarkGray" });
            colors.Add(new ColorItem() { Color = Color.Cornsilk, Name = "Cornsilk" });
            colors.Add(new ColorItem() { Color = Color.DarkGreen, Name = "DarkGreen" });
            colors.Add(new ColorItem() { Color = Color.DarkMagenta, Name = "DarkMagenta" });
            colors.Add(new ColorItem() { Color = Color.DarkOliveGreen, Name = "DarkOliveGreen" });
            colors.Add(new ColorItem() { Color = Color.DarkOrange, Name = "DarkOrange" });
            colors.Add(new ColorItem() { Color = Color.DarkOrchid, Name = "DarkOrchid" });
            colors.Add(new ColorItem() { Color = Color.DarkRed, Name = "DarkRed" });
            colors.Add(new ColorItem() { Color = Color.DarkSalmon, Name = "DarkSalmon" });
            colors.Add(new ColorItem() { Color = Color.DarkKhaki, Name = "DarkKhaki" });
            colors.Add(new ColorItem() { Color = Color.DarkSeaGreen, Name = "DarkSeaGreen" });
            colors.Add(new ColorItem() { Color = Color.CornflowerBlue, Name = "CornflowerBlue" });
            colors.Add(new ColorItem() { Color = Color.Chocolate, Name = "Chocolate" });
            colors.Add(new ColorItem() { Color = Color.AntiqueWhite, Name = "AntiqueWhite" });
            colors.Add(new ColorItem() { Color = Color.Aqua, Name = "Aqua" });
            colors.Add(new ColorItem() { Color = Color.Aquamarine, Name = "Aquamarine" });
            colors.Add(new ColorItem() { Color = Color.Azure, Name = "Azure" });
            colors.Add(new ColorItem() { Color = Color.Beige, Name = "Beige" });
            colors.Add(new ColorItem() { Color = Color.Bisque, Name = "Bisque" });
            colors.Add(new ColorItem() { Color = Color.Coral, Name = "Coral" });
            colors.Add(new ColorItem() { Color = Color.Black, Name = "Black" });
            colors.Add(new ColorItem() { Color = Color.Blue, Name = "Blue" });
            colors.Add(new ColorItem() { Color = Color.BlueViolet, Name = "BlueViolet" });
            colors.Add(new ColorItem() { Color = Color.Brown, Name = "Brown" });
            colors.Add(new ColorItem() { Color = Color.BurlyWood, Name = "BurlyWood" });
            colors.Add(new ColorItem() { Color = Color.CadetBlue, Name = "CadetBlue" });
            colors.Add(new ColorItem() { Color = Color.Chartreuse, Name = "Chartreuse" });
            colors.Add(new ColorItem() { Color = Color.BlanchedAlmond, Name = "BlanchedAlmond" });
            colors.Add(new ColorItem() { Color = Color.DarkSlateBlue, Name = "DarkSlateBlue" });
            colors.Add(new ColorItem() { Color = Color.DarkBlue, Name = "DarkBlue" });
            colors.Add(new ColorItem() { Color = Color.DarkTurquoise, Name = "DarkTurquoise" });
            colors.Add(new ColorItem() { Color = Color.HotPink, Name = "HotPink" });
            colors.Add(new ColorItem() { Color = Color.IndianRed, Name = "IndianRed" });
            colors.Add(new ColorItem() { Color = Color.Indigo, Name = "Indigo" });
            colors.Add(new ColorItem() { Color = Color.Ivory, Name = "Ivory" });
            colors.Add(new ColorItem() { Color = Color.Khaki, Name = "Khaki" });
            colors.Add(new ColorItem() { Color = Color.Lavender, Name = "Lavender" });
            colors.Add(new ColorItem() { Color = Color.Honeydew, Name = "Honeydew" });
            colors.Add(new ColorItem() { Color = Color.LavenderBlush, Name = "LavenderBlush" });
            colors.Add(new ColorItem() { Color = Color.LemonChiffon, Name = "LemonChiffon" });
            colors.Add(new ColorItem() { Color = Color.LightBlue, Name = "LightBlue" });
            colors.Add(new ColorItem() { Color = Color.LightCoral, Name = "LightCoral" });
            colors.Add(new ColorItem() { Color = Color.DarkSlateGray, Name = "DarkSlateGray" });
            colors.Add(new ColorItem() { Color = Color.LightGoldenrodYellow, Name = "LightGoldenrodYellow" });
            colors.Add(new ColorItem() { Color = Color.LightGray, Name = "LightGray" });
            colors.Add(new ColorItem() { Color = Color.Gray, Name = "Gray" });
            colors.Add(new ColorItem() { Color = Color.Green, Name = "Green" });
            colors.Add(new ColorItem() { Color = Color.DarkViolet, Name = "DarkViolet" });
            colors.Add(new ColorItem() { Color = Color.DeepPink, Name = "DeepPink" });
            colors.Add(new ColorItem() { Color = Color.DeepSkyBlue, Name = "DeepSkyBlue" });
            colors.Add(new ColorItem() { Color = Color.DodgerBlue, Name = "DodgerBlue" });
            colors.Add(new ColorItem() { Color = Color.Firebrick, Name = "Firebrick" });
            colors.Add(new ColorItem() { Color = Color.FloralWhite, Name = "FloralWhite" });
            colors.Add(new ColorItem() { Color = Color.DimGray, Name = "DimGray" });
            colors.Add(new ColorItem() { Color = Color.Fuchsia, Name = "Fuchsia" });
            colors.Add(new ColorItem() { Color = Color.Gainsboro, Name = "Gainsboro" });
            colors.Add(new ColorItem() { Color = Color.Goldenrod, Name = "Goldenrod" });
            colors.Add(new ColorItem() { Color = Color.GhostWhite, Name = "GhostWhite" });
            colors.Add(new ColorItem() { Color = Color.Gold, Name = "Gold" });
            colors.Add(new ColorItem() { Color = Color.ForestGreen, Name = "ForestGreen" });

            return colors;
        }

    }
    public class ColorItem
    {
        public Color Color { get; set; } = Color.Red;
        public string Name { get; set; }
        public string Representation { get { return this.Color.ToString(); } }
    }
    #endregion
    


}