using UnityEngine;
using UnityEditor;

namespace AnnulusGames.LucidTools.Editor
{
	public static class EditorIcons
	{
		public static GUIContent GetComponentIcon<T>()
		{
			GUIContent icon = EditorGUIUtility.ObjectContent(null, typeof(T));
			icon.text = string.Empty;
			return icon;
		}

		public static GUIContent FullScreen { get { return EditorGUIUtility.IconContent("_fullscreen"); } }
		public static GUIContent FullScreen2x { get { return EditorGUIUtility.IconContent("_fullscreen@2x"); } }
		public static GUIContent Help { get { return EditorGUIUtility.IconContent("_help"); } }
		public static GUIContent Help2x { get { return EditorGUIUtility.IconContent("_help@2x"); } }
		public static GUIContent Menu { get { return EditorGUIUtility.IconContent("_menu"); } }
		public static GUIContent Menu2x { get { return EditorGUIUtility.IconContent("_menu@2x"); } }
		public static GUIContent Popup { get { return EditorGUIUtility.IconContent("_popup"); } }
		public static GUIContent Popup2x { get { return EditorGUIUtility.IconContent("_popup@2x"); } }
		public static GUIContent AboutWindowMainHeader { get { return EditorGUIUtility.IconContent("aboutwindow.mainheader"); } }
		public static GUIContent AboutWindowMainHeader2x { get { return EditorGUIUtility.IconContent("aboutwindow.mainheader@2x"); } }
		public static GUIContent AgeiaLogo { get { return EditorGUIUtility.IconContent("ageialogo"); } }
		public static GUIContent AlphabeticalSorting { get { return EditorGUIUtility.IconContent("alphabeticalsorting"); } }
		public static GUIContent AlphabeticalSorting2x { get { return EditorGUIUtility.IconContent("alphabeticalsorting@2x"); } }
		public static GUIContent AnchorTransformToolOn { get { return EditorGUIUtility.IconContent("anchortransformtool on"); } }
		public static GUIContent AnchorTransformToolOn2x { get { return EditorGUIUtility.IconContent("anchortransformtool on@2x"); } }
		public static GUIContent AnchorTransformTool { get { return EditorGUIUtility.IconContent("anchortransformtool"); } }
		public static GUIContent AnchorTransformTool2x { get { return EditorGUIUtility.IconContent("anchortransformtool@2x"); } }
		public static GUIContent AnimationAddEvent { get { return EditorGUIUtility.IconContent("animation.addevent"); } }
		public static GUIContent AnimationAddEvent2x { get { return EditorGUIUtility.IconContent("animation.addevent@2x"); } }
		public static GUIContent AnimationAddKeyFrame { get { return EditorGUIUtility.IconContent("animation.addkeyframe"); } }
		public static GUIContent AnimationAddKeyFrame2x { get { return EditorGUIUtility.IconContent("animation.addkeyframe@2x"); } }
		public static GUIContent AnimationEventMarker { get { return EditorGUIUtility.IconContent("animation.eventmarker"); } }
		public static GUIContent AnimationEventMarker2x { get { return EditorGUIUtility.IconContent("animation.eventmarker@2x"); } }
		public static GUIContent AnimationFilterBySelection { get { return EditorGUIUtility.IconContent("animation.filterbyselection"); } }
		public static GUIContent AnimationFilterBySelection2x { get { return EditorGUIUtility.IconContent("animation.filterbyselection@2x"); } }
		public static GUIContent AnimationFirstKey { get { return EditorGUIUtility.IconContent("animation.firstkey"); } }
		public static GUIContent AnimationFirstKey2x { get { return EditorGUIUtility.IconContent("animation.firstkey@2x"); } }
		public static GUIContent AnimationLastKey { get { return EditorGUIUtility.IconContent("animation.lastkey"); } }
		public static GUIContent AnimationLastKey2x { get { return EditorGUIUtility.IconContent("animation.lastkey@2x"); } }
		public static GUIContent AnimationNextKey { get { return EditorGUIUtility.IconContent("animation.nextkey"); } }
		public static GUIContent AnimationNextKey2x { get { return EditorGUIUtility.IconContent("animation.nextkey@2x"); } }
		public static GUIContent AnimationPlay { get { return EditorGUIUtility.IconContent("animation.play"); } }
		public static GUIContent AnimationPlay2x { get { return EditorGUIUtility.IconContent("animation.play@2x"); } }
		public static GUIContent AnimationPrevKey { get { return EditorGUIUtility.IconContent("animation.prevkey"); } }
		public static GUIContent AnimationPrevKey2x { get { return EditorGUIUtility.IconContent("animation.prevkey@2x"); } }
		public static GUIContent AnimationRecord { get { return EditorGUIUtility.IconContent("animation.record"); } }
		public static GUIContent AnimationRecord2x { get { return EditorGUIUtility.IconContent("animation.record@2x"); } }
		public static GUIContent AnimationSequencerLink { get { return EditorGUIUtility.IconContent("animation.sequencerlink"); } }
		public static GUIContent AnimationAnimated { get { return EditorGUIUtility.IconContent("animationanimated"); } }
		public static GUIContent AnimationAnimated2x { get { return EditorGUIUtility.IconContent("animationanimated@2x"); } }
		public static GUIContent AnimationDopesheetKeyFrame { get { return EditorGUIUtility.IconContent("animationdopesheetkeyframe"); } }
		public static GUIContent AnimationKeyFrame { get { return EditorGUIUtility.IconContent("animationkeyframe"); } }
		public static GUIContent AnimationKeyFrame2x { get { return EditorGUIUtility.IconContent("animationkeyframe@2x"); } }
		public static GUIContent AnimationNoCurve { get { return EditorGUIUtility.IconContent("animationnocurve"); } }
		public static GUIContent AnimationVisibilityToggleOff { get { return EditorGUIUtility.IconContent("animationvisibilitytoggleoff"); } }
		public static GUIContent AnimationVisibilityToggleOff2x { get { return EditorGUIUtility.IconContent("animationvisibilitytoggleoff@2x"); } }
		public static GUIContent AnimationVisibilityToggleOn { get { return EditorGUIUtility.IconContent("animationvisibilitytoggleon"); } }
		public static GUIContent AnimationVisibilityToggleOn2x { get { return EditorGUIUtility.IconContent("animationvisibilitytoggleon@2x"); } }
		public static GUIContent AnimationWrapModeMenu { get { return EditorGUIUtility.IconContent("animationwrapmodemenu"); } }
		public static GUIContent AssemblyLock { get { return EditorGUIUtility.IconContent("assemblylock"); } }
		public static GUIContent AssetStore { get { return EditorGUIUtility.IconContent("asset store"); } }
		public static GUIContent AssetStore2x { get { return EditorGUIUtility.IconContent("asset store@2x"); } }
		public static GUIContent AssetStoreLogo { get { return EditorGUIUtility.IconContent("assetstore/unity-assetstore-originals-logo-white"); } }
		public static GUIContent AssetStoreLogo2x { get { return EditorGUIUtility.IconContent("assetstore/unity-assetstore-originals-logo-white@2x"); } }
		public static GUIContent AudioMixer { get { return EditorGUIUtility.IconContent("audio mixer"); } }
		public static GUIContent AudioMixer2x { get { return EditorGUIUtility.IconContent("audio mixer@2x"); } }
		public static GUIContent AutoLightBakingOff { get { return EditorGUIUtility.IconContent("autolightbakingoff"); } }
		public static GUIContent AutoLightBakingOff2x { get { return EditorGUIUtility.IconContent("autolightbakingoff@2x"); } }
		public static GUIContent AutoLightBakingOn { get { return EditorGUIUtility.IconContent("autolightbakingon"); } }
		public static GUIContent AutoLightBakingOn2x { get { return EditorGUIUtility.IconContent("autolightbakingon@2x"); } }
		public static GUIContent AvatarCompass { get { return EditorGUIUtility.IconContent("avatarcompass"); } }
		public static GUIContent AvatarControllerLayer { get { return EditorGUIUtility.IconContent("avatarcontroller.layer"); } }
		public static GUIContent AvatarControllerLayerHover { get { return EditorGUIUtility.IconContent("avatarcontroller.layerhover"); } }
		public static GUIContent AvatarControllerLayerSelected { get { return EditorGUIUtility.IconContent("avatarcontroller.layerselected"); } }
		public static GUIContent BodyPartPicker { get { return EditorGUIUtility.IconContent("avatarinspector/bodypartpicker"); } }
		public static GUIContent BodySilhouette { get { return EditorGUIUtility.IconContent("avatarinspector/bodysilhouette"); } }
		public static GUIContent DotFill { get { return EditorGUIUtility.IconContent("avatarinspector/dotfill"); } }
		public static GUIContent DotFrame { get { return EditorGUIUtility.IconContent("avatarinspector/dotframe"); } }
		public static GUIContent DotFrameDotted { get { return EditorGUIUtility.IconContent("avatarinspector/dotframedotted"); } }
		public static GUIContent DotSelection { get { return EditorGUIUtility.IconContent("avatarinspector/dotselection"); } }
		public static GUIContent Head { get { return EditorGUIUtility.IconContent("avatarinspector/head"); } }
		public static GUIContent HeadIk { get { return EditorGUIUtility.IconContent("avatarinspector/headik"); } }
		public static GUIContent HeadZoom { get { return EditorGUIUtility.IconContent("avatarinspector/headzoom"); } }
		public static GUIContent HeadZoomSilhouette { get { return EditorGUIUtility.IconContent("avatarinspector/headzoomsilhouette"); } }
		public static GUIContent LeftArm { get { return EditorGUIUtility.IconContent("avatarinspector/leftarm"); } }
		public static GUIContent LeftFeetIk { get { return EditorGUIUtility.IconContent("avatarinspector/leftfeetik"); } }
		public static GUIContent LeftFingers { get { return EditorGUIUtility.IconContent("avatarinspector/leftfingers"); } }
		public static GUIContent LeftFingersIk { get { return EditorGUIUtility.IconContent("avatarinspector/leftfingersik"); } }
		public static GUIContent LeftHandZoom { get { return EditorGUIUtility.IconContent("avatarinspector/lefthandzoom"); } }
		public static GUIContent LeftHandZoomSilhouette { get { return EditorGUIUtility.IconContent("avatarinspector/lefthandzoomsilhouette"); } }
		public static GUIContent LeftLeg { get { return EditorGUIUtility.IconContent("avatarinspector/leftleg"); } }
		public static GUIContent MaskEditorRoot { get { return EditorGUIUtility.IconContent("avatarinspector/maskeditor_root"); } }
		public static GUIContent RightArm { get { return EditorGUIUtility.IconContent("avatarinspector/rightarm"); } }
		public static GUIContent RightFeetIk { get { return EditorGUIUtility.IconContent("avatarinspector/rightfeetik"); } }
		public static GUIContent RightFingers { get { return EditorGUIUtility.IconContent("avatarinspector/rightfingers"); } }
		public static GUIContent RightFingersIk { get { return EditorGUIUtility.IconContent("avatarinspector/rightfingersik"); } }
		public static GUIContent RightHandZoom { get { return EditorGUIUtility.IconContent("avatarinspector/righthandzoom"); } }
		public static GUIContent RightHandZoomSilhouette { get { return EditorGUIUtility.IconContent("avatarinspector/righthandzoomsilhouette"); } }
		public static GUIContent RightLeg { get { return EditorGUIUtility.IconContent("avatarinspector/rightleg"); } }
		public static GUIContent Torso { get { return EditorGUIUtility.IconContent("avatarinspector/torso"); } }
		public static GUIContent AvatarPivot { get { return EditorGUIUtility.IconContent("avatarpivot"); } }
		public static GUIContent AvatarPivot2x { get { return EditorGUIUtility.IconContent("avatarpivot@2x"); } }
		public static GUIContent AvatarSelector { get { return EditorGUIUtility.IconContent("avatarselector"); } }
		public static GUIContent AvatarSelector2x { get { return EditorGUIUtility.IconContent("avatarselector@2x"); } }
		public static GUIContent Back { get { return EditorGUIUtility.IconContent("back"); } }
		public static GUIContent Back2x { get { return EditorGUIUtility.IconContent("back@2x"); } }
		public static GUIContent BeginButtonOn { get { return EditorGUIUtility.IconContent("beginbutton-on"); } }
		public static GUIContent BeginButton { get { return EditorGUIUtility.IconContent("beginbutton"); } }
		public static GUIContent BlendKey { get { return EditorGUIUtility.IconContent("blendkey"); } }
		public static GUIContent BlendKey2x { get { return EditorGUIUtility.IconContent("blendkey@2x"); } }
		public static GUIContent BlendKeyOverlay { get { return EditorGUIUtility.IconContent("blendkeyoverlay"); } }
		public static GUIContent BlendKeyOverlay2x { get { return EditorGUIUtility.IconContent("blendkeyoverlay@2x"); } }
		public static GUIContent BlendKeySelected { get { return EditorGUIUtility.IconContent("blendkeyselected"); } }
		public static GUIContent BlendKeySelected2x { get { return EditorGUIUtility.IconContent("blendkeyselected@2x"); } }
		public static GUIContent BlendSampler { get { return EditorGUIUtility.IconContent("blendsampler"); } }
		public static GUIContent BlueGroove { get { return EditorGUIUtility.IconContent("bluegroove"); } }
		public static GUIContent BuildSettingsAndroidOn { get { return EditorGUIUtility.IconContent("buildsettings.android on"); } }
		public static GUIContent BuildSettingsAndroidOn2x { get { return EditorGUIUtility.IconContent("buildsettings.android on@2x"); } }
		public static GUIContent BuildSettingsAndroid { get { return EditorGUIUtility.IconContent("buildsettings.android"); } }
		public static GUIContent BuildSettingsAndroidSmall { get { return EditorGUIUtility.IconContent("buildsettings.android.small"); } }
		public static GUIContent BuildSettingsAndroidSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.android.small@2x"); } }
		public static GUIContent BuildSettingsAndroid2x { get { return EditorGUIUtility.IconContent("buildsettings.android@2x"); } }
		public static GUIContent BuildSettingsBroadcom { get { return EditorGUIUtility.IconContent("buildsettings.broadcom"); } }
		public static GUIContent BuildSettingsDedicatedServerOn { get { return EditorGUIUtility.IconContent("buildsettings.dedicatedserver on"); } }
		public static GUIContent BuildSettingsDedicatedServerOn2x { get { return EditorGUIUtility.IconContent("buildsettings.dedicatedserver on@2x"); } }
		public static GUIContent BuildSettingsDedicatedServer { get { return EditorGUIUtility.IconContent("buildsettings.dedicatedserver"); } }
		public static GUIContent BuildSettingsDedicatedServerSmall { get { return EditorGUIUtility.IconContent("buildsettings.dedicatedserver.small"); } }
		public static GUIContent BuildSettingsDedicatedServerSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.dedicatedserver.small@2x"); } }
		public static GUIContent BuildSettingsDedicatedServer2x { get { return EditorGUIUtility.IconContent("buildsettings.dedicatedserver@2x"); } }
		public static GUIContent BuildSettingsEditor { get { return EditorGUIUtility.IconContent("buildsettings.editor"); } }
		public static GUIContent BuildSettingsEditorSmall { get { return EditorGUIUtility.IconContent("buildsettings.editor.small"); } }
		public static GUIContent BuildSettingsEmbeddedLinuxOn { get { return EditorGUIUtility.IconContent("buildsettings.embeddedlinux on"); } }
		public static GUIContent BuildSettingsEmbeddedLinuxOn2x { get { return EditorGUIUtility.IconContent("buildsettings.embeddedlinux on@2x"); } }
		public static GUIContent BuildSettingsEmbeddedLinux { get { return EditorGUIUtility.IconContent("buildsettings.embeddedlinux"); } }
		public static GUIContent BuildSettingsEmbeddedLinuxSmall { get { return EditorGUIUtility.IconContent("buildsettings.embeddedlinux.small"); } }
		public static GUIContent BuildSettingsEmbeddedLinuxSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.embeddedlinux.small@2x"); } }
		public static GUIContent BuildSettingsEmbeddedLinux2x { get { return EditorGUIUtility.IconContent("buildsettings.embeddedlinux@2x"); } }
		public static GUIContent BuildSettingsFacebookOn { get { return EditorGUIUtility.IconContent("buildsettings.facebook on"); } }
		public static GUIContent BuildSettingsFacebookOn2x { get { return EditorGUIUtility.IconContent("buildsettings.facebook on@2x"); } }
		public static GUIContent BuildSettingsFacebook { get { return EditorGUIUtility.IconContent("buildsettings.facebook"); } }
		public static GUIContent BuildSettingsFacebookSmall { get { return EditorGUIUtility.IconContent("buildsettings.facebook.small"); } }
		public static GUIContent BuildSettingsFacebookSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.facebook.small@2x"); } }
		public static GUIContent BuildSettingsFacebook2x { get { return EditorGUIUtility.IconContent("buildsettings.facebook@2x"); } }
		public static GUIContent BuildSettingsFlashPlayer { get { return EditorGUIUtility.IconContent("buildsettings.flashplayer"); } }
		public static GUIContent BuildSettingsFlashPlayerSmall { get { return EditorGUIUtility.IconContent("buildsettings.flashplayer.small"); } }
		public static GUIContent BuildSettingsGameCoreScarlettOn { get { return EditorGUIUtility.IconContent("buildsettings.gamecorescarlett on"); } }
		public static GUIContent BuildSettingsGameCoreScarlettOn2x { get { return EditorGUIUtility.IconContent("buildsettings.gamecorescarlett on@2x"); } }
		public static GUIContent BuildSettingsGameCoreScarlett { get { return EditorGUIUtility.IconContent("buildsettings.gamecorescarlett"); } }
		public static GUIContent BuildSettingsGameCoreScarlettSmall { get { return EditorGUIUtility.IconContent("buildsettings.gamecorescarlett.small"); } }
		public static GUIContent BuildSettingsGameCoreScarlettSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.gamecorescarlett.small@2x"); } }
		public static GUIContent BuildSettingsGameCoreScarlett2x { get { return EditorGUIUtility.IconContent("buildsettings.gamecorescarlett@2x"); } }
		public static GUIContent BuildSettingsGameCoreXboxOneOn { get { return EditorGUIUtility.IconContent("buildsettings.gamecorexboxone on"); } }
		public static GUIContent BuildSettingsGameCoreXboxOneOn2x { get { return EditorGUIUtility.IconContent("buildsettings.gamecorexboxone on@2x"); } }
		public static GUIContent BuildSettingsGameCoreXboxOne { get { return EditorGUIUtility.IconContent("buildsettings.gamecorexboxone"); } }
		public static GUIContent BuildSettingsGameCoreXboxOneSmall { get { return EditorGUIUtility.IconContent("buildsettings.gamecorexboxone.small"); } }
		public static GUIContent BuildSettingsGameCoreXboxOneSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.gamecorexboxone.small@2x"); } }
		public static GUIContent BuildSettingsGameCoreXboxOne2x { get { return EditorGUIUtility.IconContent("buildsettings.gamecorexboxone@2x"); } }
		public static GUIContent BuildSettingsIPhoneOn { get { return EditorGUIUtility.IconContent("buildsettings.iphone on"); } }
		public static GUIContent BuildSettingsIPhoneOn2x { get { return EditorGUIUtility.IconContent("buildsettings.iphone on@2x"); } }
		public static GUIContent BuildSettingsIPhone { get { return EditorGUIUtility.IconContent("buildsettings.iphone"); } }
		public static GUIContent BuildSettingsIPhoneSmall { get { return EditorGUIUtility.IconContent("buildsettings.iphone.small"); } }
		public static GUIContent BuildSettingsIPhoneSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.iphone.small@2x"); } }
		public static GUIContent BuildSettingsIPhone2x { get { return EditorGUIUtility.IconContent("buildsettings.iphone@2x"); } }
		public static GUIContent BuildSettingsLinuxHeadlessSimulationOn { get { return EditorGUIUtility.IconContent("buildsettings.linuxheadlesssimulation on"); } }
		public static GUIContent BuildSettingsLinuxHeadlessSimulationOn2x { get { return EditorGUIUtility.IconContent("buildsettings.linuxheadlesssimulation on@2x"); } }
		public static GUIContent BuildSettingsLinuxHeadlessSimulation { get { return EditorGUIUtility.IconContent("buildsettings.linuxheadlesssimulation"); } }
		public static GUIContent BuildSettingsLinuxHeadlessSimulationSmall { get { return EditorGUIUtility.IconContent("buildsettings.linuxheadlesssimulation.small"); } }
		public static GUIContent BuildSettingsLinuxHeadlessSimulationSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.linuxheadlesssimulation.small@2x"); } }
		public static GUIContent BuildSettingsLinuxHeadlessSimulation2x { get { return EditorGUIUtility.IconContent("buildsettings.linuxheadlesssimulation@2x"); } }
		public static GUIContent BuildSettingsLuminOn { get { return EditorGUIUtility.IconContent("buildsettings.lumin on"); } }
		public static GUIContent BuildSettingsLuminOn2x { get { return EditorGUIUtility.IconContent("buildsettings.lumin on@2x"); } }
		public static GUIContent BuildSettingsLumin { get { return EditorGUIUtility.IconContent("buildsettings.lumin"); } }
		public static GUIContent BuildSettingsLuminSmall { get { return EditorGUIUtility.IconContent("buildsettings.lumin.small"); } }
		public static GUIContent BuildSettingsLuminSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.lumin.small@2x"); } }
		public static GUIContent BuildSettingsLumin2x { get { return EditorGUIUtility.IconContent("buildsettings.lumin@2x"); } }
		public static GUIContent BuildSettingsMetroOn { get { return EditorGUIUtility.IconContent("buildsettings.metro on"); } }
		public static GUIContent BuildSettingsMetroOn2x { get { return EditorGUIUtility.IconContent("buildsettings.metro on@2x"); } }
		public static GUIContent BuildSettingsMetro { get { return EditorGUIUtility.IconContent("buildsettings.metro"); } }
		public static GUIContent BuildSettingsMetroSmall { get { return EditorGUIUtility.IconContent("buildsettings.metro.small"); } }
		public static GUIContent BuildSettingsMetroSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.metro.small@2x"); } }
		public static GUIContent BuildSettingsMetro2x { get { return EditorGUIUtility.IconContent("buildsettings.metro@2x"); } }
		public static GUIContent BuildSettingsN3DSOn { get { return EditorGUIUtility.IconContent("buildsettings.n3ds on"); } }
		public static GUIContent BuildSettingsN3DSOn2x { get { return EditorGUIUtility.IconContent("buildsettings.n3ds on@2x"); } }
		public static GUIContent BuildSettingsN3DS { get { return EditorGUIUtility.IconContent("buildsettings.n3ds"); } }
		public static GUIContent BuildSettingsN3DSSmall { get { return EditorGUIUtility.IconContent("buildsettings.n3ds.small"); } }
		public static GUIContent BuildSettingsN3DSSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.n3ds.small@2x"); } }
		public static GUIContent BuildSettingsN3DS2x { get { return EditorGUIUtility.IconContent("buildsettings.n3ds@2x"); } }
		public static GUIContent BuildSettingsPS4On { get { return EditorGUIUtility.IconContent("buildsettings.ps4 on"); } }
		public static GUIContent BuildSettingsPS4On2x { get { return EditorGUIUtility.IconContent("buildsettings.ps4 on@2x"); } }
		public static GUIContent BuildSettingsPS4 { get { return EditorGUIUtility.IconContent("buildsettings.ps4"); } }
		public static GUIContent BuildSettingsPS4Small { get { return EditorGUIUtility.IconContent("buildsettings.ps4.small"); } }
		public static GUIContent BuildSettingsPS4Small2x { get { return EditorGUIUtility.IconContent("buildsettings.ps4.small@2x"); } }
		public static GUIContent BuildSettingsPS42x { get { return EditorGUIUtility.IconContent("buildsettings.ps4@2x"); } }
		public static GUIContent BuildSettingsPS5On { get { return EditorGUIUtility.IconContent("buildsettings.ps5 on"); } }
		public static GUIContent BuildSettingsPS5On2x { get { return EditorGUIUtility.IconContent("buildsettings.ps5 on@2x"); } }
		public static GUIContent BuildSettingsPS5 { get { return EditorGUIUtility.IconContent("buildsettings.ps5"); } }
		public static GUIContent BuildSettingsPS5Small { get { return EditorGUIUtility.IconContent("buildsettings.ps5.small"); } }
		public static GUIContent BuildSettingsPS5Small2x { get { return EditorGUIUtility.IconContent("buildsettings.ps5.small@2x"); } }
		public static GUIContent BuildSettingsPS52x { get { return EditorGUIUtility.IconContent("buildsettings.ps5@2x"); } }
		public static GUIContent BuildSettingsPSM { get { return EditorGUIUtility.IconContent("buildsettings.psm"); } }
		public static GUIContent BuildSettingsPSMSmall { get { return EditorGUIUtility.IconContent("buildsettings.psm.small"); } }
		public static GUIContent BuildSettingsPSP2 { get { return EditorGUIUtility.IconContent("buildsettings.psp2"); } }
		public static GUIContent BuildSettingsPSP2Small { get { return EditorGUIUtility.IconContent("buildsettings.psp2.small"); } }
		public static GUIContent BuildSettingsQNXOn { get { return EditorGUIUtility.IconContent("buildsettings.qnx on"); } }
		public static GUIContent BuildSettingsQNXOn2x { get { return EditorGUIUtility.IconContent("buildsettings.qnx on@2x"); } }
		public static GUIContent BuildSettingsQNX { get { return EditorGUIUtility.IconContent("buildsettings.qnx"); } }
		public static GUIContent BuildSettingsQNXSmall { get { return EditorGUIUtility.IconContent("buildsettings.qnx.small"); } }
		public static GUIContent BuildSettingsQNXSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.qnx.small@2x"); } }
		public static GUIContent BuildSettingsQNX2x { get { return EditorGUIUtility.IconContent("buildsettings.qnx@2x"); } }
		public static GUIContent BuildSettingsSelectedIcon { get { return EditorGUIUtility.IconContent("buildsettings.selectedicon"); } }
		public static GUIContent BuildSettingsStadiaOn { get { return EditorGUIUtility.IconContent("buildsettings.stadia on"); } }
		public static GUIContent BuildSettingsStadiaOn2x { get { return EditorGUIUtility.IconContent("buildsettings.stadia on@2x"); } }
		public static GUIContent BuildSettingsStadia { get { return EditorGUIUtility.IconContent("buildsettings.stadia"); } }
		public static GUIContent BuildSettingsStadiaSmall { get { return EditorGUIUtility.IconContent("buildsettings.stadia.small"); } }
		public static GUIContent BuildSettingsStadiaSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.stadia.small@2x"); } }
		public static GUIContent BuildSettingsStadia2x { get { return EditorGUIUtility.IconContent("buildsettings.stadia@2x"); } }
		public static GUIContent BuildSettingsStAndaloneOn { get { return EditorGUIUtility.IconContent("buildsettings.standalone on"); } }
		public static GUIContent BuildSettingsStAndaloneOn2x { get { return EditorGUIUtility.IconContent("buildsettings.standalone on@2x"); } }
		public static GUIContent BuildSettingsStAndalone { get { return EditorGUIUtility.IconContent("buildsettings.standalone"); } }
		public static GUIContent BuildSettingsStAndaloneSmall { get { return EditorGUIUtility.IconContent("buildsettings.standalone.small"); } }
		public static GUIContent BuildSettingsStAndaloneSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.standalone.small@2x"); } }
		public static GUIContent BuildSettingsStAndalone2x { get { return EditorGUIUtility.IconContent("buildsettings.standalone@2x"); } }
		public static GUIContent BuildSettingsStAndaloneBroadcomSmall { get { return EditorGUIUtility.IconContent("buildsettings.standalonebroadcom.small"); } }
		public static GUIContent BuildSettingsStAndalonegles20emuSmall { get { return EditorGUIUtility.IconContent("buildsettings.standalonegles20emu.small"); } }
		public static GUIContent BuildSettingsStAndaloneGLESEmu { get { return EditorGUIUtility.IconContent("buildsettings.standaloneglesemu"); } }
		public static GUIContent BuildSettingsStAndaloneGLESEmuSmall { get { return EditorGUIUtility.IconContent("buildsettings.standaloneglesemu.small"); } }
		public static GUIContent BuildSettingsSwitchOn { get { return EditorGUIUtility.IconContent("buildsettings.switch on"); } }
		public static GUIContent BuildSettingsSwitchOn2x { get { return EditorGUIUtility.IconContent("buildsettings.switch on@2x"); } }
		public static GUIContent BuildSettingsSwitch { get { return EditorGUIUtility.IconContent("buildsettings.switch"); } }
		public static GUIContent BuildSettingsSwitchSmall { get { return EditorGUIUtility.IconContent("buildsettings.switch.small"); } }
		public static GUIContent BuildSettingsSwitchSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.switch.small@2x"); } }
		public static GUIContent BuildSettingsSwitch2x { get { return EditorGUIUtility.IconContent("buildsettings.switch@2x"); } }
		public static GUIContent BuildSettingsTvOSOn { get { return EditorGUIUtility.IconContent("buildsettings.tvos on"); } }
		public static GUIContent BuildSettingsTvOSOn2x { get { return EditorGUIUtility.IconContent("buildsettings.tvos on@2x"); } }
		public static GUIContent BuildSettingsTvOS { get { return EditorGUIUtility.IconContent("buildsettings.tvos"); } }
		public static GUIContent BuildSettingsTvOSSmall { get { return EditorGUIUtility.IconContent("buildsettings.tvos.small"); } }
		public static GUIContent BuildSettingsTvOSSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.tvos.small@2x"); } }
		public static GUIContent BuildSettingsTvOS2x { get { return EditorGUIUtility.IconContent("buildsettings.tvos@2x"); } }
		public static GUIContent BuildSettingsWeb { get { return EditorGUIUtility.IconContent("buildsettings.web"); } }
		public static GUIContent BuildSettingsWebSmall { get { return EditorGUIUtility.IconContent("buildsettings.web.small"); } }
		public static GUIContent BuildSettingsWebGLOn { get { return EditorGUIUtility.IconContent("buildsettings.webgl on"); } }
		public static GUIContent BuildSettingsWebGLOn2x { get { return EditorGUIUtility.IconContent("buildsettings.webgl on@2x"); } }
		public static GUIContent BuildSettingsWebGL { get { return EditorGUIUtility.IconContent("buildsettings.webgl"); } }
		public static GUIContent BuildSettingsWebGLSmall { get { return EditorGUIUtility.IconContent("buildsettings.webgl.small"); } }
		public static GUIContent BuildSettingsWebGLSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.webgl.small@2x"); } }
		public static GUIContent BuildSettingsWebGL2x { get { return EditorGUIUtility.IconContent("buildsettings.webgl@2x"); } }
		public static GUIContent BuildSettingsWP8 { get { return EditorGUIUtility.IconContent("buildsettings.wp8"); } }
		public static GUIContent BuildSettingsWP8Small { get { return EditorGUIUtility.IconContent("buildsettings.wp8.small"); } }
		public static GUIContent BuildSettingsXbox360 { get { return EditorGUIUtility.IconContent("buildsettings.xbox360"); } }
		public static GUIContent BuildSettingsXbox360Small { get { return EditorGUIUtility.IconContent("buildsettings.xbox360.small"); } }
		public static GUIContent BuildSettingsXboxOneOn { get { return EditorGUIUtility.IconContent("buildsettings.xboxone on"); } }
		public static GUIContent BuildSettingsXboxOneOn2x { get { return EditorGUIUtility.IconContent("buildsettings.xboxone on@2x"); } }
		public static GUIContent BuildSettingsXboxOne { get { return EditorGUIUtility.IconContent("buildsettings.xboxone"); } }
		public static GUIContent BuildSettingsXboxOneSmall { get { return EditorGUIUtility.IconContent("buildsettings.xboxone.small"); } }
		public static GUIContent BuildSettingsXboxOneSmall2x { get { return EditorGUIUtility.IconContent("buildsettings.xboxone.small@2x"); } }
		public static GUIContent BuildSettingsXboxOne2x { get { return EditorGUIUtility.IconContent("buildsettings.xboxone@2x"); } }
		public static GUIContent CacheServerConnected { get { return EditorGUIUtility.IconContent("cacheserverconnected"); } }
		public static GUIContent CacheServerConnected2x { get { return EditorGUIUtility.IconContent("cacheserverconnected@2x"); } }
		public static GUIContent CacheServerDisabled { get { return EditorGUIUtility.IconContent("cacheserverdisabled"); } }
		public static GUIContent CacheServerDisabled2x { get { return EditorGUIUtility.IconContent("cacheserverdisabled@2x"); } }
		public static GUIContent CacheServerDisconnected { get { return EditorGUIUtility.IconContent("cacheserverdisconnected"); } }
		public static GUIContent CacheServerDisconnected2x { get { return EditorGUIUtility.IconContent("cacheserverdisconnected@2x"); } }
		public static GUIContent CheckerFloor { get { return EditorGUIUtility.IconContent("checkerfloor"); } }
		public static GUIContent Clipboard { get { return EditorGUIUtility.IconContent("clipboard"); } }
		public static GUIContent ClothInspectorPaintTool { get { return EditorGUIUtility.IconContent("clothinspector.painttool"); } }
		public static GUIContent ClothInspectorPaintValue { get { return EditorGUIUtility.IconContent("clothinspector.paintvalue"); } }
		public static GUIContent ClothInspectorSelectTool { get { return EditorGUIUtility.IconContent("clothinspector.selecttool"); } }
		public static GUIContent ClothInspectorSettingsTool { get { return EditorGUIUtility.IconContent("clothinspector.settingstool"); } }
		public static GUIContent ClothInspectorViewValue { get { return EditorGUIUtility.IconContent("clothinspector.viewvalue"); } }
		public static GUIContent CloudConnect { get { return EditorGUIUtility.IconContent("cloudconnect"); } }
		public static GUIContent CloudConnect2x { get { return EditorGUIUtility.IconContent("cloudconnect@2x"); } }
		public static GUIContent CollabBuild { get { return EditorGUIUtility.IconContent("collab.build"); } }
		public static GUIContent CollabBuildFailed { get { return EditorGUIUtility.IconContent("collab.buildfailed"); } }
		public static GUIContent CollabBuildSucceeded { get { return EditorGUIUtility.IconContent("collab.buildsucceeded"); } }
		public static GUIContent CollabFileAdded { get { return EditorGUIUtility.IconContent("collab.fileadded"); } }
		public static GUIContent CollabFileConflict { get { return EditorGUIUtility.IconContent("collab.fileconflict"); } }
		public static GUIContent CollabFileDeleted { get { return EditorGUIUtility.IconContent("collab.filedeleted"); } }
		public static GUIContent CollabFileIgnored { get { return EditorGUIUtility.IconContent("collab.fileignored"); } }
		public static GUIContent CollabFileMoved { get { return EditorGUIUtility.IconContent("collab.filemoved"); } }
		public static GUIContent CollabFileUpdated { get { return EditorGUIUtility.IconContent("collab.fileupdated"); } }
		public static GUIContent CollabFolderAdded { get { return EditorGUIUtility.IconContent("collab.folderadded"); } }
		public static GUIContent CollabFolderConflict { get { return EditorGUIUtility.IconContent("collab.folderconflict"); } }
		public static GUIContent CollabFolderDeleted { get { return EditorGUIUtility.IconContent("collab.folderdeleted"); } }
		public static GUIContent CollabFolderIgnored { get { return EditorGUIUtility.IconContent("collab.folderignored"); } }
		public static GUIContent CollabFolderMoved { get { return EditorGUIUtility.IconContent("collab.foldermoved"); } }
		public static GUIContent CollabFolderUpdated { get { return EditorGUIUtility.IconContent("collab.folderupdated"); } }
		public static GUIContent CollabNoInternet { get { return EditorGUIUtility.IconContent("collab.nointernet"); } }
		public static GUIContent Collab { get { return EditorGUIUtility.IconContent("collab"); } }
		public static GUIContent CollabWarning { get { return EditorGUIUtility.IconContent("collab.warning"); } }
		public static GUIContent Collab2x { get { return EditorGUIUtility.IconContent("collab@2x"); } }
		public static GUIContent CollabConflict { get { return EditorGUIUtility.IconContent("collabconflict"); } }
		public static GUIContent CollabError { get { return EditorGUIUtility.IconContent("collaberror"); } }
		public static GUIContent CollabNew { get { return EditorGUIUtility.IconContent("collabnew"); } }
		public static GUIContent CollabOffline { get { return EditorGUIUtility.IconContent("collaboffline"); } }
		public static GUIContent CollabProgress { get { return EditorGUIUtility.IconContent("collabprogress"); } }
		public static GUIContent CollabPull { get { return EditorGUIUtility.IconContent("collabpull"); } }
		public static GUIContent CollabPush { get { return EditorGUIUtility.IconContent("collabpush"); } }
		public static GUIContent ColorPickerColorCycle { get { return EditorGUIUtility.IconContent("colorpicker.colorcycle"); } }
		public static GUIContent ColorPickerCycleColor { get { return EditorGUIUtility.IconContent("colorpicker.cyclecolor"); } }
		public static GUIContent ColorPickerCycleSlider { get { return EditorGUIUtility.IconContent("colorpicker.cycleslider"); } }
		public static GUIContent ColorPickerSliderCycle { get { return EditorGUIUtility.IconContent("colorpicker.slidercycle"); } }
		public static GUIContent ConsoleErrorIconInactiveSmall { get { return EditorGUIUtility.IconContent("console.erroricon.inactive.sml"); } }
		public static GUIContent ConsoleErrorIconInactiveSmall2x { get { return EditorGUIUtility.IconContent("console.erroricon.inactive.sml@2x"); } }
		public static GUIContent ConsoleErrorIcon { get { return EditorGUIUtility.IconContent("console.erroricon"); } }
		public static GUIContent ConsoleErrorIconSmall { get { return EditorGUIUtility.IconContent("console.erroricon.sml"); } }
		public static GUIContent ConsoleErrorIconSmall2x { get { return EditorGUIUtility.IconContent("console.erroricon.sml@2x"); } }
		public static GUIContent ConsoleErrorIcon2x { get { return EditorGUIUtility.IconContent("console.erroricon@2x"); } }
		public static GUIContent ConsoleInfoIconInactiveSmall { get { return EditorGUIUtility.IconContent("console.infoicon.inactive.sml"); } }
		public static GUIContent ConsoleInfoIconInactiveSmall2x { get { return EditorGUIUtility.IconContent("console.infoicon.inactive.sml@2x"); } }
		public static GUIContent ConsoleInfoIcon { get { return EditorGUIUtility.IconContent("console.infoicon"); } }
		public static GUIContent ConsoleInfoIconSmall { get { return EditorGUIUtility.IconContent("console.infoicon.sml"); } }
		public static GUIContent ConsoleInfoIconSmall2x { get { return EditorGUIUtility.IconContent("console.infoicon.sml@2x"); } }
		public static GUIContent ConsoleInfoIcon2x { get { return EditorGUIUtility.IconContent("console.infoicon@2x"); } }
		public static GUIContent ConsoleWarnIconInactiveSmall { get { return EditorGUIUtility.IconContent("console.warnicon.inactive.sml"); } }
		public static GUIContent ConsoleWarnIconInactiveSmall2x { get { return EditorGUIUtility.IconContent("console.warnicon.inactive.sml@2x"); } }
		public static GUIContent ConsoleWarnIcon { get { return EditorGUIUtility.IconContent("console.warnicon"); } }
		public static GUIContent ConsoleWarnIconSmall { get { return EditorGUIUtility.IconContent("console.warnicon.sml"); } }
		public static GUIContent ConsoleWarnIconSmall2x { get { return EditorGUIUtility.IconContent("console.warnicon.sml@2x"); } }
		public static GUIContent ConsoleWarnIcon2x { get { return EditorGUIUtility.IconContent("console.warnicon@2x"); } }
		public static GUIContent CreateAddNew { get { return EditorGUIUtility.IconContent("createaddnew"); } }
		public static GUIContent CreateAddNew2x { get { return EditorGUIUtility.IconContent("createaddnew@2x"); } }
		public static GUIContent CrossIcon { get { return EditorGUIUtility.IconContent("crossicon"); } }
		public static GUIContent CurveKeyFrame { get { return EditorGUIUtility.IconContent("curvekeyframe"); } }
		public static GUIContent CurveKeyFrame2x { get { return EditorGUIUtility.IconContent("curvekeyframe@2x"); } }
		public static GUIContent CurveKeyFrameSelected { get { return EditorGUIUtility.IconContent("curvekeyframeselected"); } }
		public static GUIContent CurveKeyFrameSelected2x { get { return EditorGUIUtility.IconContent("curvekeyframeselected@2x"); } }
		public static GUIContent CurveKeyFrameSelectedOverlay { get { return EditorGUIUtility.IconContent("curvekeyframeselectedoverlay"); } }
		public static GUIContent CurveKeyFrameSelectedOverlay2x { get { return EditorGUIUtility.IconContent("curvekeyframeselectedoverlay@2x"); } }
		public static GUIContent CurveKeyFrameSemiSelectedOverlay { get { return EditorGUIUtility.IconContent("curvekeyframesemiselectedoverlay"); } }
		public static GUIContent CurveKeyFrameSemiSelectedOverlay2x { get { return EditorGUIUtility.IconContent("curvekeyframesemiselectedoverlay@2x"); } }
		public static GUIContent CurveKeyFrameWeighted { get { return EditorGUIUtility.IconContent("curvekeyframeweighted"); } }
		public static GUIContent CurveKeyFrameWeighted2x { get { return EditorGUIUtility.IconContent("curvekeyframeweighted@2x"); } }
		public static GUIContent CustomSorting { get { return EditorGUIUtility.IconContent("customsorting"); } }
		public static GUIContent CustomTool { get { return EditorGUIUtility.IconContent("customtool"); } }
		public static GUIContent CustomTool2x { get { return EditorGUIUtility.IconContent("customtool@2x"); } }
		public static GUIContent DebuggerAttached { get { return EditorGUIUtility.IconContent("debuggerattached"); } }
		public static GUIContent DebuggerAttached2x { get { return EditorGUIUtility.IconContent("debuggerattached@2x"); } }
		public static GUIContent DebuggerDisabled { get { return EditorGUIUtility.IconContent("debuggerdisabled"); } }
		public static GUIContent DebuggerDisabled2x { get { return EditorGUIUtility.IconContent("debuggerdisabled@2x"); } }
		public static GUIContent DebuggerEnabled { get { return EditorGUIUtility.IconContent("debuggerenabled"); } }
		public static GUIContent DebuggerEnabled2x { get { return EditorGUIUtility.IconContent("debuggerenabled@2x"); } }
		public static GUIContent DefaultSorting { get { return EditorGUIUtility.IconContent("defaultsorting"); } }
		public static GUIContent DefaultSorting2x { get { return EditorGUIUtility.IconContent("defaultsorting@2x"); } }
		public static GUIContent DragArrow2x { get { return EditorGUIUtility.IconContent("dragarrow@2x"); } }
		public static GUIContent EditCollider { get { return EditorGUIUtility.IconContent("editcollider"); } }
		public static GUIContent EditCollision16 { get { return EditorGUIUtility.IconContent("editcollision_16"); } }
		public static GUIContent EditCollision162x { get { return EditorGUIUtility.IconContent("editcollision_16@2x"); } }
		public static GUIContent EditCollision32 { get { return EditorGUIUtility.IconContent("editcollision_32"); } }
		public static GUIContent EditConstraints16 { get { return EditorGUIUtility.IconContent("editconstraints_16"); } }
		public static GUIContent EditConstraints162x { get { return EditorGUIUtility.IconContent("editconstraints_16@2x"); } }
		public static GUIContent EditConstraints32 { get { return EditorGUIUtility.IconContent("editconstraints_32"); } }
		public static GUIContent EditIconSmall { get { return EditorGUIUtility.IconContent("editicon.sml"); } }
		public static GUIContent EndButtonOn { get { return EditorGUIUtility.IconContent("endbutton-on"); } }
		public static GUIContent EndButton { get { return EditorGUIUtility.IconContent("endbutton"); } }
		public static GUIContent Exposure { get { return EditorGUIUtility.IconContent("exposure"); } }
		public static GUIContent Exposure2x { get { return EditorGUIUtility.IconContent("exposure@2x"); } }
		public static GUIContent EyedropperLarge { get { return EditorGUIUtility.IconContent("eyedropper.large"); } }
		public static GUIContent EyedropperLarge2x { get { return EditorGUIUtility.IconContent("eyedropper.large@2x"); } }
		public static GUIContent EyedropperSmall { get { return EditorGUIUtility.IconContent("eyedropper.sml"); } }
		public static GUIContent Favorite { get { return EditorGUIUtility.IconContent("favorite"); } }
		public static GUIContent Favorite2x { get { return EditorGUIUtility.IconContent("favorite@2x"); } }
		public static GUIContent FavoriteColored { get { return EditorGUIUtility.IconContent("favorite_colored"); } }
		public static GUIContent FavoriteColored2x { get { return EditorGUIUtility.IconContent("favorite_colored@2x"); } }
		public static GUIContent FilterByLabel { get { return EditorGUIUtility.IconContent("filterbylabel"); } }
		public static GUIContent FilterByLabel2x { get { return EditorGUIUtility.IconContent("filterbylabel@2x"); } }
		public static GUIContent FilterByType { get { return EditorGUIUtility.IconContent("filterbytype"); } }
		public static GUIContent FilterByType2x { get { return EditorGUIUtility.IconContent("filterbytype@2x"); } }
		public static GUIContent FilterSelectedOnly { get { return EditorGUIUtility.IconContent("filterselectedonly"); } }
		public static GUIContent FilterSelectedOnly2x { get { return EditorGUIUtility.IconContent("filterselectedonly@2x"); } }
		public static GUIContent Forward { get { return EditorGUIUtility.IconContent("forward"); } }
		public static GUIContent Forward2x { get { return EditorGUIUtility.IconContent("forward@2x"); } }
		public static GUIContent FrameCaptureOn { get { return EditorGUIUtility.IconContent("framecapture on"); } }
		public static GUIContent FrameCaptureOn2x { get { return EditorGUIUtility.IconContent("framecapture on@2x"); } }
		public static GUIContent FrameCapture { get { return EditorGUIUtility.IconContent("framecapture"); } }
		public static GUIContent FrameCapture2x { get { return EditorGUIUtility.IconContent("framecapture@2x"); } }
		public static GUIContent FullScreenNotification { get { return EditorGUIUtility.IconContent("fullscreennotification"); } }
		public static GUIContent Gear { get { return EditorGUIUtility.IconContent("gear"); } }
		public static GUIContent GizmosToggleOn { get { return EditorGUIUtility.IconContent("gizmostoggle on"); } }
		public static GUIContent GizmosToggleOn2x { get { return EditorGUIUtility.IconContent("gizmostoggle on@2x"); } }
		public static GUIContent GizmosToggle { get { return EditorGUIUtility.IconContent("gizmostoggle"); } }
		public static GUIContent GizmosToggle2x { get { return EditorGUIUtility.IconContent("gizmostoggle@2x"); } }
		public static GUIContent GridBoxTool { get { return EditorGUIUtility.IconContent("grid.boxtool"); } }
		public static GUIContent GridBoxTool2x { get { return EditorGUIUtility.IconContent("grid.boxtool@2x"); } }
		public static GUIContent GridDefault { get { return EditorGUIUtility.IconContent("grid.default"); } }
		public static GUIContent GridDefault2x { get { return EditorGUIUtility.IconContent("grid.default@2x"); } }
		public static GUIContent GridEraserTool { get { return EditorGUIUtility.IconContent("grid.erasertool"); } }
		public static GUIContent GridEraserTool2x { get { return EditorGUIUtility.IconContent("grid.erasertool@2x"); } }
		public static GUIContent GridFillTool { get { return EditorGUIUtility.IconContent("grid.filltool"); } }
		public static GUIContent GridFillTool2x { get { return EditorGUIUtility.IconContent("grid.filltool@2x"); } }
		public static GUIContent GridMoveTool { get { return EditorGUIUtility.IconContent("grid.movetool"); } }
		public static GUIContent GridMoveTool2x { get { return EditorGUIUtility.IconContent("grid.movetool@2x"); } }
		public static GUIContent GridPaintTool { get { return EditorGUIUtility.IconContent("grid.painttool"); } }
		public static GUIContent GridPaintTool2x { get { return EditorGUIUtility.IconContent("grid.painttool@2x"); } }
		public static GUIContent GridPickingTool { get { return EditorGUIUtility.IconContent("grid.pickingtool"); } }
		public static GUIContent GridPickingTool2x { get { return EditorGUIUtility.IconContent("grid.pickingtool@2x"); } }
		public static GUIContent Groove { get { return EditorGUIUtility.IconContent("groove"); } }
		public static GUIContent AlignHorizontally { get { return EditorGUIUtility.IconContent("guisystem/align_horizontally"); } }
		public static GUIContent AlignHorizontallyCenter { get { return EditorGUIUtility.IconContent("guisystem/align_horizontally_center"); } }
		public static GUIContent AlignHorizontallyCenterActive { get { return EditorGUIUtility.IconContent("guisystem/align_horizontally_center_active"); } }
		public static GUIContent AlignHorizontallyLeft { get { return EditorGUIUtility.IconContent("guisystem/align_horizontally_left"); } }
		public static GUIContent AlignHorizontallyLeftActive { get { return EditorGUIUtility.IconContent("guisystem/align_horizontally_left_active"); } }
		public static GUIContent AlignHorizontallyRight { get { return EditorGUIUtility.IconContent("guisystem/align_horizontally_right"); } }
		public static GUIContent AlignHorizontallyRightActive { get { return EditorGUIUtility.IconContent("guisystem/align_horizontally_right_active"); } }
		public static GUIContent AlignVertically { get { return EditorGUIUtility.IconContent("guisystem/align_vertically"); } }
		public static GUIContent AlignVerticallyBottom { get { return EditorGUIUtility.IconContent("guisystem/align_vertically_bottom"); } }
		public static GUIContent AlignVerticallyBottomActive { get { return EditorGUIUtility.IconContent("guisystem/align_vertically_bottom_active"); } }
		public static GUIContent AlignVerticallyCenter { get { return EditorGUIUtility.IconContent("guisystem/align_vertically_center"); } }
		public static GUIContent AlignVerticallyCenterActive { get { return EditorGUIUtility.IconContent("guisystem/align_vertically_center_active"); } }
		public static GUIContent AlignVerticallyTop { get { return EditorGUIUtility.IconContent("guisystem/align_vertically_top"); } }
		public static GUIContent AlignVerticallyTopActive { get { return EditorGUIUtility.IconContent("guisystem/align_vertically_top_active"); } }
		public static GUIContent HierarchyLock { get { return EditorGUIUtility.IconContent("hierarchylock"); } }
		public static GUIContent HierarchyLock2x { get { return EditorGUIUtility.IconContent("hierarchylock@2x"); } }
		public static GUIContent HorizontalSplit { get { return EditorGUIUtility.IconContent("horizontalsplit"); } }
		public static GUIContent IconDropdownOpen { get { return EditorGUIUtility.IconContent("icon dropdown open"); } }
		public static GUIContent IconDropdownOpen2x { get { return EditorGUIUtility.IconContent("icon dropdown open@2x"); } }
		public static GUIContent IconDropdown { get { return EditorGUIUtility.IconContent("icon dropdown"); } }
		public static GUIContent IconDropdown2x { get { return EditorGUIUtility.IconContent("icon dropdown@2x"); } }
		public static GUIContent Import { get { return EditorGUIUtility.IconContent("import"); } }
		public static GUIContent Import2x { get { return EditorGUIUtility.IconContent("import@2x"); } }
		public static GUIContent InspectorLock { get { return EditorGUIUtility.IconContent("inspectorlock"); } }
		public static GUIContent Invalid { get { return EditorGUIUtility.IconContent("invalid"); } }
		public static GUIContent Invalid2x { get { return EditorGUIUtility.IconContent("invalid@2x"); } }
		public static GUIContent JointAngularLimits { get { return EditorGUIUtility.IconContent("jointangularlimits"); } }
		public static GUIContent KnobCShape { get { return EditorGUIUtility.IconContent("knobcshape"); } }
		public static GUIContent KnobCShapeMini { get { return EditorGUIUtility.IconContent("knobcshapemini"); } }
		public static GUIContent LeftBracket { get { return EditorGUIUtility.IconContent("leftbracket"); } }
		public static GUIContent Lighting { get { return EditorGUIUtility.IconContent("lighting"); } }
		public static GUIContent Lighting2x { get { return EditorGUIUtility.IconContent("lighting@2x"); } }
		public static GUIContent LightmapEditorWindowTitle { get { return EditorGUIUtility.IconContent("lightmapeditor.windowtitle"); } }
		public static GUIContent LightmapEditorWindowTitle2x { get { return EditorGUIUtility.IconContent("lightmapeditor.windowtitle@2x"); } }
		public static GUIContent LightMapping { get { return EditorGUIUtility.IconContent("lightmapping"); } }
		public static GUIContent GreenLight { get { return EditorGUIUtility.IconContent("lightmeter/greenlight"); } }
		public static GUIContent LightOff { get { return EditorGUIUtility.IconContent("lightmeter/lightoff"); } }
		public static GUIContent Lightrim { get { return EditorGUIUtility.IconContent("lightmeter/lightrim"); } }
		public static GUIContent OrangeLight { get { return EditorGUIUtility.IconContent("lightmeter/orangelight"); } }
		public static GUIContent RedLight { get { return EditorGUIUtility.IconContent("lightmeter/redlight"); } }
		public static GUIContent Linked { get { return EditorGUIUtility.IconContent("linked"); } }
		public static GUIContent Linked2x { get { return EditorGUIUtility.IconContent("linked@2x"); } }
		public static GUIContent LockIconOn { get { return EditorGUIUtility.IconContent("lockicon-on"); } }
		public static GUIContent LockIcon { get { return EditorGUIUtility.IconContent("lockicon"); } }
		public static GUIContent Loop { get { return EditorGUIUtility.IconContent("loop"); } }
		public static GUIContent MainStageView { get { return EditorGUIUtility.IconContent("mainstageview"); } }
		public static GUIContent MainStageView2x { get { return EditorGUIUtility.IconContent("mainstageview@2x"); } }
		public static GUIContent Mirror { get { return EditorGUIUtility.IconContent("mirror"); } }
		public static GUIContent MonoLogo { get { return EditorGUIUtility.IconContent("monologo"); } }
		public static GUIContent MoreOptions { get { return EditorGUIUtility.IconContent("moreoptions"); } }
		public static GUIContent MoreOptions2x { get { return EditorGUIUtility.IconContent("moreoptions@2x"); } }
		public static GUIContent MoveToolOn { get { return EditorGUIUtility.IconContent("movetool on"); } }
		public static GUIContent MoveToolOn2x { get { return EditorGUIUtility.IconContent("movetool on@2x"); } }
		public static GUIContent MoveTool { get { return EditorGUIUtility.IconContent("movetool"); } }
		public static GUIContent MoveTool2x { get { return EditorGUIUtility.IconContent("movetool@2x"); } }
		public static GUIContent Navigation { get { return EditorGUIUtility.IconContent("navigation"); } }
		public static GUIContent Occlusion { get { return EditorGUIUtility.IconContent("occlusion"); } }
		public static GUIContent Occlusion2x { get { return EditorGUIUtility.IconContent("occlusion@2x"); } }
		public static GUIContent CameraPreview { get { return EditorGUIUtility.IconContent("overlays/camerapreview"); } }
		public static GUIContent CameraPreview2x { get { return EditorGUIUtility.IconContent("overlays/camerapreview@2x"); } }
		public static GUIContent GridAndSnap { get { return EditorGUIUtility.IconContent("overlays/gridandsnap"); } }
		public static GUIContent GridAndSnap2x { get { return EditorGUIUtility.IconContent("overlays/gridandsnap@2x"); } }
		public static GUIContent GripHorizontalContainer { get { return EditorGUIUtility.IconContent("overlays/grip_horizontalcontainer"); } }
		public static GUIContent GripVerticalContainer { get { return EditorGUIUtility.IconContent("overlays/grip_verticalcontainer"); } }
		public static GUIContent HoverBarDown { get { return EditorGUIUtility.IconContent("overlays/hoverbar_down"); } }
		public static GUIContent HoverBarLeftRight { get { return EditorGUIUtility.IconContent("overlays/hoverbar_leftright"); } }
		public static GUIContent HoverBarUp { get { return EditorGUIUtility.IconContent("overlays/hoverbar_up"); } }
		public static GUIContent Locked { get { return EditorGUIUtility.IconContent("overlays/locked"); } }
		public static GUIContent Locked2x { get { return EditorGUIUtility.IconContent("overlays/locked@2x"); } }
		public static GUIContent OrientationGizmo { get { return EditorGUIUtility.IconContent("overlays/orientationgizmo"); } }
		public static GUIContent OrientationGizmo2x { get { return EditorGUIUtility.IconContent("overlays/orientationgizmo@2x"); } }
		public static GUIContent SearchOverlay { get { return EditorGUIUtility.IconContent("overlays/searchoverlay"); } }
		public static GUIContent SearchOverlay2x { get { return EditorGUIUtility.IconContent("overlays/searchoverlay@2x"); } }
		public static GUIContent StandardTools { get { return EditorGUIUtility.IconContent("overlays/standardtools"); } }
		public static GUIContent StandardTools2x { get { return EditorGUIUtility.IconContent("overlays/standardtools@2x"); } }
		public static GUIContent ToolSettings { get { return EditorGUIUtility.IconContent("overlays/toolsettings"); } }
		public static GUIContent ToolSettings2x { get { return EditorGUIUtility.IconContent("overlays/toolsettings@2x"); } }
		public static GUIContent ToolsToggle { get { return EditorGUIUtility.IconContent("overlays/toolstoggle"); } }
		public static GUIContent ToolsToggle2x { get { return EditorGUIUtility.IconContent("overlays/toolstoggle@2x"); } }
		public static GUIContent Unlocked { get { return EditorGUIUtility.IconContent("overlays/unlocked"); } }
		public static GUIContent Unlocked2x { get { return EditorGUIUtility.IconContent("overlays/unlocked@2x"); } }
		public static GUIContent ViewOptions { get { return EditorGUIUtility.IconContent("overlays/viewoptions"); } }
		public static GUIContent ViewOptions2x { get { return EditorGUIUtility.IconContent("overlays/viewoptions@2x"); } }
		public static GUIContent PackageManager { get { return EditorGUIUtility.IconContent("package manager"); } }
		public static GUIContent PackageManager2x { get { return EditorGUIUtility.IconContent("package manager@2x"); } }
		public static GUIContent PackageBadgeNew { get { return EditorGUIUtility.IconContent("packagebadgenew"); } }
		public static GUIContent PackageBadgeOverride { get { return EditorGUIUtility.IconContent("packagebadgeoverride"); } }
		public static GUIContent ParticleEffect { get { return EditorGUIUtility.IconContent("particle effect"); } }
		public static GUIContent ParticleShapeToolOn { get { return EditorGUIUtility.IconContent("particleshapetool on"); } }
		public static GUIContent ParticleShapeToolOn2x { get { return EditorGUIUtility.IconContent("particleshapetool on@2x"); } }
		public static GUIContent ParticleShapeToolOn3X { get { return EditorGUIUtility.IconContent("particleshapetool on@3x"); } }
		public static GUIContent ParticleShapeToolOn4X { get { return EditorGUIUtility.IconContent("particleshapetool on@4x"); } }
		public static GUIContent ParticleShapeTool { get { return EditorGUIUtility.IconContent("particleshapetool"); } }
		public static GUIContent ParticleShapeTool2x { get { return EditorGUIUtility.IconContent("particleshapetool@2x"); } }
		public static GUIContent ParticleShapeTool3X { get { return EditorGUIUtility.IconContent("particleshapetool@3x"); } }
		public static GUIContent ParticleShapeTool4X { get { return EditorGUIUtility.IconContent("particleshapetool@4x"); } }
		public static GUIContent PauseButtonOn { get { return EditorGUIUtility.IconContent("pausebutton on"); } }
		public static GUIContent PauseButtonOn2x { get { return EditorGUIUtility.IconContent("pausebutton on@2x"); } }
		public static GUIContent PauseButton { get { return EditorGUIUtility.IconContent("pausebutton"); } }
		public static GUIContent PauseButton2x { get { return EditorGUIUtility.IconContent("pausebutton@2x"); } }
		public static GUIContent PlayButtonOn { get { return EditorGUIUtility.IconContent("playbutton on"); } }
		public static GUIContent PlayButtonOn2x { get { return EditorGUIUtility.IconContent("playbutton on@2x"); } }
		public static GUIContent PlayButton { get { return EditorGUIUtility.IconContent("playbutton"); } }
		public static GUIContent PlayButton2x { get { return EditorGUIUtility.IconContent("playbutton@2x"); } }
		public static GUIContent PlayButtonProfileOn { get { return EditorGUIUtility.IconContent("playbuttonprofile on"); } }
		public static GUIContent PlayButtonProfile { get { return EditorGUIUtility.IconContent("playbuttonprofile"); } }
		public static GUIContent PlayLoopOff { get { return EditorGUIUtility.IconContent("playloopoff"); } }
		public static GUIContent PlayLoopOn { get { return EditorGUIUtility.IconContent("playloopon"); } }
		public static GUIContent PlaySpeed { get { return EditorGUIUtility.IconContent("playspeed"); } }
		public static GUIContent PreAudioAutoPlayOff { get { return EditorGUIUtility.IconContent("preaudioautoplayoff"); } }
		public static GUIContent PreAudioAutoPlayOff2x { get { return EditorGUIUtility.IconContent("preaudioautoplayoff@2x"); } }
		public static GUIContent PreAudioAutoPlayOn { get { return EditorGUIUtility.IconContent("preaudioautoplayon"); } }
		public static GUIContent PreAudioLoopOff { get { return EditorGUIUtility.IconContent("preaudioloopoff"); } }
		public static GUIContent PreAudioLoopOff2x { get { return EditorGUIUtility.IconContent("preaudioloopoff@2x"); } }
		public static GUIContent PreAudioLoopOn { get { return EditorGUIUtility.IconContent("preaudioloopon"); } }
		public static GUIContent PreAudioPlayOff { get { return EditorGUIUtility.IconContent("preaudioplayoff"); } }
		public static GUIContent PreAudioPlayOn { get { return EditorGUIUtility.IconContent("preaudioplayon"); } }
		public static GUIContent PreMatCube { get { return EditorGUIUtility.IconContent("prematcube"); } }
		public static GUIContent PreMatCube2x { get { return EditorGUIUtility.IconContent("prematcube@2x"); } }
		public static GUIContent PreMatCylinder { get { return EditorGUIUtility.IconContent("prematcylinder"); } }
		public static GUIContent PreMatCylinder2x { get { return EditorGUIUtility.IconContent("prematcylinder@2x"); } }
		public static GUIContent PreMatLight0 { get { return EditorGUIUtility.IconContent("prematlight0"); } }
		public static GUIContent PreMatLight02x { get { return EditorGUIUtility.IconContent("prematlight0@2x"); } }
		public static GUIContent PreMatLight1 { get { return EditorGUIUtility.IconContent("prematlight1"); } }
		public static GUIContent PreMatLight12x { get { return EditorGUIUtility.IconContent("prematlight1@2x"); } }
		public static GUIContent PreMatQuad { get { return EditorGUIUtility.IconContent("prematquad"); } }
		public static GUIContent PreMatQuad2x { get { return EditorGUIUtility.IconContent("prematquad@2x"); } }
		public static GUIContent PreMatSphere { get { return EditorGUIUtility.IconContent("prematsphere"); } }
		public static GUIContent PreMatSphere2x { get { return EditorGUIUtility.IconContent("prematsphere@2x"); } }
		public static GUIContent PreMatTorus { get { return EditorGUIUtility.IconContent("premattorus"); } }
		public static GUIContent PreMatTorus2x { get { return EditorGUIUtility.IconContent("premattorus@2x"); } }
		public static GUIContent PresetContext { get { return EditorGUIUtility.IconContent("preset.context"); } }
		public static GUIContent PresetContext2x { get { return EditorGUIUtility.IconContent("preset.context@2x"); } }
		public static GUIContent PresetCurrent { get { return EditorGUIUtility.IconContent("preset.current"); } }
		public static GUIContent PresetCurrent2x { get { return EditorGUIUtility.IconContent("preset.current@2x"); } }
		public static GUIContent PreTexA { get { return EditorGUIUtility.IconContent("pretexa"); } }
		public static GUIContent PreTexA2x { get { return EditorGUIUtility.IconContent("pretexa@2x"); } }
		public static GUIContent PreTexB { get { return EditorGUIUtility.IconContent("pretexb"); } }
		public static GUIContent PreTexB2x { get { return EditorGUIUtility.IconContent("pretexb@2x"); } }
		public static GUIContent PreTexG { get { return EditorGUIUtility.IconContent("pretexg"); } }
		public static GUIContent PreTexG2x { get { return EditorGUIUtility.IconContent("pretexg@2x"); } }
		public static GUIContent PreTexR { get { return EditorGUIUtility.IconContent("pretexr"); } }
		public static GUIContent PreTexR2x { get { return EditorGUIUtility.IconContent("pretexr@2x"); } }
		public static GUIContent PreTexRGB { get { return EditorGUIUtility.IconContent("pretexrgb"); } }
		public static GUIContent PreTexRGB2x { get { return EditorGUIUtility.IconContent("pretexrgb@2x"); } }
		public static GUIContent PreTextureAlpha { get { return EditorGUIUtility.IconContent("pretexturealpha"); } }
		public static GUIContent PreTextureArrayFirstSlice { get { return EditorGUIUtility.IconContent("pretexturearrayfirstslice"); } }
		public static GUIContent PreTextureArrayLastSlice { get { return EditorGUIUtility.IconContent("pretexturearraylastslice"); } }
		public static GUIContent PreTextureMipMapHigh { get { return EditorGUIUtility.IconContent("pretexturemipmaphigh"); } }
		public static GUIContent PreTextureMipMapLow { get { return EditorGUIUtility.IconContent("pretexturemipmaplow"); } }
		public static GUIContent PreTextureRGB { get { return EditorGUIUtility.IconContent("pretexturergb"); } }
		public static GUIContent PreviewPackageInUse { get { return EditorGUIUtility.IconContent("previewpackageinuse"); } }
		public static GUIContent PreviewPackageInUse2x { get { return EditorGUIUtility.IconContent("previewpackageinuse@2x"); } }
		public static GUIContent AreaLightGizmo { get { return EditorGUIUtility.IconContent("arealight gizmo"); } }
		public static GUIContent AreaLightIcon { get { return EditorGUIUtility.IconContent("arealight icon"); } }
		public static GUIContent AssemblyIcon { get { return EditorGUIUtility.IconContent("assembly icon"); } }
		public static GUIContent AssetStoreIcon { get { return EditorGUIUtility.IconContent("assetstore icon"); } }
		public static GUIContent AudioMixerViewIcon { get { return EditorGUIUtility.IconContent("audiomixerview icon"); } }
		public static GUIContent AudioSourceGizmo { get { return EditorGUIUtility.IconContent("audiosource gizmo"); } }
		public static GUIContent BooScriptIcon { get { return EditorGUIUtility.IconContent("boo script icon"); } }
		public static GUIContent CameraGizmo { get { return EditorGUIUtility.IconContent("camera gizmo"); } }
		public static GUIContent ChorusFilterIcon { get { return EditorGUIUtility.IconContent("chorusfilter icon"); } }
		public static GUIContent CollabChangesIcon { get { return EditorGUIUtility.IconContent("collabchanges icon"); } }
		public static GUIContent CollabChangesConflictIcon { get { return EditorGUIUtility.IconContent("collabchangesconflict icon"); } }
		public static GUIContent CollabChangesDeletedIcon { get { return EditorGUIUtility.IconContent("collabchangesdeleted icon"); } }
		public static GUIContent CollabConflictIcon { get { return EditorGUIUtility.IconContent("collabconflict icon"); } }
		public static GUIContent CollabCreateIcon { get { return EditorGUIUtility.IconContent("collabcreate icon"); } }
		public static GUIContent CollabDeletedIcon { get { return EditorGUIUtility.IconContent("collabdeleted icon"); } }
		public static GUIContent CollabEditIcon { get { return EditorGUIUtility.IconContent("collabedit icon"); } }
		public static GUIContent CollabexcludeIcon { get { return EditorGUIUtility.IconContent("collabexclude icon"); } }
		public static GUIContent CollabMovedIcon { get { return EditorGUIUtility.IconContent("collabmoved icon"); } }
		public static GUIContent CsScriptIcon { get { return EditorGUIUtility.IconContent("cs script icon"); } }
		public static GUIContent DefaultSlateIcon { get { return EditorGUIUtility.IconContent("defaultslate icon"); } }
		public static GUIContent DirectionalLightGizmo { get { return EditorGUIUtility.IconContent("directionallight gizmo"); } }
		public static GUIContent DirectionalLightIcon { get { return EditorGUIUtility.IconContent("directionallight icon"); } }
		public static GUIContent DiscLightGizmo { get { return EditorGUIUtility.IconContent("disclight gizmo"); } }
		public static GUIContent DiscLightIcon { get { return EditorGUIUtility.IconContent("disclight icon"); } }
		public static GUIContent DllScriptIcon { get { return EditorGUIUtility.IconContent("dll script icon"); } }
		public static GUIContent EchoFilterIcon { get { return EditorGUIUtility.IconContent("echofilter icon"); } }
		public static GUIContent FavoriteIcon { get { return EditorGUIUtility.IconContent("favorite icon"); } }
		public static GUIContent FavoriteOnIcon { get { return EditorGUIUtility.IconContent("favorite on icon"); } }
		public static GUIContent FolderIcon { get { return EditorGUIUtility.IconContent("folder icon"); } }
		public static GUIContent FolderOnIcon { get { return EditorGUIUtility.IconContent("folder on icon"); } }
		public static GUIContent FolderemptyIcon { get { return EditorGUIUtility.IconContent("folderempty icon"); } }
		public static GUIContent FolderemptyOnIcon { get { return EditorGUIUtility.IconContent("folderempty on icon"); } }
		public static GUIContent FolderfavoriteIcon { get { return EditorGUIUtility.IconContent("folderfavorite icon"); } }
		public static GUIContent FolderfavoriteOnIcon { get { return EditorGUIUtility.IconContent("folderfavorite on icon"); } }
		public static GUIContent FolderOpenedIcon { get { return EditorGUIUtility.IconContent("folderopened icon"); } }
		public static GUIContent FolderOpenedOnIcon { get { return EditorGUIUtility.IconContent("folderopened on icon"); } }
		public static GUIContent GameManagerIcon { get { return EditorGUIUtility.IconContent("gamemanager icon"); } }
		public static GUIContent GridBrushIcon { get { return EditorGUIUtility.IconContent("gridbrush icon"); } }
		public static GUIContent HighPassFilterIcon { get { return EditorGUIUtility.IconContent("highpassfilter icon"); } }
		public static GUIContent HorizontalLayoutGroupIcon { get { return EditorGUIUtility.IconContent("horizontallayoutgroup icon"); } }
		public static GUIContent JsScriptIcon { get { return EditorGUIUtility.IconContent("js script icon"); } }
		public static GUIContent LensFlareGizmo { get { return EditorGUIUtility.IconContent("lensflare gizmo"); } }
		public static GUIContent LightingdataAssetparentIcon { get { return EditorGUIUtility.IconContent("lightingdataassetparent icon"); } }
		public static GUIContent LightProbeGroupGizmo { get { return EditorGUIUtility.IconContent("lightprobegroup gizmo"); } }
		public static GUIContent LightProbeProxyVolumeGizmo { get { return EditorGUIUtility.IconContent("lightprobeproxyvolume gizmo"); } }
		public static GUIContent LowPassFilterIcon { get { return EditorGUIUtility.IconContent("lowpassfilter icon"); } }
		public static GUIContent MainLightGizmo { get { return EditorGUIUtility.IconContent("main light gizmo"); } }
		public static GUIContent MaterialVariantIcon { get { return EditorGUIUtility.IconContent("materialvariant icon"); } }
		public static GUIContent MetaFileIcon { get { return EditorGUIUtility.IconContent("metafile icon"); } }
		public static GUIContent MicroPhoneIcon { get { return EditorGUIUtility.IconContent("microphone icon"); } }
		public static GUIContent MuscleClipIcon { get { return EditorGUIUtility.IconContent("muscleclip icon"); } }
		public static GUIContent ParticleSystemGizmo { get { return EditorGUIUtility.IconContent("particlesystem gizmo"); } }
		public static GUIContent ParticleSystemForceFieldGizmo { get { return EditorGUIUtility.IconContent("particlesystemforcefield gizmo"); } }
		public static GUIContent PoIntLightGizmo { get { return EditorGUIUtility.IconContent("pointlight gizmo"); } }
		public static GUIContent PrefabIcon { get { return EditorGUIUtility.IconContent("prefab icon"); } }
		public static GUIContent PrefabOnIcon { get { return EditorGUIUtility.IconContent("prefab on icon"); } }
		public static GUIContent PrefabModelIcon { get { return EditorGUIUtility.IconContent("prefabmodel icon"); } }
		public static GUIContent PrefabModelOnIcon { get { return EditorGUIUtility.IconContent("prefabmodel on icon"); } }
		public static GUIContent PrefabOverlayAddedIcon { get { return EditorGUIUtility.IconContent("prefaboverlayadded icon"); } }
		public static GUIContent PrefabOverlayModifiedIcon { get { return EditorGUIUtility.IconContent("prefaboverlaymodified icon"); } }
		public static GUIContent PrefabOverlayRemovedIcon { get { return EditorGUIUtility.IconContent("prefaboverlayremoved icon"); } }
		public static GUIContent PrefabVariantIcon { get { return EditorGUIUtility.IconContent("prefabvariant icon"); } }
		public static GUIContent PrefabVariantOnIcon { get { return EditorGUIUtility.IconContent("prefabvariant on icon"); } }
		public static GUIContent ProjectorGizmo { get { return EditorGUIUtility.IconContent("projector gizmo"); } }
		public static GUIContent RaycastColliderIcon { get { return EditorGUIUtility.IconContent("raycastcollider icon"); } }
		public static GUIContent ReflectionProbeGizmo { get { return EditorGUIUtility.IconContent("reflectionprobe gizmo"); } }
		public static GUIContent ReverbFilterIcon { get { return EditorGUIUtility.IconContent("reverbfilter icon"); } }
		public static GUIContent SceneSetIcon { get { return EditorGUIUtility.IconContent("sceneset icon"); } }
		public static GUIContent SearchIcon { get { return EditorGUIUtility.IconContent("search icon"); } }
		public static GUIContent SearchOnIcon { get { return EditorGUIUtility.IconContent("search on icon"); } }
		public static GUIContent SearchJumpIcon { get { return EditorGUIUtility.IconContent("searchjump icon"); } }
		public static GUIContent SettingsIcon { get { return EditorGUIUtility.IconContent("settings icon"); } }
		public static GUIContent ShortcutIcon { get { return EditorGUIUtility.IconContent("shortcut icon"); } }
		public static GUIContent SoftLockprojectbrowserIcon { get { return EditorGUIUtility.IconContent("softlockprojectbrowser icon"); } }
		public static GUIContent SpeedTreeModelIcon { get { return EditorGUIUtility.IconContent("speedtreemodel icon"); } }
		public static GUIContent SpotLightGizmo { get { return EditorGUIUtility.IconContent("spotlight gizmo"); } }
		public static GUIContent SpotLightIcon { get { return EditorGUIUtility.IconContent("spotlight icon"); } }
		public static GUIContent SpriteColliderIcon { get { return EditorGUIUtility.IconContent("spritecollider icon"); } }
		public static GUIContent SvIconDot0Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot0_pix16_gizmo"); } }
		public static GUIContent SvIconDot10Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot10_pix16_gizmo"); } }
		public static GUIContent SvIconDot11Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot11_pix16_gizmo"); } }
		public static GUIContent SvIconDot12Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot12_pix16_gizmo"); } }
		public static GUIContent SvIconDot13Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot13_pix16_gizmo"); } }
		public static GUIContent SvIconDot14Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot14_pix16_gizmo"); } }
		public static GUIContent SvIconDot15Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot15_pix16_gizmo"); } }
		public static GUIContent SvIconDot1Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot1_pix16_gizmo"); } }
		public static GUIContent SvIconDot2Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot2_pix16_gizmo"); } }
		public static GUIContent SvIconDot3Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot3_pix16_gizmo"); } }
		public static GUIContent SvIconDot4Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot4_pix16_gizmo"); } }
		public static GUIContent SvIconDot5Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot5_pix16_gizmo"); } }
		public static GUIContent SvIconDot6Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot6_pix16_gizmo"); } }
		public static GUIContent SvIconDot7Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot7_pix16_gizmo"); } }
		public static GUIContent SvIconDot8Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot8_pix16_gizmo"); } }
		public static GUIContent SvIconDot9Pix16Gizmo { get { return EditorGUIUtility.IconContent("sv_icon_dot9_pix16_gizmo"); } }
		public static GUIContent AnimatorControllerIcon { get { return EditorGUIUtility.IconContent("unityeditor/animations/animatorcontroller icon"); } }
		public static GUIContent AnimatorControllerOnIcon { get { return EditorGUIUtility.IconContent("unityeditor/animations/animatorcontroller on icon"); } }
		public static GUIContent AnimatorStateIcon { get { return EditorGUIUtility.IconContent("unityeditor/animations/animatorstate icon"); } }
		public static GUIContent AnimatorStatemachineIcon { get { return EditorGUIUtility.IconContent("unityeditor/animations/animatorstatemachine icon"); } }
		public static GUIContent AnimatorStateTransitionIcon { get { return EditorGUIUtility.IconContent("unityeditor/animations/animatorstatetransition icon"); } }
		public static GUIContent BlendTreeIcon { get { return EditorGUIUtility.IconContent("unityeditor/animations/blendtree icon"); } }
		public static GUIContent AnimationWindowEventIcon { get { return EditorGUIUtility.IconContent("unityeditor/animationwindowevent icon"); } }
		public static GUIContent AudioMixerControllerIcon { get { return EditorGUIUtility.IconContent("unityeditor/audio/audiomixercontroller icon"); } }
		public static GUIContent AudioMixerControllerOnIcon { get { return EditorGUIUtility.IconContent("unityeditor/audio/audiomixercontroller on icon"); } }
		public static GUIContent AudioImporterIcon { get { return EditorGUIUtility.IconContent("unityeditor/audioimporter icon"); } }
		public static GUIContent DefaultAssetIcon { get { return EditorGUIUtility.IconContent("unityeditor/defaultasset icon"); } }
		public static GUIContent EditorSettingsIcon { get { return EditorGUIUtility.IconContent("unityeditor/editorsettings icon"); } }
		public static GUIContent FilterIcon { get { return EditorGUIUtility.IconContent("unityeditor/filter icon"); } }
		public static GUIContent HumantemPlateIcon { get { return EditorGUIUtility.IconContent("unityeditor/humantemplate icon"); } }
		public static GUIContent IHVImageFormatImporterIcon { get { return EditorGUIUtility.IconContent("unityeditor/ihvimageformatimporter icon"); } }
		public static GUIContent LightingdataAssetIcon { get { return EditorGUIUtility.IconContent("unityeditor/lightingdataasset icon"); } }
		public static GUIContent LightmapParametersIcon { get { return EditorGUIUtility.IconContent("unityeditor/lightmapparameters icon"); } }
		public static GUIContent LightmapParametersOnIcon { get { return EditorGUIUtility.IconContent("unityeditor/lightmapparameters on icon"); } }
		public static GUIContent ModelImporterIcon { get { return EditorGUIUtility.IconContent("unityeditor/modelimporter icon"); } }
		public static GUIContent PresetIcon { get { return EditorGUIUtility.IconContent("unityeditor/presets/preset icon"); } }
		public static GUIContent SceneAssetIcon { get { return EditorGUIUtility.IconContent("unityeditor/sceneasset icon"); } }
		public static GUIContent SceneAssetOnIcon { get { return EditorGUIUtility.IconContent("unityeditor/sceneasset on icon"); } }
		public static GUIContent ShaderImporterIcon { get { return EditorGUIUtility.IconContent("unityeditor/shaderimporter icon"); } }
		public static GUIContent ShaderIncludeIcon { get { return EditorGUIUtility.IconContent("unityeditor/shaderinclude icon"); } }
		public static GUIContent SpeedTreeImporterIcon { get { return EditorGUIUtility.IconContent("unityeditor/speedtreeimporter icon"); } }
		public static GUIContent SubstanceArchiveIcon { get { return EditorGUIUtility.IconContent("unityeditor/substancearchive icon"); } }
		public static GUIContent TextScriptImporterIcon { get { return EditorGUIUtility.IconContent("unityeditor/textscriptimporter icon"); } }
		public static GUIContent TextureImporterIcon { get { return EditorGUIUtility.IconContent("unityeditor/textureimporter icon"); } }
		public static GUIContent TrueTypeFontImporterIcon { get { return EditorGUIUtility.IconContent("unityeditor/truetypefontimporter icon"); } }
		public static GUIContent SpriteatlasAssetIcon { get { return EditorGUIUtility.IconContent("unityeditor/u2d/spriteatlasasset icon"); } }
		public static GUIContent SpriteatlasImporterIcon { get { return EditorGUIUtility.IconContent("unityeditor/u2d/spriteatlasimporter icon"); } }
		public static GUIContent VideoClipImporterIcon { get { return EditorGUIUtility.IconContent("unityeditor/videoclipimporter icon"); } }
		public static GUIContent NetworkAnimatorIcon { get { return EditorGUIUtility.IconContent("unityengine/networking/networkanimator icon"); } }
		public static GUIContent NetworkdiscoveryIcon { get { return EditorGUIUtility.IconContent("unityengine/networking/networkdiscovery icon"); } }
		public static GUIContent NetworkidentityIcon { get { return EditorGUIUtility.IconContent("unityengine/networking/networkidentity icon"); } }
		public static GUIContent NetworklobByManagerIcon { get { return EditorGUIUtility.IconContent("unityengine/networking/networklobbymanager icon"); } }
		public static GUIContent NetworklobByPlayerIcon { get { return EditorGUIUtility.IconContent("unityengine/networking/networklobbyplayer icon"); } }
		public static GUIContent NetworkManagerIcon { get { return EditorGUIUtility.IconContent("unityengine/networking/networkmanager icon"); } }
		public static GUIContent NetworkManagerhudIcon { get { return EditorGUIUtility.IconContent("unityengine/networking/networkmanagerhud icon"); } }
		public static GUIContent NetworkMigrationManagerIcon { get { return EditorGUIUtility.IconContent("unityengine/networking/networkmigrationmanager icon"); } }
		public static GUIContent NetworkProximityCheckerIcon { get { return EditorGUIUtility.IconContent("unityengine/networking/networkproximitychecker icon"); } }
		public static GUIContent NetworkStartPositionIcon { get { return EditorGUIUtility.IconContent("unityengine/networking/networkstartposition icon"); } }
		public static GUIContent NetworkTransformIcon { get { return EditorGUIUtility.IconContent("unityengine/networking/networktransform icon"); } }
		public static GUIContent NetworkTransformchildIcon { get { return EditorGUIUtility.IconContent("unityengine/networking/networktransformchild icon"); } }
		public static GUIContent NetworkTransformVisualizerIcon { get { return EditorGUIUtility.IconContent("unityengine/networking/networktransformvisualizer icon"); } }
		public static GUIContent AspectRatioFitterIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/aspectratiofitter icon"); } }
		public static GUIContent ButtonIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/button icon"); } }
		public static GUIContent CanvasScalerIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/canvasscaler icon"); } }
		public static GUIContent ContentSizeFitterIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/contentsizefitter icon"); } }
		public static GUIContent DropdownIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/dropdown icon"); } }
		public static GUIContent FreeformLayoutGroupIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/freeformlayoutgroup icon"); } }
		public static GUIContent GraphicRaycasterIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/graphicraycaster icon"); } }
		public static GUIContent GridLayoutGroupIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/gridlayoutgroup icon"); } }
		public static GUIContent ImageIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/image icon"); } }
		public static GUIContent InputFieldIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/inputfield icon"); } }
		public static GUIContent LayoutElementIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/layoutelement icon"); } }
		public static GUIContent MaskIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/mask icon"); } }
		public static GUIContent OutlineIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/outline icon"); } }
		public static GUIContent PositionAsUV1Icon { get { return EditorGUIUtility.IconContent("unityengine/ui/positionasuv1 icon"); } }
		public static GUIContent RawImageIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/rawimage icon"); } }
		public static GUIContent RectMask2DIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/rectmask2d icon"); } }
		public static GUIContent ScrollbarIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/scrollbar icon"); } }
		public static GUIContent ScrollRectIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/scrollrect icon"); } }
		public static GUIContent SelectableIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/selectable icon"); } }
		public static GUIContent ShadowIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/shadow icon"); } }
		public static GUIContent SliderIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/slider icon"); } }
		public static GUIContent TextIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/text icon"); } }
		public static GUIContent ToggleIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/toggle icon"); } }
		public static GUIContent ToggleGroupIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/togglegroup icon"); } }
		public static GUIContent VerticalLayoutGroupIcon { get { return EditorGUIUtility.IconContent("unityengine/ui/verticallayoutgroup icon"); } }
		public static GUIContent UssScriptIcon { get { return EditorGUIUtility.IconContent("ussscript icon"); } }
		public static GUIContent UxmlScriptIcon { get { return EditorGUIUtility.IconContent("uxmlscript icon"); } }
		public static GUIContent VideoEffectIcon { get { return EditorGUIUtility.IconContent("videoeffect icon"); } }
		public static GUIContent VisualEffectGizmo { get { return EditorGUIUtility.IconContent("visualeffect gizmo"); } }
		public static GUIContent VisualEffectAssetIcon { get { return EditorGUIUtility.IconContent("visualeffectasset icon"); } }
		public static GUIContent WindzoneGizmo { get { return EditorGUIUtility.IconContent("windzone gizmo"); } }
		public static GUIContent ProfilerAudio { get { return EditorGUIUtility.IconContent("profiler.audio"); } }
		public static GUIContent ProfilerAudio2x { get { return EditorGUIUtility.IconContent("profiler.audio@2x"); } }
		public static GUIContent ProfilerCPU { get { return EditorGUIUtility.IconContent("profiler.cpu"); } }
		public static GUIContent ProfilerCPU2x { get { return EditorGUIUtility.IconContent("profiler.cpu@2x"); } }
		public static GUIContent ProfilerCustom { get { return EditorGUIUtility.IconContent("profiler.custom"); } }
		public static GUIContent ProfilerCustom2x { get { return EditorGUIUtility.IconContent("profiler.custom@2x"); } }
		public static GUIContent ProfilerFileAccess { get { return EditorGUIUtility.IconContent("profiler.fileaccess"); } }
		public static GUIContent ProfilerFileAccess2x { get { return EditorGUIUtility.IconContent("profiler.fileaccess@2x"); } }
		public static GUIContent ProfilerFirstFrame { get { return EditorGUIUtility.IconContent("profiler.firstframe"); } }
		public static GUIContent ProfilerGlobalIllumination { get { return EditorGUIUtility.IconContent("profiler.globalillumination"); } }
		public static GUIContent ProfilerGlobalIllumination2x { get { return EditorGUIUtility.IconContent("profiler.globalillumination@2x"); } }
		public static GUIContent ProfilerGPU { get { return EditorGUIUtility.IconContent("profiler.gpu"); } }
		public static GUIContent ProfilerGPU2x { get { return EditorGUIUtility.IconContent("profiler.gpu@2x"); } }
		public static GUIContent ProfilerInstrumentation { get { return EditorGUIUtility.IconContent("profiler.instrumentation"); } }
		public static GUIContent ProfilerLastFrame { get { return EditorGUIUtility.IconContent("profiler.lastframe"); } }
		public static GUIContent ProfilerMemory { get { return EditorGUIUtility.IconContent("profiler.memory"); } }
		public static GUIContent ProfilerMemory2x { get { return EditorGUIUtility.IconContent("profiler.memory@2x"); } }
		public static GUIContent ProfilerNetworkMessages { get { return EditorGUIUtility.IconContent("profiler.networkmessages"); } }
		public static GUIContent ProfilerNetworkMessages2x { get { return EditorGUIUtility.IconContent("profiler.networkmessages@2x"); } }
		public static GUIContent ProfilerNetworkOperations { get { return EditorGUIUtility.IconContent("profiler.networkoperations"); } }
		public static GUIContent ProfilerNetworkOperations2x { get { return EditorGUIUtility.IconContent("profiler.networkoperations@2x"); } }
		public static GUIContent ProfilerNextFrame { get { return EditorGUIUtility.IconContent("profiler.nextframe"); } }
		public static GUIContent ProfilerOpen { get { return EditorGUIUtility.IconContent("profiler.open"); } }
		public static GUIContent ProfilerOpen2x { get { return EditorGUIUtility.IconContent("profiler.open@2x"); } }
		public static GUIContent ProfilerOpen4X { get { return EditorGUIUtility.IconContent("profiler.open@4x"); } }
		public static GUIContent ProfilerPhysics { get { return EditorGUIUtility.IconContent("profiler.physics"); } }
		public static GUIContent ProfilerPhysics2D { get { return EditorGUIUtility.IconContent("profiler.physics2d"); } }
		public static GUIContent ProfilerPhysics2D2x { get { return EditorGUIUtility.IconContent("profiler.physics2d@2x"); } }
		public static GUIContent ProfilerPhysics2x { get { return EditorGUIUtility.IconContent("profiler.physics@2x"); } }
		public static GUIContent ProfilerPrevFrame { get { return EditorGUIUtility.IconContent("profiler.prevframe"); } }
		public static GUIContent ProfilerRecord { get { return EditorGUIUtility.IconContent("profiler.record"); } }
		public static GUIContent ProfilerRenderIng { get { return EditorGUIUtility.IconContent("profiler.rendering"); } }
		public static GUIContent ProfilerRenderIng2x { get { return EditorGUIUtility.IconContent("profiler.rendering@2x"); } }
		public static GUIContent ProfilerUI { get { return EditorGUIUtility.IconContent("profiler.ui"); } }
		public static GUIContent ProfilerUI2x { get { return EditorGUIUtility.IconContent("profiler.ui@2x"); } }
		public static GUIContent ProfilerUIDetails { get { return EditorGUIUtility.IconContent("profiler.uidetails"); } }
		public static GUIContent ProfilerUIDetails2x { get { return EditorGUIUtility.IconContent("profiler.uidetails@2x"); } }
		public static GUIContent ProfilerVideo { get { return EditorGUIUtility.IconContent("profiler.video"); } }
		public static GUIContent ProfilerVideo2x { get { return EditorGUIUtility.IconContent("profiler.video@2x"); } }
		public static GUIContent ProfilerVirtualTexturIng { get { return EditorGUIUtility.IconContent("profiler.virtualtexturing"); } }
		public static GUIContent ProfilerVirtualTexturIng2x { get { return EditorGUIUtility.IconContent("profiler.virtualtexturing@2x"); } }
		public static GUIContent ProfilerColumnWarningCount { get { return EditorGUIUtility.IconContent("profilercolumn.warningcount"); } }
		public static GUIContent Progress { get { return EditorGUIUtility.IconContent("progress"); } }
		public static GUIContent Progress2x { get { return EditorGUIUtility.IconContent("progress@2x"); } }
		public static GUIContent Project { get { return EditorGUIUtility.IconContent("project"); } }
		public static GUIContent Project2x { get { return EditorGUIUtility.IconContent("project@2x"); } }
		public static GUIContent RecordOff { get { return EditorGUIUtility.IconContent("record off"); } }
		public static GUIContent RecordOff2x { get { return EditorGUIUtility.IconContent("record off@2x"); } }
		public static GUIContent RecordOn { get { return EditorGUIUtility.IconContent("record on"); } }
		public static GUIContent RecordOn2x { get { return EditorGUIUtility.IconContent("record on@2x"); } }
		public static GUIContent RectToolOn { get { return EditorGUIUtility.IconContent("recttool on"); } }
		public static GUIContent RectToolOn2x { get { return EditorGUIUtility.IconContent("recttool on@2x"); } }
		public static GUIContent RectTool { get { return EditorGUIUtility.IconContent("recttool"); } }
		public static GUIContent RectTool2x { get { return EditorGUIUtility.IconContent("recttool@2x"); } }
		public static GUIContent RectTransformBlueprint { get { return EditorGUIUtility.IconContent("recttransformblueprint"); } }
		public static GUIContent RectTransformRaw { get { return EditorGUIUtility.IconContent("recttransformraw"); } }
		public static GUIContent RedGroove { get { return EditorGUIUtility.IconContent("redgroove"); } }
		public static GUIContent ReflectionProbeSelector { get { return EditorGUIUtility.IconContent("reflectionprobeselector"); } }
		public static GUIContent ReflectionProbeSelector2x { get { return EditorGUIUtility.IconContent("reflectionprobeselector@2x"); } }
		public static GUIContent Refresh { get { return EditorGUIUtility.IconContent("refresh"); } }
		public static GUIContent Refresh2x { get { return EditorGUIUtility.IconContent("refresh@2x"); } }
		public static GUIContent RePaintDot { get { return EditorGUIUtility.IconContent("repaintdot"); } }
		public static GUIContent RePaintDot2x { get { return EditorGUIUtility.IconContent("repaintdot@2x"); } }
		public static GUIContent RightBracket { get { return EditorGUIUtility.IconContent("rightbracket"); } }
		public static GUIContent RotateToolOn { get { return EditorGUIUtility.IconContent("rotatetool on"); } }
		public static GUIContent RotateToolOn2x { get { return EditorGUIUtility.IconContent("rotatetool on@2x"); } }
		public static GUIContent RotateTool { get { return EditorGUIUtility.IconContent("rotatetool"); } }
		public static GUIContent RotateTool2x { get { return EditorGUIUtility.IconContent("rotatetool@2x"); } }
		public static GUIContent RotateTool4X { get { return EditorGUIUtility.IconContent("rotatetool@4x"); } }
		public static GUIContent SaveActive { get { return EditorGUIUtility.IconContent("saveactive"); } }
		public static GUIContent SaveAs { get { return EditorGUIUtility.IconContent("saveas"); } }
		public static GUIContent SaveAs2x { get { return EditorGUIUtility.IconContent("saveas@2x"); } }
		public static GUIContent SaveFromPlay { get { return EditorGUIUtility.IconContent("savefromplay"); } }
		public static GUIContent SavePassive { get { return EditorGUIUtility.IconContent("savepassive"); } }
		public static GUIContent ScaleToolOn { get { return EditorGUIUtility.IconContent("scaletool on"); } }
		public static GUIContent ScaleToolOn2x { get { return EditorGUIUtility.IconContent("scaletool on@2x"); } }
		public static GUIContent ScaleTool { get { return EditorGUIUtility.IconContent("scaletool"); } }
		public static GUIContent ScaleTool2x { get { return EditorGUIUtility.IconContent("scaletool@2x"); } }
		public static GUIContent Scene { get { return EditorGUIUtility.IconContent("scene"); } }
		public static GUIContent Scene2x { get { return EditorGUIUtility.IconContent("scene@2x"); } }
		public static GUIContent SceneLoadIn { get { return EditorGUIUtility.IconContent("sceneloadin"); } }
		public static GUIContent SceneLoadOut { get { return EditorGUIUtility.IconContent("sceneloadout"); } }
		public static GUIContent ScenePickingNotpickableMixed { get { return EditorGUIUtility.IconContent("scenepicking_notpickable-mixed"); } }
		public static GUIContent ScenePickingNotpickableMixed2x { get { return EditorGUIUtility.IconContent("scenepicking_notpickable-mixed@2x"); } }
		public static GUIContent ScenePickingNotpickableMixedHover { get { return EditorGUIUtility.IconContent("scenepicking_notpickable-mixed_hover"); } }
		public static GUIContent ScenePickingNotpickableMixedHover2x { get { return EditorGUIUtility.IconContent("scenepicking_notpickable-mixed_hover@2x"); } }
		public static GUIContent ScenePickingNotpickable { get { return EditorGUIUtility.IconContent("scenepicking_notpickable"); } }
		public static GUIContent ScenePickingNotpickable2x { get { return EditorGUIUtility.IconContent("scenepicking_notpickable@2x"); } }
		public static GUIContent ScenePickingNotpickableHover { get { return EditorGUIUtility.IconContent("scenepicking_notpickable_hover"); } }
		public static GUIContent ScenePickingNotpickableHover2x { get { return EditorGUIUtility.IconContent("scenepicking_notpickable_hover@2x"); } }
		public static GUIContent ScenePickingPickableMixed { get { return EditorGUIUtility.IconContent("scenepicking_pickable-mixed"); } }
		public static GUIContent ScenePickingPickableMixed2x { get { return EditorGUIUtility.IconContent("scenepicking_pickable-mixed@2x"); } }
		public static GUIContent ScenePickingPickableMixedHover { get { return EditorGUIUtility.IconContent("scenepicking_pickable-mixed_hover"); } }
		public static GUIContent ScenePickingPickableMixedHover2x { get { return EditorGUIUtility.IconContent("scenepicking_pickable-mixed_hover@2x"); } }
		public static GUIContent ScenePickingPickable { get { return EditorGUIUtility.IconContent("scenepicking_pickable"); } }
		public static GUIContent ScenePickingPickable2x { get { return EditorGUIUtility.IconContent("scenepicking_pickable@2x"); } }
		public static GUIContent ScenePickingPickableHover { get { return EditorGUIUtility.IconContent("scenepicking_pickable_hover"); } }
		public static GUIContent ScenePickingPickableHover2x { get { return EditorGUIUtility.IconContent("scenepicking_pickable_hover@2x"); } }
		public static GUIContent SceneSave { get { return EditorGUIUtility.IconContent("scenesave"); } }
		public static GUIContent SceneSaveGrey { get { return EditorGUIUtility.IconContent("scenesavegrey"); } }
		public static GUIContent SceneView2DOn { get { return EditorGUIUtility.IconContent("sceneview2d on"); } }
		public static GUIContent SceneView2DOn2x { get { return EditorGUIUtility.IconContent("sceneview2d on@2x"); } }
		public static GUIContent SceneView2D { get { return EditorGUIUtility.IconContent("sceneview2d"); } }
		public static GUIContent SceneView2D2x { get { return EditorGUIUtility.IconContent("sceneview2d@2x"); } }
		public static GUIContent SceneViewAlpha { get { return EditorGUIUtility.IconContent("sceneviewalpha"); } }
		public static GUIContent SceneViewAudioOn { get { return EditorGUIUtility.IconContent("sceneviewaudio on"); } }
		public static GUIContent SceneViewAudioOn2x { get { return EditorGUIUtility.IconContent("sceneviewaudio on@2x"); } }
		public static GUIContent SceneViewAudio { get { return EditorGUIUtility.IconContent("sceneviewaudio"); } }
		public static GUIContent SceneViewAudio2x { get { return EditorGUIUtility.IconContent("sceneviewaudio@2x"); } }
		public static GUIContent SceneViewCameraOn { get { return EditorGUIUtility.IconContent("sceneviewcamera on"); } }
		public static GUIContent SceneViewCameraOn2x { get { return EditorGUIUtility.IconContent("sceneviewcamera on@2x"); } }
		public static GUIContent SceneViewCamera { get { return EditorGUIUtility.IconContent("sceneviewcamera"); } }
		public static GUIContent SceneViewCamera2x { get { return EditorGUIUtility.IconContent("sceneviewcamera@2x"); } }
		public static GUIContent SceneViewFXOn { get { return EditorGUIUtility.IconContent("sceneviewfx on"); } }
		public static GUIContent SceneViewFXOn2x { get { return EditorGUIUtility.IconContent("sceneviewfx on@2x"); } }
		public static GUIContent SceneViewFX { get { return EditorGUIUtility.IconContent("sceneviewfx"); } }
		public static GUIContent SceneViewFX2x { get { return EditorGUIUtility.IconContent("sceneviewfx@2x"); } }
		public static GUIContent SceneViewLightingOn { get { return EditorGUIUtility.IconContent("sceneviewlighting on"); } }
		public static GUIContent SceneViewLightingOn2x { get { return EditorGUIUtility.IconContent("sceneviewlighting on@2x"); } }
		public static GUIContent SceneViewLighting { get { return EditorGUIUtility.IconContent("sceneviewlighting"); } }
		public static GUIContent SceneViewLighting2x { get { return EditorGUIUtility.IconContent("sceneviewlighting@2x"); } }
		public static GUIContent SceneViewOrtho { get { return EditorGUIUtility.IconContent("sceneviewortho"); } }
		public static GUIContent SceneViewRGB { get { return EditorGUIUtility.IconContent("sceneviewrgb"); } }
		public static GUIContent SceneViewToolsOn { get { return EditorGUIUtility.IconContent("sceneviewtools on"); } }
		public static GUIContent SceneViewToolsOn2x { get { return EditorGUIUtility.IconContent("sceneviewtools on@2x"); } }
		public static GUIContent SceneViewTools { get { return EditorGUIUtility.IconContent("sceneviewtools"); } }
		public static GUIContent SceneViewTools2x { get { return EditorGUIUtility.IconContent("sceneviewtools@2x"); } }
		public static GUIContent SceneViewVisibilityOn { get { return EditorGUIUtility.IconContent("sceneviewvisibility on"); } }
		public static GUIContent SceneViewVisibilityOn2x { get { return EditorGUIUtility.IconContent("sceneviewvisibility on@2x"); } }
		public static GUIContent SceneViewVisibility { get { return EditorGUIUtility.IconContent("sceneviewvisibility"); } }
		public static GUIContent SceneViewVisibility2x { get { return EditorGUIUtility.IconContent("sceneviewvisibility@2x"); } }
		public static GUIContent SceneVisHiddenMixed { get { return EditorGUIUtility.IconContent("scenevis_hidden-mixed"); } }
		public static GUIContent SceneVisHiddenMixed2x { get { return EditorGUIUtility.IconContent("scenevis_hidden-mixed@2x"); } }
		public static GUIContent SceneVisHiddenMixedHover { get { return EditorGUIUtility.IconContent("scenevis_hidden-mixed_hover"); } }
		public static GUIContent SceneVisHiddenMixedHover2x { get { return EditorGUIUtility.IconContent("scenevis_hidden-mixed_hover@2x"); } }
		public static GUIContent SceneVisHidden { get { return EditorGUIUtility.IconContent("scenevis_hidden"); } }
		public static GUIContent SceneVisHidden2x { get { return EditorGUIUtility.IconContent("scenevis_hidden@2x"); } }
		public static GUIContent SceneVisHiddenHover { get { return EditorGUIUtility.IconContent("scenevis_hidden_hover"); } }
		public static GUIContent SceneVisHiddenHover2x { get { return EditorGUIUtility.IconContent("scenevis_hidden_hover@2x"); } }
		public static GUIContent SceneVisSceneHover { get { return EditorGUIUtility.IconContent("scenevis_scene_hover"); } }
		public static GUIContent SceneVisSceneHover2x { get { return EditorGUIUtility.IconContent("scenevis_scene_hover@2x"); } }
		public static GUIContent SceneVisVisibleMixed { get { return EditorGUIUtility.IconContent("scenevis_visible-mixed"); } }
		public static GUIContent SceneVisVisibleMixed2x { get { return EditorGUIUtility.IconContent("scenevis_visible-mixed@2x"); } }
		public static GUIContent SceneVisVisibleMixedHover { get { return EditorGUIUtility.IconContent("scenevis_visible-mixed_hover"); } }
		public static GUIContent SceneVisVisibleMixedHover2x { get { return EditorGUIUtility.IconContent("scenevis_visible-mixed_hover@2x"); } }
		public static GUIContent SceneVisVisible { get { return EditorGUIUtility.IconContent("scenevis_visible"); } }
		public static GUIContent SceneVisVisible2x { get { return EditorGUIUtility.IconContent("scenevis_visible@2x"); } }
		public static GUIContent SceneVisVisibleHover { get { return EditorGUIUtility.IconContent("scenevis_visible_hover"); } }
		public static GUIContent SceneVisVisibleHover2x { get { return EditorGUIUtility.IconContent("scenevis_visible_hover@2x"); } }
		public static GUIContent ScrollShadow { get { return EditorGUIUtility.IconContent("scrollshadow"); } }
		public static GUIContent Settings { get { return EditorGUIUtility.IconContent("settings"); } }
		public static GUIContent Settings2x { get { return EditorGUIUtility.IconContent("settings@2x"); } }
		public static GUIContent SettingsIcon2x { get { return EditorGUIUtility.IconContent("settingsicon@2x"); } }
		public static GUIContent ShowPanels { get { return EditorGUIUtility.IconContent("showpanels"); } }
		public static GUIContent GridAxisXOn { get { return EditorGUIUtility.IconContent("snap/gridaxisx on"); } }
		public static GUIContent GridAxisXOn2x { get { return EditorGUIUtility.IconContent("snap/gridaxisx on@2x"); } }
		public static GUIContent GridAxisX { get { return EditorGUIUtility.IconContent("snap/gridaxisx"); } }
		public static GUIContent GridAxisX2x { get { return EditorGUIUtility.IconContent("snap/gridaxisx@2x"); } }
		public static GUIContent GridAxisYOn { get { return EditorGUIUtility.IconContent("snap/gridaxisy on"); } }
		public static GUIContent GridAxisYOn2x { get { return EditorGUIUtility.IconContent("snap/gridaxisy on@2x"); } }
		public static GUIContent GridAxisY { get { return EditorGUIUtility.IconContent("snap/gridaxisy"); } }
		public static GUIContent GridAxisY2x { get { return EditorGUIUtility.IconContent("snap/gridaxisy@2x"); } }
		public static GUIContent GridAxisZOn { get { return EditorGUIUtility.IconContent("snap/gridaxisz on"); } }
		public static GUIContent GridAxisZOn2x { get { return EditorGUIUtility.IconContent("snap/gridaxisz on@2x"); } }
		public static GUIContent GridAxisZ { get { return EditorGUIUtility.IconContent("snap/gridaxisz"); } }
		public static GUIContent GridAxisZ2x { get { return EditorGUIUtility.IconContent("snap/gridaxisz@2x"); } }
		public static GUIContent SceneViewSnapOn { get { return EditorGUIUtility.IconContent("snap/sceneviewsnap on"); } }
		public static GUIContent SceneViewSnapOn2x { get { return EditorGUIUtility.IconContent("snap/sceneviewsnap on@2x"); } }
		public static GUIContent SceneViewSnap { get { return EditorGUIUtility.IconContent("snap/sceneviewsnap"); } }
		public static GUIContent SceneViewSnap2x { get { return EditorGUIUtility.IconContent("snap/sceneviewsnap@2x"); } }
		public static GUIContent SnapIncrement { get { return EditorGUIUtility.IconContent("snap/snapincrement"); } }
		public static GUIContent SnapIncrement2x { get { return EditorGUIUtility.IconContent("snap/snapincrement@2x"); } }
		public static GUIContent SocialNetworksFacebookShare { get { return EditorGUIUtility.IconContent("socialnetworks.facebookshare"); } }
		public static GUIContent SocialNetworksLinkedinShare { get { return EditorGUIUtility.IconContent("socialnetworks.linkedinshare"); } }
		public static GUIContent SocialNetworksTweet { get { return EditorGUIUtility.IconContent("socialnetworks.tweet"); } }
		public static GUIContent SocialNetworksUDNLogo { get { return EditorGUIUtility.IconContent("socialnetworks.udnlogo"); } }
		public static GUIContent SocialNetworksUDNOpen { get { return EditorGUIUtility.IconContent("socialnetworks.udnopen"); } }
		public static GUIContent SoftLockInline { get { return EditorGUIUtility.IconContent("softlockinline"); } }
		public static GUIContent SpeedScale { get { return EditorGUIUtility.IconContent("speedscale"); } }
		public static GUIContent StatemachineEditorArrowTip { get { return EditorGUIUtility.IconContent("statemachineeditor.arrowtip"); } }
		public static GUIContent StatemachineEditorArrowTipSelected { get { return EditorGUIUtility.IconContent("statemachineeditor.arrowtipselected"); } }
		public static GUIContent StatemachineEditorBackground { get { return EditorGUIUtility.IconContent("statemachineeditor.background"); } }
		public static GUIContent StatemachineEditorState { get { return EditorGUIUtility.IconContent("statemachineeditor.state"); } }
		public static GUIContent StatemachineEditorStateHover { get { return EditorGUIUtility.IconContent("statemachineeditor.statehover"); } }
		public static GUIContent StatemachineEditorStateSelected { get { return EditorGUIUtility.IconContent("statemachineeditor.stateselected"); } }
		public static GUIContent StatemachineEditorStateSub { get { return EditorGUIUtility.IconContent("statemachineeditor.statesub"); } }
		public static GUIContent StatemachineEditorStateSubHover { get { return EditorGUIUtility.IconContent("statemachineeditor.statesubhover"); } }
		public static GUIContent StatemachineEditorStateSubSelected { get { return EditorGUIUtility.IconContent("statemachineeditor.statesubselected"); } }
		public static GUIContent StatemachineEditorUpButton { get { return EditorGUIUtility.IconContent("statemachineeditor.upbutton"); } }
		public static GUIContent StatemachineEditorUpButtonHover { get { return EditorGUIUtility.IconContent("statemachineeditor.upbuttonhover"); } }
		public static GUIContent StepButtonOn { get { return EditorGUIUtility.IconContent("stepbutton on"); } }
		public static GUIContent StepButtonOn2x { get { return EditorGUIUtility.IconContent("stepbutton on@2x"); } }
		public static GUIContent StepButton { get { return EditorGUIUtility.IconContent("stepbutton"); } }
		public static GUIContent StepButton2x { get { return EditorGUIUtility.IconContent("stepbutton@2x"); } }
		public static GUIContent StepLeftButtonOn { get { return EditorGUIUtility.IconContent("stepleftbutton-on"); } }
		public static GUIContent StepLeftButton { get { return EditorGUIUtility.IconContent("stepleftbutton"); } }
		public static GUIContent SvIconDot0Small { get { return EditorGUIUtility.IconContent("sv_icon_dot0_sml"); } }
		public static GUIContent SvIconDot10Small { get { return EditorGUIUtility.IconContent("sv_icon_dot10_sml"); } }
		public static GUIContent SvIconDot11Small { get { return EditorGUIUtility.IconContent("sv_icon_dot11_sml"); } }
		public static GUIContent SvIconDot12Small { get { return EditorGUIUtility.IconContent("sv_icon_dot12_sml"); } }
		public static GUIContent SvIconDot13Small { get { return EditorGUIUtility.IconContent("sv_icon_dot13_sml"); } }
		public static GUIContent SvIconDot14Small { get { return EditorGUIUtility.IconContent("sv_icon_dot14_sml"); } }
		public static GUIContent SvIconDot15Small { get { return EditorGUIUtility.IconContent("sv_icon_dot15_sml"); } }
		public static GUIContent SvIconDot1Small { get { return EditorGUIUtility.IconContent("sv_icon_dot1_sml"); } }
		public static GUIContent SvIconDot2Small { get { return EditorGUIUtility.IconContent("sv_icon_dot2_sml"); } }
		public static GUIContent SvIconDot3Small { get { return EditorGUIUtility.IconContent("sv_icon_dot3_sml"); } }
		public static GUIContent SvIconDot4Small { get { return EditorGUIUtility.IconContent("sv_icon_dot4_sml"); } }
		public static GUIContent SvIconDot5Small { get { return EditorGUIUtility.IconContent("sv_icon_dot5_sml"); } }
		public static GUIContent SvIconDot6Small { get { return EditorGUIUtility.IconContent("sv_icon_dot6_sml"); } }
		public static GUIContent SvIconDot7Small { get { return EditorGUIUtility.IconContent("sv_icon_dot7_sml"); } }
		public static GUIContent SvIconDot8Small { get { return EditorGUIUtility.IconContent("sv_icon_dot8_sml"); } }
		public static GUIContent SvIconDot9Small { get { return EditorGUIUtility.IconContent("sv_icon_dot9_sml"); } }
		public static GUIContent SvIconName0 { get { return EditorGUIUtility.IconContent("sv_icon_name0"); } }
		public static GUIContent SvIconName1 { get { return EditorGUIUtility.IconContent("sv_icon_name1"); } }
		public static GUIContent SvIconName2 { get { return EditorGUIUtility.IconContent("sv_icon_name2"); } }
		public static GUIContent SvIconName3 { get { return EditorGUIUtility.IconContent("sv_icon_name3"); } }
		public static GUIContent SvIconName4 { get { return EditorGUIUtility.IconContent("sv_icon_name4"); } }
		public static GUIContent SvIconName5 { get { return EditorGUIUtility.IconContent("sv_icon_name5"); } }
		public static GUIContent SvIconName6 { get { return EditorGUIUtility.IconContent("sv_icon_name6"); } }
		public static GUIContent SvIconName7 { get { return EditorGUIUtility.IconContent("sv_icon_name7"); } }
		public static GUIContent SvIconNone { get { return EditorGUIUtility.IconContent("sv_icon_none"); } }
		public static GUIContent SvLabel0 { get { return EditorGUIUtility.IconContent("sv_label_0"); } }
		public static GUIContent SvLabel1 { get { return EditorGUIUtility.IconContent("sv_label_1"); } }
		public static GUIContent SvLabel2 { get { return EditorGUIUtility.IconContent("sv_label_2"); } }
		public static GUIContent SvLabel3 { get { return EditorGUIUtility.IconContent("sv_label_3"); } }
		public static GUIContent SvLabel4 { get { return EditorGUIUtility.IconContent("sv_label_4"); } }
		public static GUIContent SvLabel5 { get { return EditorGUIUtility.IconContent("sv_label_5"); } }
		public static GUIContent SvLabel6 { get { return EditorGUIUtility.IconContent("sv_label_6"); } }
		public static GUIContent SvLabel7 { get { return EditorGUIUtility.IconContent("sv_label_7"); } }
		public static GUIContent TabNext { get { return EditorGUIUtility.IconContent("tab_next"); } }
		public static GUIContent TabNext2x { get { return EditorGUIUtility.IconContent("tab_next@2x"); } }
		public static GUIContent TabPrev { get { return EditorGUIUtility.IconContent("tab_prev"); } }
		public static GUIContent TabPrev2x { get { return EditorGUIUtility.IconContent("tab_prev@2x"); } }
		public static GUIContent TabToFilter { get { return EditorGUIUtility.IconContent("tabtofilter"); } }
		public static GUIContent TerrainInspectorTerrainToolAdd { get { return EditorGUIUtility.IconContent("terraininspector.terraintooladd"); } }
		public static GUIContent TerrainInspectorTerrainToolAdd2x { get { return EditorGUIUtility.IconContent("terraininspector.terraintooladd@2x"); } }
		public static GUIContent TerrainInspectorTerrainToolLowerOn { get { return EditorGUIUtility.IconContent("terraininspector.terraintoollower on"); } }
		public static GUIContent TerrainInspectorTerrainToolLower { get { return EditorGUIUtility.IconContent("terraininspector.terraintoollower"); } }
		public static GUIContent TerrainInspectorTerrainToolLowerAlt { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolloweralt"); } }
		public static GUIContent TerrainInspectorTerrainToolPlantsOn { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolplants on"); } }
		public static GUIContent TerrainInspectorTerrainToolPlants { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolplants"); } }
		public static GUIContent TerrainInspectorTerrainToolPlants2x { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolplants@2x"); } }
		public static GUIContent TerrainInspectorTerrainToolPlantsAltOn { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolplantsalt on"); } }
		public static GUIContent TerrainInspectorTerrainToolPlantsAlt { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolplantsalt"); } }
		public static GUIContent TerrainInspectorTerrainToolRaiseOn { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolraise on"); } }
		public static GUIContent TerrainInspectorTerrainToolRaise { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolraise"); } }
		public static GUIContent TerrainInspectorTerrainToolSculptOn { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsculpt on"); } }
		public static GUIContent TerrainInspectorTerrainToolSculpt { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsculpt"); } }
		public static GUIContent TerrainInspectorTerrainToolSetHeightOn { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsetheight on"); } }
		public static GUIContent TerrainInspectorTerrainToolSetHeight { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsetheight"); } }
		public static GUIContent TerrainInspectorTerrainToolSetHeightAltOn { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsetheightalt on"); } }
		public static GUIContent TerrainInspectorTerrainToolSetHeightAlt { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsetheightalt"); } }
		public static GUIContent TerrainInspectorTerrainToolSettingsOn { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsettings on"); } }
		public static GUIContent TerrainInspectorTerrainToolSettings { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsettings"); } }
		public static GUIContent TerrainInspectorTerrainToolSettings2x { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsettings@2x"); } }
		public static GUIContent TerrainInspectorTerrainToolSmoothHeightOn { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsmoothheight on"); } }
		public static GUIContent TerrainInspectorTerrainToolSmoothHeight { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsmoothheight"); } }
		public static GUIContent TerrainInspectorTerrainToolsPlatOn { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsplat on"); } }
		public static GUIContent TerrainInspectorTerrainToolsPlat { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsplat"); } }
		public static GUIContent TerrainInspectorTerrainToolsPlat2x { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsplat@2x"); } }
		public static GUIContent TerrainInspectorTerrainToolsPlatAltOn { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsplatalt on"); } }
		public static GUIContent TerrainInspectorTerrainToolsPlatAlt { get { return EditorGUIUtility.IconContent("terraininspector.terraintoolsplatalt"); } }
		public static GUIContent TerrainInspectorTerrainToolTreesOn { get { return EditorGUIUtility.IconContent("terraininspector.terraintooltrees on"); } }
		public static GUIContent TerrainInspectorTerrainToolTrees { get { return EditorGUIUtility.IconContent("terraininspector.terraintooltrees"); } }
		public static GUIContent TerrainInspectorTerrainToolTrees2x { get { return EditorGUIUtility.IconContent("terraininspector.terraintooltrees@2x"); } }
		public static GUIContent TerrainInspectorTerrainToolTreesAltOn { get { return EditorGUIUtility.IconContent("terraininspector.terraintooltreesalt on"); } }
		public static GUIContent TerrainInspectorTerrainToolTreesAlt { get { return EditorGUIUtility.IconContent("terraininspector.terraintooltreesalt"); } }
		public static GUIContent TestFailed { get { return EditorGUIUtility.IconContent("testfailed"); } }
		public static GUIContent TestIgnored { get { return EditorGUIUtility.IconContent("testignored"); } }
		public static GUIContent TestInconclusive { get { return EditorGUIUtility.IconContent("testinconclusive"); } }
		public static GUIContent TestNormal { get { return EditorGUIUtility.IconContent("testnormal"); } }
		public static GUIContent TestPassed { get { return EditorGUIUtility.IconContent("testpassed"); } }
		public static GUIContent TestStopwatch { get { return EditorGUIUtility.IconContent("teststopwatch"); } }
		public static GUIContent Texture2DArrayOn { get { return EditorGUIUtility.IconContent("texture2darray on"); } }
		public static GUIContent Texture2DArrayOn2x { get { return EditorGUIUtility.IconContent("texture2darray on@2x"); } }
		public static GUIContent Texture2DArray { get { return EditorGUIUtility.IconContent("texture2darray"); } }
		public static GUIContent Texture2DArray2x { get { return EditorGUIUtility.IconContent("texture2darray@2x"); } }
		public static GUIContent ToggleSearcherPreviewOff { get { return EditorGUIUtility.IconContent("toggle_searcher_preview_off"); } }
		public static GUIContent ToggleSearcherPreviewOff2x { get { return EditorGUIUtility.IconContent("toggle_searcher_preview_off@2x"); } }
		public static GUIContent ToggleSearcherPreviewOn { get { return EditorGUIUtility.IconContent("toggle_searcher_preview_on"); } }
		public static GUIContent ToggleSearcherPreviewOn2x { get { return EditorGUIUtility.IconContent("toggle_searcher_preview_on@2x"); } }
		public static GUIContent ToggleUVOverlay { get { return EditorGUIUtility.IconContent("toggleuvoverlay"); } }
		public static GUIContent ToggleUVOverlay2x { get { return EditorGUIUtility.IconContent("toggleuvoverlay@2x"); } }
		public static GUIContent ToolBarMinus { get { return EditorGUIUtility.IconContent("toolbar minus"); } }
		public static GUIContent ToolBarMinus2x { get { return EditorGUIUtility.IconContent("toolbar minus@2x"); } }
		public static GUIContent ToolBarPlusMore { get { return EditorGUIUtility.IconContent("toolbar plus more"); } }
		public static GUIContent ToolBarPlusMore2x { get { return EditorGUIUtility.IconContent("toolbar plus more@2x"); } }
		public static GUIContent ToolBarPlus { get { return EditorGUIUtility.IconContent("toolbar plus"); } }
		public static GUIContent ToolBarPlus2x { get { return EditorGUIUtility.IconContent("toolbar plus@2x"); } }
		public static GUIContent ToolHandleCenter { get { return EditorGUIUtility.IconContent("toolhandlecenter"); } }
		public static GUIContent ToolHandleCenter2x { get { return EditorGUIUtility.IconContent("toolhandlecenter@2x"); } }
		public static GUIContent ToolHandleGlobal { get { return EditorGUIUtility.IconContent("toolhandleglobal"); } }
		public static GUIContent ToolHandleGlobal2x { get { return EditorGUIUtility.IconContent("toolhandleglobal@2x"); } }
		public static GUIContent ToolHandleLocal { get { return EditorGUIUtility.IconContent("toolhandlelocal"); } }
		public static GUIContent ToolHandleLocal2x { get { return EditorGUIUtility.IconContent("toolhandlelocal@2x"); } }
		public static GUIContent ToolHandlePivot { get { return EditorGUIUtility.IconContent("toolhandlepivot"); } }
		public static GUIContent ToolHandlePivot2x { get { return EditorGUIUtility.IconContent("toolhandlepivot@2x"); } }
		public static GUIContent ToolsIcon { get { return EditorGUIUtility.IconContent("toolsicon"); } }
		public static GUIContent Tranp { get { return EditorGUIUtility.IconContent("tranp"); } }
		public static GUIContent TransformToolOn { get { return EditorGUIUtility.IconContent("transformtool on"); } }
		public static GUIContent TransformToolOn2x { get { return EditorGUIUtility.IconContent("transformtool on@2x"); } }
		public static GUIContent TransformTool { get { return EditorGUIUtility.IconContent("transformtool"); } }
		public static GUIContent TransformTool2x { get { return EditorGUIUtility.IconContent("transformtool@2x"); } }
		public static GUIContent TreeIcon { get { return EditorGUIUtility.IconContent("tree_icon"); } }
		public static GUIContent TreeIconBranch { get { return EditorGUIUtility.IconContent("tree_icon_branch"); } }
		public static GUIContent TreeIconBranchFrond { get { return EditorGUIUtility.IconContent("tree_icon_branch_frond"); } }
		public static GUIContent TreeIconFrond { get { return EditorGUIUtility.IconContent("tree_icon_frond"); } }
		public static GUIContent TreeIconLeaf { get { return EditorGUIUtility.IconContent("tree_icon_leaf"); } }
		public static GUIContent TreeEditorAddBranches { get { return EditorGUIUtility.IconContent("treeeditor.addbranches"); } }
		public static GUIContent TreeEditorAddLeaves { get { return EditorGUIUtility.IconContent("treeeditor.addleaves"); } }
		public static GUIContent TreeEditorBranchOn { get { return EditorGUIUtility.IconContent("treeeditor.branch on"); } }
		public static GUIContent TreeEditorBranch { get { return EditorGUIUtility.IconContent("treeeditor.branch"); } }
		public static GUIContent TreeEditorBranchFreeHandOn { get { return EditorGUIUtility.IconContent("treeeditor.branchfreehand on"); } }
		public static GUIContent TreeEditorBranchFreeHand { get { return EditorGUIUtility.IconContent("treeeditor.branchfreehand"); } }
		public static GUIContent TreeEditorBranchRotateOn { get { return EditorGUIUtility.IconContent("treeeditor.branchrotate on"); } }
		public static GUIContent TreeEditorBranchRotate { get { return EditorGUIUtility.IconContent("treeeditor.branchrotate"); } }
		public static GUIContent TreeEditorBranchScaleOn { get { return EditorGUIUtility.IconContent("treeeditor.branchscale on"); } }
		public static GUIContent TreeEditorBranchScale { get { return EditorGUIUtility.IconContent("treeeditor.branchscale"); } }
		public static GUIContent TreeEditorBranchTranslateOn { get { return EditorGUIUtility.IconContent("treeeditor.branchtranslate on"); } }
		public static GUIContent TreeEditorBranchTranslate { get { return EditorGUIUtility.IconContent("treeeditor.branchtranslate"); } }
		public static GUIContent TreeEditorDistributionOn { get { return EditorGUIUtility.IconContent("treeeditor.distribution on"); } }
		public static GUIContent TreeEditorDistribution { get { return EditorGUIUtility.IconContent("treeeditor.distribution"); } }
		public static GUIContent TreeEditorDuplicate { get { return EditorGUIUtility.IconContent("treeeditor.duplicate"); } }
		public static GUIContent TreeEditorGeometryOn { get { return EditorGUIUtility.IconContent("treeeditor.geometry on"); } }
		public static GUIContent TreeEditorGeometry { get { return EditorGUIUtility.IconContent("treeeditor.geometry"); } }
		public static GUIContent TreeEditorLeafOn { get { return EditorGUIUtility.IconContent("treeeditor.leaf on"); } }
		public static GUIContent TreeEditorLeaf { get { return EditorGUIUtility.IconContent("treeeditor.leaf"); } }
		public static GUIContent TreeEditorLeafFreeHandOn { get { return EditorGUIUtility.IconContent("treeeditor.leaffreehand on"); } }
		public static GUIContent TreeEditorLeafFreeHand { get { return EditorGUIUtility.IconContent("treeeditor.leaffreehand"); } }
		public static GUIContent TreeEditorLeafRotateOn { get { return EditorGUIUtility.IconContent("treeeditor.leafrotate on"); } }
		public static GUIContent TreeEditorLeafRotate { get { return EditorGUIUtility.IconContent("treeeditor.leafrotate"); } }
		public static GUIContent TreeEditorLeafScaleOn { get { return EditorGUIUtility.IconContent("treeeditor.leafscale on"); } }
		public static GUIContent TreeEditorLeafScale { get { return EditorGUIUtility.IconContent("treeeditor.leafscale"); } }
		public static GUIContent TreeEditorLeafTranslateOn { get { return EditorGUIUtility.IconContent("treeeditor.leaftranslate on"); } }
		public static GUIContent TreeEditorLeafTranslate { get { return EditorGUIUtility.IconContent("treeeditor.leaftranslate"); } }
		public static GUIContent TreeEditorMaterialOn { get { return EditorGUIUtility.IconContent("treeeditor.material on"); } }
		public static GUIContent TreeEditorMaterial { get { return EditorGUIUtility.IconContent("treeeditor.material"); } }
		public static GUIContent TreeEditorRefresh { get { return EditorGUIUtility.IconContent("treeeditor.refresh"); } }
		public static GUIContent TreeEditorTrash { get { return EditorGUIUtility.IconContent("treeeditor.trash"); } }
		public static GUIContent TreeEditorWindOn { get { return EditorGUIUtility.IconContent("treeeditor.wind on"); } }
		public static GUIContent TreeEditorWind { get { return EditorGUIUtility.IconContent("treeeditor.wind"); } }
		public static GUIContent UndoHistory { get { return EditorGUIUtility.IconContent("undohistory"); } }
		public static GUIContent UndoHistory2x { get { return EditorGUIUtility.IconContent("undohistory@2x"); } }
		public static GUIContent UnityEditorAnimationWindow { get { return EditorGUIUtility.IconContent("unityeditor.animationwindow"); } }
		public static GUIContent UnityEditorAnimationWindow2x { get { return EditorGUIUtility.IconContent("unityeditor.animationwindow@2x"); } }
		public static GUIContent UnityEditorConsoleWindow { get { return EditorGUIUtility.IconContent("unityeditor.consolewindow"); } }
		public static GUIContent UnityEditorConsoleWindow2x { get { return EditorGUIUtility.IconContent("unityeditor.consolewindow@2x"); } }
		public static GUIContent UnityEditorDebugInspectorWindow { get { return EditorGUIUtility.IconContent("unityeditor.debuginspectorwindow"); } }
		public static GUIContent UnityEditorDeviceSimulationSimulatorWindow { get { return EditorGUIUtility.IconContent("unityeditor.devicesimulation.simulatorwindow"); } }
		public static GUIContent UnityEditorDeviceSimulationSimulatorWindow2x { get { return EditorGUIUtility.IconContent("unityeditor.devicesimulation.simulatorwindow@2x"); } }
		public static GUIContent UnityEditorFindDependencies { get { return EditorGUIUtility.IconContent("unityeditor.finddependencies"); } }
		public static GUIContent UnityEditorGameView { get { return EditorGUIUtility.IconContent("unityeditor.gameview"); } }
		public static GUIContent UnityEditorGameView2x { get { return EditorGUIUtility.IconContent("unityeditor.gameview@2x"); } }
		public static GUIContent UnityEditorGraphsAnimatorControllerTool { get { return EditorGUIUtility.IconContent("unityeditor.graphs.animatorcontrollertool"); } }
		public static GUIContent UnityEditorGraphsAnimatorControllerTool2x { get { return EditorGUIUtility.IconContent("unityeditor.graphs.animatorcontrollertool@2x"); } }
		public static GUIContent UnityEditorHierarchyWindow { get { return EditorGUIUtility.IconContent("unityeditor.hierarchywindow"); } }
		public static GUIContent UnityEditorHierarchyWindow2x { get { return EditorGUIUtility.IconContent("unityeditor.hierarchywindow@2x"); } }
		public static GUIContent UnityEditorHistoryWindow { get { return EditorGUIUtility.IconContent("unityeditor.historywindow"); } }
		public static GUIContent UnityEditorHistoryWindow2x { get { return EditorGUIUtility.IconContent("unityeditor.historywindow@2x"); } }
		public static GUIContent UnityEditorInspectorWindow { get { return EditorGUIUtility.IconContent("unityeditor.inspectorwindow"); } }
		public static GUIContent UnityEditorInspectorWindow2x { get { return EditorGUIUtility.IconContent("unityeditor.inspectorwindow@2x"); } }
		public static GUIContent UnityEditorProfilerWindow { get { return EditorGUIUtility.IconContent("unityeditor.profilerwindow"); } }
		public static GUIContent UnityEditorProfilerWindow2x { get { return EditorGUIUtility.IconContent("unityeditor.profilerwindow@2x"); } }
		public static GUIContent UnityEditorScenehierarchyWindow { get { return EditorGUIUtility.IconContent("unityeditor.scenehierarchywindow"); } }
		public static GUIContent UnityEditorScenehierarchyWindow2x { get { return EditorGUIUtility.IconContent("unityeditor.scenehierarchywindow@2x"); } }
		public static GUIContent UnityEditorSceneView { get { return EditorGUIUtility.IconContent("unityeditor.sceneview"); } }
		public static GUIContent UnityEditorSceneView2x { get { return EditorGUIUtility.IconContent("unityeditor.sceneview@2x"); } }
		public static GUIContent UnityEditorTimelineTimelineWindow { get { return EditorGUIUtility.IconContent("unityeditor.timeline.timelinewindow"); } }
		public static GUIContent UnityEditorTimelineTimelineWindow2x { get { return EditorGUIUtility.IconContent("unityeditor.timeline.timelinewindow@2x"); } }
		public static GUIContent UnityEditorVersionControl { get { return EditorGUIUtility.IconContent("unityeditor.versioncontrol"); } }
		public static GUIContent UnityEditorVersionControl2x { get { return EditorGUIUtility.IconContent("unityeditor.versioncontrol@2x"); } }
		public static GUIContent UnityLogo { get { return EditorGUIUtility.IconContent("unitylogo"); } }
		public static GUIContent UnityLogoLarge { get { return EditorGUIUtility.IconContent("unitylogolarge"); } }
		public static GUIContent Unlinked { get { return EditorGUIUtility.IconContent("unlinked"); } }
		public static GUIContent Unlinked2x { get { return EditorGUIUtility.IconContent("unlinked@2x"); } }
		public static GUIContent UpArrow { get { return EditorGUIUtility.IconContent("uparrow"); } }
		public static GUIContent Valid { get { return EditorGUIUtility.IconContent("valid"); } }
		public static GUIContent Valid2x { get { return EditorGUIUtility.IconContent("valid@2x"); } }
		public static GUIContent VerticalSplit { get { return EditorGUIUtility.IconContent("verticalsplit"); } }
		public static GUIContent ViewToolMoveOn { get { return EditorGUIUtility.IconContent("viewtoolmove on"); } }
		public static GUIContent ViewToolMoveOn2x { get { return EditorGUIUtility.IconContent("viewtoolmove on@2x"); } }
		public static GUIContent ViewToolMove { get { return EditorGUIUtility.IconContent("viewtoolmove"); } }
		public static GUIContent ViewToolMove2x { get { return EditorGUIUtility.IconContent("viewtoolmove@2x"); } }
		public static GUIContent ViewToolOrbitOn { get { return EditorGUIUtility.IconContent("viewtoolorbit on"); } }
		public static GUIContent ViewToolOrbitOn2x { get { return EditorGUIUtility.IconContent("viewtoolorbit on@2x"); } }
		public static GUIContent ViewToolOrbit { get { return EditorGUIUtility.IconContent("viewtoolorbit"); } }
		public static GUIContent ViewToolOrbit2x { get { return EditorGUIUtility.IconContent("viewtoolorbit@2x"); } }
		public static GUIContent ViewToolZoomOn { get { return EditorGUIUtility.IconContent("viewtoolzoom on"); } }
		public static GUIContent ViewToolZoomOn2x { get { return EditorGUIUtility.IconContent("viewtoolzoom on@2x"); } }
		public static GUIContent ViewToolZoom { get { return EditorGUIUtility.IconContent("viewtoolzoom"); } }
		public static GUIContent ViewToolZoom2x { get { return EditorGUIUtility.IconContent("viewtoolzoom@2x"); } }
		public static GUIContent VisibilityOff { get { return EditorGUIUtility.IconContent("visibilityoff"); } }
		public static GUIContent VisibilityOn { get { return EditorGUIUtility.IconContent("visibilityon"); } }
		public static GUIContent VisualQueryBuilder { get { return EditorGUIUtility.IconContent("visualquerybuilder"); } }
		public static GUIContent VisualQueryBuilder2x { get { return EditorGUIUtility.IconContent("visualquerybuilder@2x"); } }
		public static GUIContent VUMeterTextureHorizontal { get { return EditorGUIUtility.IconContent("vumetertexturehorizontal"); } }
		public static GUIContent VUMeterTextureVertical { get { return EditorGUIUtility.IconContent("vumetertexturevertical"); } }
		public static GUIContent WaitSpin00 { get { return EditorGUIUtility.IconContent("waitspin00"); } }
		public static GUIContent WaitSpin01 { get { return EditorGUIUtility.IconContent("waitspin01"); } }
		public static GUIContent WaitSpin02 { get { return EditorGUIUtility.IconContent("waitspin02"); } }
		public static GUIContent WaitSpin03 { get { return EditorGUIUtility.IconContent("waitspin03"); } }
		public static GUIContent WaitSpin04 { get { return EditorGUIUtility.IconContent("waitspin04"); } }
		public static GUIContent WaitSpin05 { get { return EditorGUIUtility.IconContent("waitspin05"); } }
		public static GUIContent WaitSpin06 { get { return EditorGUIUtility.IconContent("waitspin06"); } }
		public static GUIContent WaitSpin07 { get { return EditorGUIUtility.IconContent("waitspin07"); } }
		public static GUIContent WaitSpin08 { get { return EditorGUIUtility.IconContent("waitspin08"); } }
		public static GUIContent WaitSpin09 { get { return EditorGUIUtility.IconContent("waitspin09"); } }
		public static GUIContent WaitSpin10 { get { return EditorGUIUtility.IconContent("waitspin10"); } }
		public static GUIContent WaitSpin11 { get { return EditorGUIUtility.IconContent("waitspin11"); } }
		public static GUIContent WelcomeScreenStoreLogo { get { return EditorGUIUtility.IconContent("WelcomeScreen.AssetStoreLogo"); } }
		public static GUIContent WindowButtonGraph { get { return EditorGUIUtility.IconContent("winbtn_graph"); } }
		public static GUIContent WindowButtonGraphCloseH { get { return EditorGUIUtility.IconContent("winbtn_graph_close_h"); } }
		public static GUIContent WindowButtonGraphMaxH { get { return EditorGUIUtility.IconContent("winbtn_graph_max_h"); } }
		public static GUIContent WindowButtonGraphMinH { get { return EditorGUIUtility.IconContent("winbtn_graph_min_h"); } }
		public static GUIContent WindowButtonMacClose { get { return EditorGUIUtility.IconContent("winbtn_mac_close"); } }
		public static GUIContent WindowButtonMacClose2x { get { return EditorGUIUtility.IconContent("winbtn_mac_close@2x"); } }
		public static GUIContent WindowButtonMacCloseA { get { return EditorGUIUtility.IconContent("winbtn_mac_close_a"); } }
		public static GUIContent WindowButtonMacCloseA2x { get { return EditorGUIUtility.IconContent("winbtn_mac_close_a@2x"); } }
		public static GUIContent WindowButtonMacCloseH { get { return EditorGUIUtility.IconContent("winbtn_mac_close_h"); } }
		public static GUIContent WindowButtonMacCloseH2x { get { return EditorGUIUtility.IconContent("winbtn_mac_close_h@2x"); } }
		public static GUIContent WindowButtonMacInact { get { return EditorGUIUtility.IconContent("winbtn_mac_inact"); } }
		public static GUIContent WindowButtonMacInact2x { get { return EditorGUIUtility.IconContent("winbtn_mac_inact@2x"); } }
		public static GUIContent WindowButtonMacMax { get { return EditorGUIUtility.IconContent("winbtn_mac_max"); } }
		public static GUIContent WindowButtonMacMax2x { get { return EditorGUIUtility.IconContent("winbtn_mac_max@2x"); } }
		public static GUIContent WindowButtonMacMaxA { get { return EditorGUIUtility.IconContent("winbtn_mac_max_a"); } }
		public static GUIContent WindowButtonMacMaxA2x { get { return EditorGUIUtility.IconContent("winbtn_mac_max_a@2x"); } }
		public static GUIContent WindowButtonMacMaxH { get { return EditorGUIUtility.IconContent("winbtn_mac_max_h"); } }
		public static GUIContent WindowButtonMacMaxH2x { get { return EditorGUIUtility.IconContent("winbtn_mac_max_h@2x"); } }
		public static GUIContent WindowButtonMacMin { get { return EditorGUIUtility.IconContent("winbtn_mac_min"); } }
		public static GUIContent WindowButtonMacMin2x { get { return EditorGUIUtility.IconContent("winbtn_mac_min@2x"); } }
		public static GUIContent WindowButtonMacMinA { get { return EditorGUIUtility.IconContent("winbtn_mac_min_a"); } }
		public static GUIContent WindowButtonMacMinA2x { get { return EditorGUIUtility.IconContent("winbtn_mac_min_a@2x"); } }
		public static GUIContent WindowButtonMacMinH { get { return EditorGUIUtility.IconContent("winbtn_mac_min_h"); } }
		public static GUIContent WindowButtonMacMinH2x { get { return EditorGUIUtility.IconContent("winbtn_mac_min_h@2x"); } }
		public static GUIContent WindowButtonWinClose { get { return EditorGUIUtility.IconContent("winbtn_win_close"); } }
		public static GUIContent WindowButtonWinClose2x { get { return EditorGUIUtility.IconContent("winbtn_win_close@2x"); } }
		public static GUIContent WindowButtonWinCloseA { get { return EditorGUIUtility.IconContent("winbtn_win_close_a"); } }
		public static GUIContent WindowButtonWinCloseA2x { get { return EditorGUIUtility.IconContent("winbtn_win_close_a@2x"); } }
		public static GUIContent WindowButtonWinCloseH { get { return EditorGUIUtility.IconContent("winbtn_win_close_h"); } }
		public static GUIContent WindowButtonWinCloseH2x { get { return EditorGUIUtility.IconContent("winbtn_win_close_h@2x"); } }
		public static GUIContent WindowButtonWinMax { get { return EditorGUIUtility.IconContent("winbtn_win_max"); } }
		public static GUIContent WindowButtonWinMax2x { get { return EditorGUIUtility.IconContent("winbtn_win_max@2x"); } }
		public static GUIContent WindowButtonWinMaxA { get { return EditorGUIUtility.IconContent("winbtn_win_max_a"); } }
		public static GUIContent WindowButtonWinMaxA2x { get { return EditorGUIUtility.IconContent("winbtn_win_max_a@2x"); } }
		public static GUIContent WindowButtonWinMaxH { get { return EditorGUIUtility.IconContent("winbtn_win_max_h"); } }
		public static GUIContent WindowButtonWinMaxH2x { get { return EditorGUIUtility.IconContent("winbtn_win_max_h@2x"); } }
		public static GUIContent WindowButtonWinMin { get { return EditorGUIUtility.IconContent("winbtn_win_min"); } }
		public static GUIContent WindowButtonWinMinA { get { return EditorGUIUtility.IconContent("winbtn_win_min_a"); } }
		public static GUIContent WindowButtonWinMinH { get { return EditorGUIUtility.IconContent("winbtn_win_min_h"); } }
		public static GUIContent WindowButtonWinRest { get { return EditorGUIUtility.IconContent("winbtn_win_rest"); } }
		public static GUIContent WindowButtonWinRestA { get { return EditorGUIUtility.IconContent("winbtn_win_rest_a"); } }
		public static GUIContent WindowButtonWinRestH { get { return EditorGUIUtility.IconContent("winbtn_win_rest_h"); } }
		public static GUIContent WindowButtonWinRestore { get { return EditorGUIUtility.IconContent("winbtn_win_restore"); } }
		public static GUIContent WindowButtonWinRestore2x { get { return EditorGUIUtility.IconContent("winbtn_win_restore@2x"); } }
		public static GUIContent WindowButtonWinRestoreA { get { return EditorGUIUtility.IconContent("winbtn_win_restore_a"); } }
		public static GUIContent WindowButtonWinRestoreA2x { get { return EditorGUIUtility.IconContent("winbtn_win_restore_a@2x"); } }
		public static GUIContent WindowButtonWinRestoreH { get { return EditorGUIUtility.IconContent("winbtn_win_restore_h"); } }
		public static GUIContent WindowButtonWinRestoreH2x { get { return EditorGUIUtility.IconContent("winbtn_win_restore_h@2x"); } }
	}
}
