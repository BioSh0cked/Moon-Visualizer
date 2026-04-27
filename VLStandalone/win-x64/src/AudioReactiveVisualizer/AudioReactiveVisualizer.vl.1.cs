extern alias e204;
extern alias e214;
extern alias e205;
extern alias e228;
extern alias e1;
extern alias e2;
extern alias e227;
extern alias e5;
extern alias e212;
using n37 = e1::VL.Lib.Reactive;
using n32 = e227::_VL_Audio_.Audio.Source;
using n1 = e2::VL.AppServices.CompilerServices;
using n27 = e1::VL.Core.Utils;
using n6 = global::_AudioReactiveVisualizer_.Main;
using n35 = global::System.Drawing;
using n31 = global::System.Runtime.CompilerServices;
using n24 = e212::_VL_Skia_.Graphics.Skia;
using n14 = global::System.Collections.Generic;
using n5 = e1::VL.Core;
using n25 = e214::VL.Skia;
using n38 = e204::_CoreLibBasics_.Primitive;
using n22 = e5::Stride.Core.Mathematics;
using n19 = e204::_CoreLibBasics_.Animation.FrameBased;
using n34 = e227::_VL_Audio_.Audio.Analysis;
using n29 = e1::VL.Core.Commands;
using n8 = e1::VL.Model;
using n36 = e204::_VL_Reactive_.Reactive.Channel;
using n10 = e2::VL.AppServices;
using n11 = e228::VL.Audio;
using n12 = e1::VL.Lib.Collections;
using n3 = e2::VL.Core.CompilerServices;
using n30 = e204::_VL_Collections_.Collections.Interfaces.IReadOnlyList;
using n28 = e212::_VL_Skia_.Graphics.Skia.Layer;
using n39 = e204::_CoreLibBasics_.Math;
using n21 = e204::_CoreLibBasics_._2D.Vector2;
using n23 = e1::VL.Lib.Mathematics;
using n15 = e204::_VL_Collections_.Collections.Sequence;
using n7 = e2::VL.Core;
using n18 = e212::_VL_Skia_.Graphics.Skia.Layers;
using n20 = global::_AudioReactiveVisualizer_;
using n16 = e205::VL.Lib.Collections.Spread;
using n13 = e204::_VL_Collections_.Collections.Spread;
using n2 = global::System;
using n4 = e1::VL.Core.Import;
using n33 = e227::_VL_Audio_.Audio;
using n26 = e2::VL.AppServices.CompilerServices.Intrinsics;
using n17 = e204::_CoreLibBasics_.Primitive.Float32;
using n9 = e1::VL.Core.CompilerServices;
namespace _AudioReactiveVisualizer_.Main
{
    [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"GJ1qVhe2U8iQcErgM02WAO")]
    [n2.Serializable]
    [n3.Name(@"AudioReactiveVisualizerApplication")]
    [n4.Category(@"Main")]
    [n4.Smell(n5.SymbolSmell.Hidden)]
    public sealed class AudioReactiveVisualizerApplication_P : n7.PatchedObject<n6.AudioReactiveVisualizerApplication_P>, n2.IDisposable
    {
        [return: n4.Pin(IsState = true)]
        [n9.CreateNew]
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"BZfyHIn50AMOhy8qYm4OJJ")]
        [n3.ShowCategory(true)]
        [n4.Smell(n5.SymbolSmell.Hidden)]
        public static n6.AudioReactiveVisualizerApplication_P Create([n4.Pin(Name = @"Node Context", Visibility = n8.PinVisibility.Hidden)] n5.NodeContext Node_Context){
            Node_Context = Node_Context.WithDefinitionId(@"RckyMa2RP3mPQ0ttObPClA", @"GJ1qVhe2U8iQcErgM02WAO");
            var instance = new AudioReactiveVisualizerApplication_P(Node_Context, n7.PatchedObject.NewIdentity());
            return instance.__Create__(Node_Context);
        }
        [n2.ThreadStatic]
        private static n6.AudioReactiveVisualizerApplication_P __instanceBeingConstructed__;
        [return: n4.Pin(IsState = true)]
        [n9.CreateDefault]
        [n1.Element()]
        [n3.ShowCategory(true)]
        [n4.Smell(n5.SymbolSmell.Hidden)]
        public static n6.AudioReactiveVisualizerApplication_P CreateDefault(){
            if (__instanceBeingConstructed__ != null)
            {
                return n10.CompilationHelper.ReportRecursive(__instanceBeingConstructed__);
            }
            try
            {
                var context = n5.NodeContext.CurrentRoot.WithDefinitionId(@"RckyMa2RP3mPQ0ttObPClA", @"GJ1qVhe2U8iQcErgM02WAO");
                var instance = new AudioReactiveVisualizerApplication_P(context, n7.PatchedObject.NewIdentity());
                __instanceBeingConstructed__ = instance;
                return instance.__CreateDefault__();
            }
            finally
            {
                __instanceBeingConstructed__ = null;
            }
        }
        [return: n4.Pin(IsState = true)]
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"SKJMq4OWRupPBKu5KHiGNr")]
        [n3.ShowCategory(true)]
        [n4.Smell(n5.SymbolSmell.Hidden)]
        public n6.AudioReactiveVisualizerApplication_P Update(){
            var nc_39 = __GetContext__();
            int __pad_EVzxxwlQLndMP9grFBHoLE_0 = __slot_EVzxxwlQLndMP9grFBHoLE;
            n11.FFTBinCountEnum __pad_LjdFqnu69uCQGN0qBYcJuT_1 = __slot_LjdFqnu69uCQGN0qBYcJuT;
            n11.WindowFunction __pad_IY88FhCpk0tLFU5YWe2Vtx_2 = __slot_IY88FhCpk0tLFU5YWe2Vtx;
            float __pad_H573wQc495MLkDXXu6U47g_3 = __slot_H573wQc495MLkDXXu6U47g;
            float __pad_KWb570t0jLgQLf6b6RPOao_4 = __slot_KWb570t0jLgQLf6b6RPOao;
            float __pad_IFjJAgWa47QMmVSZK89Ad6_5 = __slot_IFjJAgWa47QMmVSZK89Ad6;
            float __pad_HeQu8dMBZcHPTZQyNkk7nJ_6 = __slot_HeQu8dMBZcHPTZQyNkk7nJ;
            float __pad_HS7BmYmpFpwOmj9moNQJeI_7 = __slot_HS7BmYmpFpwOmj9moNQJeI;
            int __pad_JSsRw72aPFeQKiZcyOTXzV_8 = __slot_JSsRw72aPFeQKiZcyOTXzV;
            n11.WasapiInputDevice __pad_TLnN0XZASgPMCoRpgaBWRK_9 = __slot_TLnN0XZASgPMCoRpgaBWRK;
            string __pad_A4Qg0X6Q9J3LkG7mN2DpYx_10 = __slot_A4Qg0X6Q9J3LkG7mN2DpYx;
            var AudioIn_11 = this.__p_R8F6ObfWTfZM4nekGdr68m;
            AudioIn_11 = AudioIn_11.Update(Output_Out: out n12.Spread<n11.AudioSignal> Output_12);
            n11.AudioSignal Default_Value_13 = default(n11.AudioSignal);
            n13._Operations_.GetSlice<n11.AudioSignal>(Input_In: Output_12, Default_Value_In: Default_Value_13, Index_In: __pad_EVzxxwlQLndMP9grFBHoLE_0, Result_Out: out n11.AudioSignal Result_14);
            var Meter_15 = this.__p_Sve0jJ5h1yzLT3yKk4oedm;
            Meter_15 = Meter_15.Update(Input_In: Result_14, Level_Out: out float Level_16, Level_dBFS_Out: out float Level_dBFS_17);
            float __pad_LdA0Hmk4ryAP0wOoulOyre_18 = Level_16;
            float __pad_UzXtYMlf12LPj1PRN6wrQ3_19 = Level_dBFS_17;
            var FFT_20 = this.__p_IbjV3OTaF7CQM1iXyE3nI6;
            FFT_20 = FFT_20.Update(Input_In: Result_14, Bin_Count_In: __pad_LjdFqnu69uCQGN0qBYcJuT_1, Window_Function_In: __pad_IY88FhCpk0tLFU5YWe2Vtx_2, Smoothing_In: __pad_H573wQc495MLkDXXu6U47g_3, db_Range_In: __pad_KWb570t0jLgQLf6b6RPOao_4, Output_Out: out n14.IReadOnlyList<float> Output_21);
            n14.IEnumerable<float> Input_22 = (n14.IEnumerable<float>)Output_21;
            n15._Operations_.Count<float>(Input_In: Input_22, Result_Out: out int Result_23);
            var LinearSpread_24 = this.__p_Cq4GHN80dS7OKhmsKevdJR;
            float Center_25 = 0f;
            n16.SpreadGenerators.LinearSpreadAlignment Alignment_26 = default(n16.SpreadGenerators.LinearSpreadAlignment);
            float Phase_27 = 0f;
            LinearSpread_24 = LinearSpread_24.Update(Center_In: Center_25, Width_In: __pad_IFjJAgWa47QMmVSZK89Ad6_5, Alignment_In: Alignment_26, Phase_In: Phase_27, Count_In: Result_23, Output_Out: out n12.Spread<float> Output_28);
            float Input_2_29 = (float)Result_23;
            n17._Operations_.OperatorDivide(Input_In: __pad_IFjJAgWa47QMmVSZK89Ad6_5, Input_2_In: Input_2_29, Output_Out: out float Output_30);
            var enumerator_31 = Output_21.GetEnumerator();
            var enumerator_33 = n3.CollectionExtensions.AsSpan(Output_28).GetEnumerator();
            var manager_58 = !this.__loop_NeFeqFDqMN4M5KyWCqF24i.IsDefault ? this.__loop_NeFeqFDqMN4M5KyWCqF24i : new n26.LifetimeManager(new());
            var iterator_59 = manager_58.GetIterator(nc_39);
            var builder_60 = n27.CollectionBuilders.GetBuilder(this.__cp_FoWlg3V5PDsOwpsHc8atHq, 16);
            n12.Spread<n25.ILayer> output_61;
            try
            {
                var i_35 = 0;
                while (enumerator_31.MoveNext() && enumerator_33.MoveNext())
                {
                    var splicer_32 = enumerator_31.Current;
                    var splicer_34 = enumerator_33.Current;
                    var i_local_36 = i_35;
                    __Qm5A9NqbWjUNecQ6tUwRzY state_37;
                    if (!iterator_59.MoveNext(out state_37))
                    {
                        state_37 = new __Qm5A9NqbWjUNecQ6tUwRzY();
                        iterator_59.Add(state_37);
                        var Rectangle_38 = state_37.__p_TIVn2j0LeykOov8IM8oMNo;
                        n5.NodeContext Node_Context_40 = nc_39.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"TIVn2j0LeykOov8IM8oMNo");
                        Rectangle_38 = n18.Rectangle_P.Create(Node_Context: Node_Context_40);
                        state_37.__p_TIVn2j0LeykOov8IM8oMNo = Rectangle_38;
                        var IIR__LowPass__41 = state_37.__p_F2m9oGsCUnPLr3nKNKXXCH;
                        n5.NodeContext Node_Context_42 = nc_39.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"F2m9oGsCUnPLr3nKNKXXCH");
                        IIR__LowPass__41 = n19.IIR_LowPass_R<float>.Create<n20.__AdaptiveImplementations__RckyMa2RP3mPQ0ttObPClA>(Node_Context: Node_Context_42);
                        state_37.__p_F2m9oGsCUnPLr3nKNKXXCH = IIR__LowPass__41;
                    }
                    float X_43 = splicer_34;
                    float Y_44 = 0.8f;
                    n21._Operations_.Vector_Join(X_In: X_43, Y_In: Y_44, Output_Out: out n22.Vector2 Output_45);
                    float Value_46 = splicer_32;
                    var IIR__LowPass__47 = state_37.__p_F2m9oGsCUnPLr3nKNKXXCH;
                    float Alpha_48 = 0.5f;
                    bool Reset_49 = false;
                    IIR__LowPass__47 = IIR__LowPass__47.Update<n20.__AdaptiveImplementations__RckyMa2RP3mPQ0ttObPClA>(Value_In: Value_46, Alpha_In: Alpha_48, Reset_In: Reset_49, Value_Out: out float Value_50);
                    n17._Operations_.OperatorMultiply(Input_In: Value_50, Input_2_In: __pad_HeQu8dMBZcHPTZQyNkk7nJ_6, Output_Out: out float Output_51);
                    n21._Operations_.Vector_Join(X_In: Output_30, Y_In: Output_51, Output_Out: out n22.Vector2 Output_52);
                    var Rectangle_53 = state_37.__p_TIVn2j0LeykOov8IM8oMNo;
                    n23.RectangleAnchor Anchor_54 = __v_HWIjBaOclZoPePvjn6YjxN;
                    n24.SkiaPaint_R Paint_55 = __v_MRdax2OeudcPV1x6yejp11;
                    bool Enabled_56 = true;
                    Rectangle_53 = Rectangle_53.Update(Position_In: Output_45, Size_In: Output_52, Anchor_In: Anchor_54, Paint_In: Paint_55, Enabled_In: Enabled_56, Output_Out: out n25.ILayer Output_57);
                    if (this.__GetContext__().IsImmutable)
                    {
                        state_37 = !Equals(IIR__LowPass__47, state_37.__p_F2m9oGsCUnPLr3nKNKXXCH) || !Equals(Rectangle_53, state_37.__p_TIVn2j0LeykOov8IM8oMNo) ? new __Qm5A9NqbWjUNecQ6tUwRzY(state_37) { __p_F2m9oGsCUnPLr3nKNKXXCH = IIR__LowPass__47, __p_TIVn2j0LeykOov8IM8oMNo = Rectangle_53 } : state_37;
                    }
                    else
                    {
                        state_37.__p_F2m9oGsCUnPLr3nKNKXXCH = IIR__LowPass__47;
                        state_37.__p_TIVn2j0LeykOov8IM8oMNo = Rectangle_53;
                    }
                    iterator_59.Update(state_37);
                    builder_60.Add(Output_57);
                    i_35++;
                }
            }
            finally
            {
                manager_58 = iterator_59.Commit();
                output_61 = builder_60.Commit();
            }
            n14.IEnumerable<n25.ILayer> Input_62 = (n14.IEnumerable<n25.ILayer>)output_61;
            var Group__Spectral__63 = this.__p_FoIwMklzNovNYCHMZD7y0Z;
            bool Debug_64 = false;
            bool Enabled_65 = true;
            Group__Spectral__63 = Group__Spectral__63.Update(Input_In: Input_62, Debug_In: Debug_64, Enabled_In: Enabled_65, Output_Out: out n25.ILayer Output_66);
            var Group_67 = this.__p_JcWErpJJSVANvGRJzZEk9x;
            n25.ILayer Input_2_68 = n28._Operations_.CreateDefault();
            bool Debug_69 = false;
            bool Enabled_70 = true;
            var builder_71 = n27.CollectionBuilders.GetBuilder(this.__pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x, 2);
            builder_71.Add(Output_66);
            builder_71.Add(Input_2_68);
            var __pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x_72 = builder_71.Commit();
            Group_67 = Group_67.Update(Input_In: __pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x_72, Debug_In: Debug_69, Enabled_In: Enabled_70, Output_Out: out n25.ILayer Output_73);
            var Renderer_74 = this.__p_ELjmj8P2WvHQOftp3Ogf15;
            string Title_75 = @"Skia";
            int Title_Bar_Interaction_Width_76 = 0;
            n22.Color4 Color_77 = __v_F2HmIXZW7aLMdaYuYkSVJS;
            bool Clear_78 = true;
            n25.CommonSpace Space_79 = __v_Er2cgO0JL1LNV3HVi67X9T;
            bool Show_Cursor_80 = true;
            bool VSync_81 = true;
            n29.ICommandList Commands_82 = default(n29.ICommandList);
            bool Enable_Keyboard_Shortcuts_83 = true;
            bool Enabled_84 = true;
            Renderer_74 = Renderer_74.Update(Input_In: Output_73, Title_In: Title_75, Title_Bar_Interaction_Width_In: Title_Bar_Interaction_Width_76, Color_In: Color_77, Clear_In: Clear_78, Space_In: Space_79, Show_Cursor_In: Show_Cursor_80, VSync_In: VSync_81, Commands_In: Commands_82, Enable_Keyboard_Shortcuts_In: Enable_Keyboard_Shortcuts_83, Enabled_In: Enabled_84, Render_Time_Out: out float Render_Time_85);
            var PickFFTFrequencyBand_86 = this.__p_SXQlp8YUB6eQYL5UDed7Dc;
            int Band_Width_87 = 1;
            float Gain_88 = 1f;
            PickFFTFrequencyBand_86 = PickFFTFrequencyBand_86.Update(FFT_In: Output_21, Frequency_In: __pad_HS7BmYmpFpwOmj9moNQJeI_7, Band_Width_In: Band_Width_87, Gain_In: Gain_88, Level_Out: out float Level_89);
            float __pad_RcllWl1QwBhMGLz5YWVVk5_90 = Level_89;
            var PickFFTBinBand_91 = this.__p_Lia0VvKd2mmOYFDhpc9RgP;
            int Band_Width_92 = 1;
            float Gain_93 = 1f;
            PickFFTBinBand_91 = PickFFTBinBand_91.Update(FFT_In: Output_21, FFT_Bin_In: __pad_JSsRw72aPFeQKiZcyOTXzV_8, Band_Width_In: Band_Width_92, Gain_In: Gain_93, Level_Out: out float Level_94);
            float __pad_SvydDtAgupDNkxozsYMuYH_95 = Level_94;
            var DriverSettings_96 = this.__p_TtkUZfEBh6eOMR3dFKpQ8W;
            n11.AudioDevice Driver_97 = __v_CocAMIyvyDePzj7GQIn2jD;
            n11.AudioSampleRate Sample_Rate_98 = __v_NKdEo8WybrdQUZzL9226lz;
            int Desired_Input_Channels_99 = 2;
            int Desired_Input_Channel_Offset_100 = 0;
            int Desired_Output_Channels_101 = 2;
            int Desired_Output_Channel_Offset_102 = 0;
            bool Show_Control_Panel_103 = false;
            bool Enabled_104 = true;
            DriverSettings_96 = DriverSettings_96.Update(Driver_In: Driver_97, Sample_Rate_In: Sample_Rate_98, Wasapi_Input_In: __pad_TLnN0XZASgPMCoRpgaBWRK_9, Desired_Input_Channels_In: Desired_Input_Channels_99, Desired_Input_Channel_Offset_In: Desired_Input_Channel_Offset_100, Desired_Output_Channels_In: Desired_Output_Channels_101, Desired_Output_Channel_Offset_In: Desired_Output_Channel_Offset_102, Show_Control_Panel_In: Show_Control_Panel_103, Enabled_In: Enabled_104, Selected_Driver_Out: out string Selected_Driver_105, Sample_Rate_Out: out int Sample_Rate_106, Buffer_Size_Out: out int Buffer_Size_107, Selected_WASAPI_Input_Device_Out: out string Selected_WASAPI_Input_Device_108, Available_Input_Channels_Out: out int Available_Input_Channels_109, Open_Input_Channels_Out: out int Open_Input_Channels_110, Available_Output_Channels_Out: out int Available_Output_Channels_111, Open_Output_Channels_Out: out int Open_Output_Channels_112, Last_Error_Out: out string Last_Error_113, Is_ASIO_Out: out bool Is_ASIO_114);
            var PickFFTFrequenciesBand_115 = this.__p_HulCyUU1ttcLPKqqUNmq3P;
            n14.IReadOnlyList<float> FFT_116 = n30._Operations_.CreateDefault<float>();
            n12.Spread<float> Frequencies_117 = __v_Bykbl214HKsMvxRATjYh8f;
            n12.Spread<int> Band_Widths_118 = __v_Gr2iGUxiu8IPdHSY5W9Ysw;
            n12.Spread<float> Gains_119 = __v_QFfAdncS3krMlc54aXu8XC;
            PickFFTFrequenciesBand_115 = PickFFTFrequenciesBand_115.Update(FFT_In: FFT_116, Frequencies_In: Frequencies_117, Band_Widths_In: Band_Widths_118, Gains_In: Gains_119, Levels_Out: out n12.Spread<float> Levels_120, Mean_Out: out float Mean_121);
            n6.AudioReactiveVisualizerApplication_P that_122 = this;
            if (this.__GetContext__().IsImmutable)
            {
                that_122 = !Equals(AudioIn_11, this.__p_R8F6ObfWTfZM4nekGdr68m) || !Equals(Meter_15, this.__p_Sve0jJ5h1yzLT3yKk4oedm) || Level_16 != this.__slot_LdA0Hmk4ryAP0wOoulOyre || Level_dBFS_17 != this.__slot_UzXtYMlf12LPj1PRN6wrQ3 || !Equals(FFT_20, this.__p_IbjV3OTaF7CQM1iXyE3nI6) || !Equals(LinearSpread_24, this.__p_Cq4GHN80dS7OKhmsKevdJR) || manager_58 != this.__loop_NeFeqFDqMN4M5KyWCqF24i || !Equals(output_61, this.__cp_FoWlg3V5PDsOwpsHc8atHq) || !Equals(Group__Spectral__63, this.__p_FoIwMklzNovNYCHMZD7y0Z) || !Equals(__pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x_72, this.__pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x) || !Equals(Group_67, this.__p_JcWErpJJSVANvGRJzZEk9x) || !Equals(Renderer_74, this.__p_ELjmj8P2WvHQOftp3Ogf15) || !Equals(PickFFTFrequencyBand_86, this.__p_SXQlp8YUB6eQYL5UDed7Dc) || Level_89 != this.__slot_RcllWl1QwBhMGLz5YWVVk5 || !Equals(PickFFTBinBand_91, this.__p_Lia0VvKd2mmOYFDhpc9RgP) || Level_94 != this.__slot_SvydDtAgupDNkxozsYMuYH || !Equals(DriverSettings_96, this.__p_TtkUZfEBh6eOMR3dFKpQ8W) || !Equals(PickFFTFrequenciesBand_115, this.__p_HulCyUU1ttcLPKqqUNmq3P) ? new n6.AudioReactiveVisualizerApplication_P(this) { __p_R8F6ObfWTfZM4nekGdr68m = AudioIn_11, __p_Sve0jJ5h1yzLT3yKk4oedm = Meter_15, __slot_LdA0Hmk4ryAP0wOoulOyre = Level_16, __slot_UzXtYMlf12LPj1PRN6wrQ3 = Level_dBFS_17, __p_IbjV3OTaF7CQM1iXyE3nI6 = FFT_20, __p_Cq4GHN80dS7OKhmsKevdJR = LinearSpread_24, __loop_NeFeqFDqMN4M5KyWCqF24i = manager_58, __cp_FoWlg3V5PDsOwpsHc8atHq = output_61, __p_FoIwMklzNovNYCHMZD7y0Z = Group__Spectral__63, __pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x = __pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x_72, __p_JcWErpJJSVANvGRJzZEk9x = Group_67, __p_ELjmj8P2WvHQOftp3Ogf15 = Renderer_74, __p_SXQlp8YUB6eQYL5UDed7Dc = PickFFTFrequencyBand_86, __slot_RcllWl1QwBhMGLz5YWVVk5 = Level_89, __p_Lia0VvKd2mmOYFDhpc9RgP = PickFFTBinBand_91, __slot_SvydDtAgupDNkxozsYMuYH = Level_94, __p_TtkUZfEBh6eOMR3dFKpQ8W = DriverSettings_96, __p_HulCyUU1ttcLPKqqUNmq3P = PickFFTFrequenciesBand_115 } : that_122;
            }
            else
            {
                this.__p_R8F6ObfWTfZM4nekGdr68m = AudioIn_11;
                this.__p_Sve0jJ5h1yzLT3yKk4oedm = Meter_15;
                this.__slot_LdA0Hmk4ryAP0wOoulOyre = Level_16;
                this.__slot_UzXtYMlf12LPj1PRN6wrQ3 = Level_dBFS_17;
                this.__p_IbjV3OTaF7CQM1iXyE3nI6 = FFT_20;
                this.__p_Cq4GHN80dS7OKhmsKevdJR = LinearSpread_24;
                this.__loop_NeFeqFDqMN4M5KyWCqF24i = manager_58;
                this.__cp_FoWlg3V5PDsOwpsHc8atHq = output_61;
                this.__p_FoIwMklzNovNYCHMZD7y0Z = Group__Spectral__63;
                this.__pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x = __pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x_72;
                this.__p_JcWErpJJSVANvGRJzZEk9x = Group_67;
                this.__p_ELjmj8P2WvHQOftp3Ogf15 = Renderer_74;
                this.__p_SXQlp8YUB6eQYL5UDed7Dc = PickFFTFrequencyBand_86;
                this.__slot_RcllWl1QwBhMGLz5YWVVk5 = Level_89;
                this.__p_Lia0VvKd2mmOYFDhpc9RgP = PickFFTBinBand_91;
                this.__slot_SvydDtAgupDNkxozsYMuYH = Level_94;
                this.__p_TtkUZfEBh6eOMR3dFKpQ8W = DriverSettings_96;
                this.__p_HulCyUU1ttcLPKqqUNmq3P = PickFFTFrequenciesBand_115;
            }
            return that_122;
        }
        [return: n4.Pin(IsState = true)]
        [n4.Smell(n5.SymbolSmell.Hidden)]
        public n6.AudioReactiveVisualizerApplication_P __Create__([n4.Pin(Name = @"Node Context", Visibility = n8.PinVisibility.Hidden)] n5.NodeContext Node_Context){
            n31.RuntimeHelpers.EnsureSufficientExecutionStack();
            var nc_0 = Node_Context;
            var AudioIn_1 = this.__p_R8F6ObfWTfZM4nekGdr68m;
            n5.NodeContext Node_Context_2 = nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"R8F6ObfWTfZM4nekGdr68m");
            AudioIn_1 = n32.AudioIn_P.Create(Node_Context: Node_Context_2);
            var DriverSettings_3 = this.__p_TtkUZfEBh6eOMR3dFKpQ8W;
            n5.NodeContext Node_Context_4 = nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"TtkUZfEBh6eOMR3dFKpQ8W");
            DriverSettings_3 = n33.DriverSettings_P.Create(Node_Context: Node_Context_4);
            var Meter_5 = this.__p_Sve0jJ5h1yzLT3yKk4oedm;
            n5.NodeContext Node_Context_6 = nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"Sve0jJ5h1yzLT3yKk4oedm");
            Meter_5 = n34.Meter_P.Create(Node_Context: Node_Context_6);
            var FFT_7 = this.__p_IbjV3OTaF7CQM1iXyE3nI6;
            n5.NodeContext Node_Context_8 = nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"IbjV3OTaF7CQM1iXyE3nI6");
            FFT_7 = n34.FFT_P.Create(Node_Context: Node_Context_8);
            var Renderer_9 = this.__p_ELjmj8P2WvHQOftp3Ogf15;
            n5.NodeContext Node_Context_10 = nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"ELjmj8P2WvHQOftp3Ogf15");
            n35.Rectangle Bounds_11 = n10.CompilationHelper.Deserialize<n35.Rectangle>(@"1044, 56, 600, 385", false, @"RckyMa2RP3mPQ0ttObPClA", @"AU04T2N6hgAM1xHo6O2RyD");
            bool Save_Bounds_12 = true;
            bool Bound_to_Document_13 = false;
            bool Dialog_If_Document_Changed_14 = false;
            n37.IChannel<bool> Always_On_Top_15 = n10.CompilationHelper.CopyAndReturn<n37.IChannel<bool>, bool>(__v_GSBeukiHGurPne2s3dt5oe, n10.CompilationHelper.CreateMonadicValue<n37.IChannel<bool>, bool>(nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"GSBeukiHGurPne2s3dt5oe")));
            n37.IChannel<bool> Extend_Into_Title_Bar_16 = n10.CompilationHelper.CopyAndReturn<n37.IChannel<bool>, bool>(__v_FjkwamjirLMOO4rgCh4X7D, n10.CompilationHelper.CreateMonadicValue<n37.IChannel<bool>, bool>(nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"FjkwamjirLMOO4rgCh4X7D")));
            Renderer_9 = n24.Renderer_P.Create(Node_Context: Node_Context_10, Bounds_In: Bounds_11, Save_Bounds_In: Save_Bounds_12, Bound_to_Document_In: Bound_to_Document_13, Dialog_If_Document_Changed_In: Dialog_If_Document_Changed_14, Always_On_Top_In: Always_On_Top_15, Extend_Into_Title_Bar_In: Extend_Into_Title_Bar_16);
            var Group_17 = this.__p_JcWErpJJSVANvGRJzZEk9x;
            n5.NodeContext Node_Context_18 = nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"JcWErpJJSVANvGRJzZEk9x");
            Group_17 = n24.Group_P.Create(Node_Context: Node_Context_18);
            var Group__Spectral__19 = this.__p_FoIwMklzNovNYCHMZD7y0Z;
            n5.NodeContext Node_Context_20 = nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"FoIwMklzNovNYCHMZD7y0Z");
            Group__Spectral__19 = n24.Group_Spectral_P.Create(Node_Context: Node_Context_20);
            var LinearSpread_21 = this.__p_Cq4GHN80dS7OKhmsKevdJR;
            n5.NodeContext Node_Context_22 = nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"Cq4GHN80dS7OKhmsKevdJR");
            LinearSpread_21 = n13.LinearSpread_P.Create(Node_Context: Node_Context_22);
            var PickFFTFrequencyBand_23 = this.__p_SXQlp8YUB6eQYL5UDed7Dc;
            n5.NodeContext Node_Context_24 = nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"SXQlp8YUB6eQYL5UDed7Dc");
            PickFFTFrequencyBand_23 = n34.PickFFTFrequencyBand_P.Create(Node_Context: Node_Context_24);
            var PickFFTFrequenciesBand_25 = this.__p_HulCyUU1ttcLPKqqUNmq3P;
            n5.NodeContext Node_Context_26 = nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"HulCyUU1ttcLPKqqUNmq3P");
            PickFFTFrequenciesBand_25 = n34.PickFFTFrequenciesBand_P.Create(Node_Context: Node_Context_26);
            var PickFFTBinBand_27 = this.__p_Lia0VvKd2mmOYFDhpc9RgP;
            n5.NodeContext Node_Context_28 = nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"Lia0VvKd2mmOYFDhpc9RgP");
            PickFFTBinBand_27 = n34.PickFFTBinBand_P.Create(Node_Context: Node_Context_28);
            n6.AudioReactiveVisualizerApplication_P that_29 = this;
            this.__pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x = default(n12.Spread<n25.ILayer>);
            this.__monadicValue_GSBeukiHGurPne2s3dt5oe = n10.CompilationHelper.CreateMonadicValue<n37.IChannel<bool>, bool>(nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"GSBeukiHGurPne2s3dt5oe"));
            this.__monadicValue_FjkwamjirLMOO4rgCh4X7D = n10.CompilationHelper.CreateMonadicValue<n37.IChannel<bool>, bool>(nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"FjkwamjirLMOO4rgCh4X7D"));
            this.__p_R8F6ObfWTfZM4nekGdr68m = AudioIn_1;
            this.__p_TtkUZfEBh6eOMR3dFKpQ8W = DriverSettings_3;
            this.__p_Sve0jJ5h1yzLT3yKk4oedm = Meter_5;
            this.__p_IbjV3OTaF7CQM1iXyE3nI6 = FFT_7;
            this.__p_ELjmj8P2WvHQOftp3Ogf15 = Renderer_9;
            this.__p_JcWErpJJSVANvGRJzZEk9x = Group_17;
            this.__p_FoIwMklzNovNYCHMZD7y0Z = Group__Spectral__19;
            this.__p_Cq4GHN80dS7OKhmsKevdJR = LinearSpread_21;
            this.__p_SXQlp8YUB6eQYL5UDed7Dc = PickFFTFrequencyBand_23;
            this.__p_HulCyUU1ttcLPKqqUNmq3P = PickFFTFrequenciesBand_25;
            this.__p_Lia0VvKd2mmOYFDhpc9RgP = PickFFTBinBand_27;
            this.__slot_LdA0Hmk4ryAP0wOoulOyre = 0f;
            this.__slot_UzXtYMlf12LPj1PRN6wrQ3 = 0f;
            this.__slot_RcllWl1QwBhMGLz5YWVVk5 = 0f;
            this.__slot_SvydDtAgupDNkxozsYMuYH = 0f;
            this.__loop_NeFeqFDqMN4M5KyWCqF24i = default(n26.LifetimeManager);
            this.__cp_FoWlg3V5PDsOwpsHc8atHq = n13._Operations_.CreateDefault<n25.ILayer>();
            return that_29;
        }
        [return: n4.Pin(IsState = true)]
        [n4.Smell(n5.SymbolSmell.Hidden)]
        public n6.AudioReactiveVisualizerApplication_P __CreateDefault__(){
            var nc_0 = n5.NodeContext.CurrentRoot;
            n6.AudioReactiveVisualizerApplication_P that_1 = this;
            this.__pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x = default(n12.Spread<n25.ILayer>);
            this.__monadicValue_GSBeukiHGurPne2s3dt5oe = n10.CompilationHelper.CreateMonadicValue<n37.IChannel<bool>, bool>(nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"GSBeukiHGurPne2s3dt5oe"));
            this.__monadicValue_FjkwamjirLMOO4rgCh4X7D = n10.CompilationHelper.CreateMonadicValue<n37.IChannel<bool>, bool>(nc_0.CreateSubContext(@"RckyMa2RP3mPQ0ttObPClA", @"FjkwamjirLMOO4rgCh4X7D"));
            this.__slot_LdA0Hmk4ryAP0wOoulOyre = 0f;
            this.__slot_UzXtYMlf12LPj1PRN6wrQ3 = 0f;
            this.__slot_RcllWl1QwBhMGLz5YWVVk5 = 0f;
            this.__slot_SvydDtAgupDNkxozsYMuYH = 0f;
            this.__p_R8F6ObfWTfZM4nekGdr68m = n32.AudioIn_P.CreateDefault();
            this.__p_Sve0jJ5h1yzLT3yKk4oedm = n34.Meter_P.CreateDefault();
            this.__p_IbjV3OTaF7CQM1iXyE3nI6 = n34.FFT_P.CreateDefault();
            this.__p_Cq4GHN80dS7OKhmsKevdJR = n13.LinearSpread_P.CreateDefault();
            this.__loop_NeFeqFDqMN4M5KyWCqF24i = default(n26.LifetimeManager);
            this.__cp_FoWlg3V5PDsOwpsHc8atHq = n13._Operations_.CreateDefault<n25.ILayer>();
            this.__p_FoIwMklzNovNYCHMZD7y0Z = n24.Group_Spectral_P.CreateDefault();
            this.__p_JcWErpJJSVANvGRJzZEk9x = n24.Group_P.CreateDefault();
            this.__p_ELjmj8P2WvHQOftp3Ogf15 = n24.Renderer_P.CreateDefault();
            this.__p_SXQlp8YUB6eQYL5UDed7Dc = n34.PickFFTFrequencyBand_P.CreateDefault();
            this.__p_Lia0VvKd2mmOYFDhpc9RgP = n34.PickFFTBinBand_P.CreateDefault();
            this.__p_TtkUZfEBh6eOMR3dFKpQ8W = n33.DriverSettings_P.CreateDefault();
            this.__p_HulCyUU1ttcLPKqqUNmq3P = n34.PickFFTFrequenciesBand_P.CreateDefault();
            return that_1;
        }
        public void Dispose(){
            try
            {
                return;
            }
            finally
            {
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_Lia0VvKd2mmOYFDhpc9RgP);
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_HulCyUU1ttcLPKqqUNmq3P);
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_SXQlp8YUB6eQYL5UDed7Dc);
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_Cq4GHN80dS7OKhmsKevdJR);
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_FoIwMklzNovNYCHMZD7y0Z);
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_JcWErpJJSVANvGRJzZEk9x);
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_ELjmj8P2WvHQOftp3Ogf15);
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_IbjV3OTaF7CQM1iXyE3nI6);
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_Sve0jJ5h1yzLT3yKk4oedm);
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_TtkUZfEBh6eOMR3dFKpQ8W);
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_R8F6ObfWTfZM4nekGdr68m);
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__monadicValue_FjkwamjirLMOO4rgCh4X7D);
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__monadicValue_GSBeukiHGurPne2s3dt5oe);
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__loop_NeFeqFDqMN4M5KyWCqF24i);
            }
        }
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"TLnN0XZASgPMCoRpgaBWRK", IsAutoGenerated = true)]
        public static n11.WasapiInputDevice __slot_TLnN0XZASgPMCoRpgaBWRK = n10.CompilationHelper.Deserialize<n11.WasapiInputDevice>(@"Loopback: Current System Device", false, @"RckyMa2RP3mPQ0ttObPClA", @"TLnN0XZASgPMCoRpgaBWRK");
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"A4Qg0X6Q9J3LkG7mN2DpYx", IsAutoGenerated = true)]
        public static string __slot_A4Qg0X6Q9J3LkG7mN2DpYx = @"Desktop audio source: WASAPI loopback on the current system device";
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"LdA0Hmk4ryAP0wOoulOyre", IsAutoGenerated = true)]
        public float __slot_LdA0Hmk4ryAP0wOoulOyre;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"UzXtYMlf12LPj1PRN6wrQ3", IsAutoGenerated = true)]
        public float __slot_UzXtYMlf12LPj1PRN6wrQ3;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"IFjJAgWa47QMmVSZK89Ad6", IsAutoGenerated = true)]
        public static float __slot_IFjJAgWa47QMmVSZK89Ad6 = 3f;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"HeQu8dMBZcHPTZQyNkk7nJ", IsAutoGenerated = true)]
        public static float __slot_HeQu8dMBZcHPTZQyNkk7nJ = 1f;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"EVzxxwlQLndMP9grFBHoLE", IsAutoGenerated = true)]
        public static int __slot_EVzxxwlQLndMP9grFBHoLE = 0;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"IY88FhCpk0tLFU5YWe2Vtx", IsAutoGenerated = true)]
        public static n11.WindowFunction __slot_IY88FhCpk0tLFU5YWe2Vtx = n10.CompilationHelper.Deserialize<n11.WindowFunction>(@"Hann", false, @"RckyMa2RP3mPQ0ttObPClA", @"IY88FhCpk0tLFU5YWe2Vtx");
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"KWb570t0jLgQLf6b6RPOao", IsAutoGenerated = true)]
        public static float __slot_KWb570t0jLgQLf6b6RPOao = 72f;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"H573wQc495MLkDXXu6U47g", IsAutoGenerated = true)]
        public static float __slot_H573wQc495MLkDXXu6U47g = 0.5f;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"LjdFqnu69uCQGN0qBYcJuT", IsAutoGenerated = true)]
        public static n11.FFTBinCountEnum __slot_LjdFqnu69uCQGN0qBYcJuT = n10.CompilationHelper.Deserialize<n11.FFTBinCountEnum>(@"256", false, @"RckyMa2RP3mPQ0ttObPClA", @"LjdFqnu69uCQGN0qBYcJuT");
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"HS7BmYmpFpwOmj9moNQJeI", IsAutoGenerated = true)]
        public static float __slot_HS7BmYmpFpwOmj9moNQJeI = 440f;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"RcllWl1QwBhMGLz5YWVVk5", IsAutoGenerated = true)]
        public float __slot_RcllWl1QwBhMGLz5YWVVk5;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"JSsRw72aPFeQKiZcyOTXzV", IsAutoGenerated = true)]
        public static int __slot_JSsRw72aPFeQKiZcyOTXzV = 64;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"SvydDtAgupDNkxozsYMuYH", IsAutoGenerated = true)]
        public float __slot_SvydDtAgupDNkxozsYMuYH;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"R8F6ObfWTfZM4nekGdr68m", IsManaged = true, IsAutoGenerated = true)]
        public n32.AudioIn_P __p_R8F6ObfWTfZM4nekGdr68m;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"Sve0jJ5h1yzLT3yKk4oedm", IsManaged = true, IsAutoGenerated = true)]
        public n34.Meter_P __p_Sve0jJ5h1yzLT3yKk4oedm;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"IbjV3OTaF7CQM1iXyE3nI6", IsManaged = true, IsAutoGenerated = true)]
        public n34.FFT_P __p_IbjV3OTaF7CQM1iXyE3nI6;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"Cq4GHN80dS7OKhmsKevdJR", IsManaged = true, IsAutoGenerated = true)]
        public n13.LinearSpread_P __p_Cq4GHN80dS7OKhmsKevdJR;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"HWIjBaOclZoPePvjn6YjxN", IsAutoGenerated = true)]
        public static n23.RectangleAnchor __v_HWIjBaOclZoPePvjn6YjxN = n10.CompilationHelper.Deserialize<n23.RectangleAnchor>(@"BottomCenter", false, @"RckyMa2RP3mPQ0ttObPClA", @"HWIjBaOclZoPePvjn6YjxN");
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"MRdax2OeudcPV1x6yejp11", IsAutoGenerated = true)]
        public static n24.SkiaPaint_R __v_MRdax2OeudcPV1x6yejp11 = n24.SkiaPaint_R.CreateDefault();
        
        [n1.Element(IsManaged = true, IsAutoGenerated = true)]
        public n26.LifetimeManager __loop_NeFeqFDqMN4M5KyWCqF24i;
        
        [n1.Element(IsAutoGenerated = true)]
        public n12.Spread<n25.ILayer> __cp_FoWlg3V5PDsOwpsHc8atHq;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"FoIwMklzNovNYCHMZD7y0Z", IsManaged = true, IsAutoGenerated = true)]
        [n3.Name(@"Group (Spectral)")]
        public n24.Group_Spectral_P __p_FoIwMklzNovNYCHMZD7y0Z;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"JcWErpJJSVANvGRJzZEk9x", IsManaged = true, IsAutoGenerated = true)]
        public n24.Group_P __p_JcWErpJJSVANvGRJzZEk9x;
        
        [n1.Element(IsAutoGenerated = true)]
        public n12.Spread<n25.ILayer> __pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"ELjmj8P2WvHQOftp3Ogf15", IsManaged = true, IsAutoGenerated = true)]
        public n24.Renderer_P __p_ELjmj8P2WvHQOftp3Ogf15;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"F2HmIXZW7aLMdaYuYkSVJS", IsAutoGenerated = true)]
        public static n22.Color4 __v_F2HmIXZW7aLMdaYuYkSVJS = n10.CompilationHelper.Deserialize<n22.Color4>(@"0, 0, 0, 1", false, @"RckyMa2RP3mPQ0ttObPClA", @"F2HmIXZW7aLMdaYuYkSVJS");
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"Er2cgO0JL1LNV3HVi67X9T", IsAutoGenerated = true)]
        public static n25.CommonSpace __v_Er2cgO0JL1LNV3HVi67X9T = n10.CompilationHelper.Deserialize<n25.CommonSpace>(@"Normalized", false, @"RckyMa2RP3mPQ0ttObPClA", @"Er2cgO0JL1LNV3HVi67X9T");
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"SXQlp8YUB6eQYL5UDed7Dc", IsManaged = true, IsAutoGenerated = true)]
        public n34.PickFFTFrequencyBand_P __p_SXQlp8YUB6eQYL5UDed7Dc;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"Lia0VvKd2mmOYFDhpc9RgP", IsManaged = true, IsAutoGenerated = true)]
        public n34.PickFFTBinBand_P __p_Lia0VvKd2mmOYFDhpc9RgP;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"TtkUZfEBh6eOMR3dFKpQ8W", IsManaged = true, IsAutoGenerated = true)]
        public n33.DriverSettings_P __p_TtkUZfEBh6eOMR3dFKpQ8W;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"CocAMIyvyDePzj7GQIn2jD", IsAutoGenerated = true)]
        public static n11.AudioDevice __v_CocAMIyvyDePzj7GQIn2jD = n10.CompilationHelper.Deserialize<n11.AudioDevice>(@"WASAPI: Current System Device", false, @"RckyMa2RP3mPQ0ttObPClA", @"CocAMIyvyDePzj7GQIn2jD");
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"NKdEo8WybrdQUZzL9226lz", IsAutoGenerated = true)]
        [n3.Name(@"Sample Rate")]
        public static n11.AudioSampleRate __v_NKdEo8WybrdQUZzL9226lz = n10.CompilationHelper.Deserialize<n11.AudioSampleRate>(@"192000", false, @"RckyMa2RP3mPQ0ttObPClA", @"NKdEo8WybrdQUZzL9226lz");
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"HulCyUU1ttcLPKqqUNmq3P", IsManaged = true, IsAutoGenerated = true)]
        public n34.PickFFTFrequenciesBand_P __p_HulCyUU1ttcLPKqqUNmq3P;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"Bykbl214HKsMvxRATjYh8f", IsAutoGenerated = true)]
        public static n12.Spread<float> __v_Bykbl214HKsMvxRATjYh8f = n10.CompilationHelper.Deserialize<n12.Spread<float>>(@"440", false, @"RckyMa2RP3mPQ0ttObPClA", @"Bykbl214HKsMvxRATjYh8f");
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"Gr2iGUxiu8IPdHSY5W9Ysw", IsAutoGenerated = true)]
        [n3.Name(@"Band Widths")]
        public static n12.Spread<int> __v_Gr2iGUxiu8IPdHSY5W9Ysw = n10.CompilationHelper.Deserialize<n12.Spread<int>>(@"1", false, @"RckyMa2RP3mPQ0ttObPClA", @"Gr2iGUxiu8IPdHSY5W9Ysw");
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"QFfAdncS3krMlc54aXu8XC", IsAutoGenerated = true)]
        public static n12.Spread<float> __v_QFfAdncS3krMlc54aXu8XC = n10.CompilationHelper.Deserialize<n12.Spread<float>>(@"1", false, @"RckyMa2RP3mPQ0ttObPClA", @"QFfAdncS3krMlc54aXu8XC");
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"GSBeukiHGurPne2s3dt5oe", IsAutoGenerated = true)]
        [n3.Name(@"Always On Top")]
        public static n37.IChannel<bool> __v_GSBeukiHGurPne2s3dt5oe = n36._Operations_.CreateDefault<bool>();
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"GSBeukiHGurPne2s3dt5oe", IsManaged = true, IsAutoGenerated = true)]
        [n3.Name(@"Always On Top")]
        public n37.IChannel<bool> __monadicValue_GSBeukiHGurPne2s3dt5oe;
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"FjkwamjirLMOO4rgCh4X7D", IsAutoGenerated = true)]
        [n3.Name(@"Extend Into Title Bar")]
        public static n37.IChannel<bool> __v_FjkwamjirLMOO4rgCh4X7D = n36._Operations_.CreateDefault<bool>();
        
        [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"FjkwamjirLMOO4rgCh4X7D", IsManaged = true, IsAutoGenerated = true)]
        [n3.Name(@"Extend Into Title Bar")]
        public n37.IChannel<bool> __monadicValue_FjkwamjirLMOO4rgCh4X7D;
        
        [n2.Serializable]
        sealed class __Qm5A9NqbWjUNecQ6tUwRzY : n2.IDisposable
        {
            [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"TIVn2j0LeykOov8IM8oMNo", IsManaged = true, IsAutoGenerated = true)]
            public n18.Rectangle_P __p_TIVn2j0LeykOov8IM8oMNo;
            
            [n1.Element(DocumentId = @"RckyMa2RP3mPQ0ttObPClA", PersistentId = @"F2m9oGsCUnPLr3nKNKXXCH", IsManaged = true, IsAutoGenerated = true)]
            [n3.Name(@"IIR (LowPass)")]
            public n19.IIR_LowPass_R<float> __p_F2m9oGsCUnPLr3nKNKXXCH;
            
            public __Qm5A9NqbWjUNecQ6tUwRzY()
            {
            }
            public __Qm5A9NqbWjUNecQ6tUwRzY(__Qm5A9NqbWjUNecQ6tUwRzY other)
            {
                this.__p_TIVn2j0LeykOov8IM8oMNo = other.__p_TIVn2j0LeykOov8IM8oMNo;
                this.__p_F2m9oGsCUnPLr3nKNKXXCH = other.__p_F2m9oGsCUnPLr3nKNKXXCH;
            }
            void n2.IDisposable.Dispose(){
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_TIVn2j0LeykOov8IM8oMNo);
                n10.CompilationHelper.ShieldedDisposeForManagedFields(this.__p_F2m9oGsCUnPLr3nKNKXXCH);
            }
        }
        void n2.IDisposable.Dispose(){
            using var __current_app_host = __GetAppHost__().MakeCurrentIfNone();
            Dispose();
        }
        public AudioReactiveVisualizerApplication_P() : base()
        {
        }
        public AudioReactiveVisualizerApplication_P(n5.NodeContext context, uint identity) : base(context, identity)
        {
        }
        public AudioReactiveVisualizerApplication_P(AudioReactiveVisualizerApplication_P other) : base(other)
        {
            this.__slot_LdA0Hmk4ryAP0wOoulOyre = other.__slot_LdA0Hmk4ryAP0wOoulOyre;
            this.__slot_UzXtYMlf12LPj1PRN6wrQ3 = other.__slot_UzXtYMlf12LPj1PRN6wrQ3;
            this.__slot_RcllWl1QwBhMGLz5YWVVk5 = other.__slot_RcllWl1QwBhMGLz5YWVVk5;
            this.__slot_SvydDtAgupDNkxozsYMuYH = other.__slot_SvydDtAgupDNkxozsYMuYH;
            this.__p_R8F6ObfWTfZM4nekGdr68m = other.__p_R8F6ObfWTfZM4nekGdr68m;
            this.__p_Sve0jJ5h1yzLT3yKk4oedm = other.__p_Sve0jJ5h1yzLT3yKk4oedm;
            this.__p_IbjV3OTaF7CQM1iXyE3nI6 = other.__p_IbjV3OTaF7CQM1iXyE3nI6;
            this.__p_Cq4GHN80dS7OKhmsKevdJR = other.__p_Cq4GHN80dS7OKhmsKevdJR;
            this.__loop_NeFeqFDqMN4M5KyWCqF24i = other.__loop_NeFeqFDqMN4M5KyWCqF24i;
            this.__cp_FoWlg3V5PDsOwpsHc8atHq = other.__cp_FoWlg3V5PDsOwpsHc8atHq;
            this.__p_FoIwMklzNovNYCHMZD7y0Z = other.__p_FoIwMklzNovNYCHMZD7y0Z;
            this.__p_JcWErpJJSVANvGRJzZEk9x = other.__p_JcWErpJJSVANvGRJzZEk9x;
            this.__pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x = other.__pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x;
            this.__p_ELjmj8P2WvHQOftp3Ogf15 = other.__p_ELjmj8P2WvHQOftp3Ogf15;
            this.__p_SXQlp8YUB6eQYL5UDed7Dc = other.__p_SXQlp8YUB6eQYL5UDed7Dc;
            this.__p_Lia0VvKd2mmOYFDhpc9RgP = other.__p_Lia0VvKd2mmOYFDhpc9RgP;
            this.__p_TtkUZfEBh6eOMR3dFKpQ8W = other.__p_TtkUZfEBh6eOMR3dFKpQ8W;
            this.__p_HulCyUU1ttcLPKqqUNmq3P = other.__p_HulCyUU1ttcLPKqqUNmq3P;
            this.__monadicValue_GSBeukiHGurPne2s3dt5oe = other.__monadicValue_GSBeukiHGurPne2s3dt5oe;
            this.__monadicValue_FjkwamjirLMOO4rgCh4X7D = other.__monadicValue_FjkwamjirLMOO4rgCh4X7D;
        }
        protected override n5.IVLObject __With__(n14.IReadOnlyDictionary<string, n2.Object> values){
            return __WITH__(n10.CompilationHelper.GetValueOrExisting(values, @"__slot_LdA0Hmk4ryAP0wOoulOyre", in this.__slot_LdA0Hmk4ryAP0wOoulOyre), n10.CompilationHelper.GetValueOrExisting(values, @"__slot_UzXtYMlf12LPj1PRN6wrQ3", in this.__slot_UzXtYMlf12LPj1PRN6wrQ3), n10.CompilationHelper.GetValueOrExisting(values, @"__slot_RcllWl1QwBhMGLz5YWVVk5", in this.__slot_RcllWl1QwBhMGLz5YWVVk5), n10.CompilationHelper.GetValueOrExisting(values, @"__slot_SvydDtAgupDNkxozsYMuYH", in this.__slot_SvydDtAgupDNkxozsYMuYH), n10.CompilationHelper.GetValueOrExisting(values, @"__p_R8F6ObfWTfZM4nekGdr68m", in this.__p_R8F6ObfWTfZM4nekGdr68m), n10.CompilationHelper.GetValueOrExisting(values, @"__p_Sve0jJ5h1yzLT3yKk4oedm", in this.__p_Sve0jJ5h1yzLT3yKk4oedm), n10.CompilationHelper.GetValueOrExisting(values, @"__p_IbjV3OTaF7CQM1iXyE3nI6", in this.__p_IbjV3OTaF7CQM1iXyE3nI6), n10.CompilationHelper.GetValueOrExisting(values, @"__p_Cq4GHN80dS7OKhmsKevdJR", in this.__p_Cq4GHN80dS7OKhmsKevdJR), n10.CompilationHelper.GetValueOrExisting(values, @"__loop_NeFeqFDqMN4M5KyWCqF24i", in this.__loop_NeFeqFDqMN4M5KyWCqF24i), n10.CompilationHelper.GetValueOrExisting(values, @"__cp_FoWlg3V5PDsOwpsHc8atHq", in this.__cp_FoWlg3V5PDsOwpsHc8atHq), n10.CompilationHelper.GetValueOrExisting(values, @"__p_FoIwMklzNovNYCHMZD7y0Z", in this.__p_FoIwMklzNovNYCHMZD7y0Z), n10.CompilationHelper.GetValueOrExisting(values, @"__p_JcWErpJJSVANvGRJzZEk9x", in this.__p_JcWErpJJSVANvGRJzZEk9x), n10.CompilationHelper.GetValueOrExisting(values, @"__pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x", in this.__pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x), n10.CompilationHelper.GetValueOrExisting(values, @"__p_ELjmj8P2WvHQOftp3Ogf15", in this.__p_ELjmj8P2WvHQOftp3Ogf15), n10.CompilationHelper.GetValueOrExisting(values, @"__p_SXQlp8YUB6eQYL5UDed7Dc", in this.__p_SXQlp8YUB6eQYL5UDed7Dc), n10.CompilationHelper.GetValueOrExisting(values, @"__p_Lia0VvKd2mmOYFDhpc9RgP", in this.__p_Lia0VvKd2mmOYFDhpc9RgP), n10.CompilationHelper.GetValueOrExisting(values, @"__p_TtkUZfEBh6eOMR3dFKpQ8W", in this.__p_TtkUZfEBh6eOMR3dFKpQ8W), n10.CompilationHelper.GetValueOrExisting(values, @"__p_HulCyUU1ttcLPKqqUNmq3P", in this.__p_HulCyUU1ttcLPKqqUNmq3P), n10.CompilationHelper.GetValueOrExisting(values, @"__monadicValue_GSBeukiHGurPne2s3dt5oe", in this.__monadicValue_GSBeukiHGurPne2s3dt5oe), n10.CompilationHelper.GetValueOrExisting(values, @"__monadicValue_FjkwamjirLMOO4rgCh4X7D", in this.__monadicValue_FjkwamjirLMOO4rgCh4X7D));
        }
        internal AudioReactiveVisualizerApplication_P __WITH__(float __slot_LdA0Hmk4ryAP0wOoulOyre, float __slot_UzXtYMlf12LPj1PRN6wrQ3, float __slot_RcllWl1QwBhMGLz5YWVVk5, float __slot_SvydDtAgupDNkxozsYMuYH, n32.AudioIn_P __p_R8F6ObfWTfZM4nekGdr68m, n34.Meter_P __p_Sve0jJ5h1yzLT3yKk4oedm, n34.FFT_P __p_IbjV3OTaF7CQM1iXyE3nI6, n13.LinearSpread_P __p_Cq4GHN80dS7OKhmsKevdJR, n26.LifetimeManager __loop_NeFeqFDqMN4M5KyWCqF24i, n12.Spread<n25.ILayer> __cp_FoWlg3V5PDsOwpsHc8atHq, n24.Group_Spectral_P __p_FoIwMklzNovNYCHMZD7y0Z, n24.Group_P __p_JcWErpJJSVANvGRJzZEk9x, n12.Spread<n25.ILayer> __pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x, n24.Renderer_P __p_ELjmj8P2WvHQOftp3Ogf15, n34.PickFFTFrequencyBand_P __p_SXQlp8YUB6eQYL5UDed7Dc, n34.PickFFTBinBand_P __p_Lia0VvKd2mmOYFDhpc9RgP, n33.DriverSettings_P __p_TtkUZfEBh6eOMR3dFKpQ8W, n34.PickFFTFrequenciesBand_P __p_HulCyUU1ttcLPKqqUNmq3P, n37.IChannel<bool> __monadicValue_GSBeukiHGurPne2s3dt5oe, n37.IChannel<bool> __monadicValue_FjkwamjirLMOO4rgCh4X7D){
            n6.AudioReactiveVisualizerApplication_P that_0 = this;
            if (this.__GetContext__().IsImmutable)
            {
                that_0 = __slot_LdA0Hmk4ryAP0wOoulOyre != this.__slot_LdA0Hmk4ryAP0wOoulOyre || __slot_UzXtYMlf12LPj1PRN6wrQ3 != this.__slot_UzXtYMlf12LPj1PRN6wrQ3 || __slot_RcllWl1QwBhMGLz5YWVVk5 != this.__slot_RcllWl1QwBhMGLz5YWVVk5 || __slot_SvydDtAgupDNkxozsYMuYH != this.__slot_SvydDtAgupDNkxozsYMuYH || !Equals(__p_R8F6ObfWTfZM4nekGdr68m, this.__p_R8F6ObfWTfZM4nekGdr68m) || !Equals(__p_Sve0jJ5h1yzLT3yKk4oedm, this.__p_Sve0jJ5h1yzLT3yKk4oedm) || !Equals(__p_IbjV3OTaF7CQM1iXyE3nI6, this.__p_IbjV3OTaF7CQM1iXyE3nI6) || !Equals(__p_Cq4GHN80dS7OKhmsKevdJR, this.__p_Cq4GHN80dS7OKhmsKevdJR) || __loop_NeFeqFDqMN4M5KyWCqF24i != this.__loop_NeFeqFDqMN4M5KyWCqF24i || !Equals(__cp_FoWlg3V5PDsOwpsHc8atHq, this.__cp_FoWlg3V5PDsOwpsHc8atHq) || !Equals(__p_FoIwMklzNovNYCHMZD7y0Z, this.__p_FoIwMklzNovNYCHMZD7y0Z) || !Equals(__p_JcWErpJJSVANvGRJzZEk9x, this.__p_JcWErpJJSVANvGRJzZEk9x) || !Equals(__pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x, this.__pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x) || !Equals(__p_ELjmj8P2WvHQOftp3Ogf15, this.__p_ELjmj8P2WvHQOftp3Ogf15) || !Equals(__p_SXQlp8YUB6eQYL5UDed7Dc, this.__p_SXQlp8YUB6eQYL5UDed7Dc) || !Equals(__p_Lia0VvKd2mmOYFDhpc9RgP, this.__p_Lia0VvKd2mmOYFDhpc9RgP) || !Equals(__p_TtkUZfEBh6eOMR3dFKpQ8W, this.__p_TtkUZfEBh6eOMR3dFKpQ8W) || !Equals(__p_HulCyUU1ttcLPKqqUNmq3P, this.__p_HulCyUU1ttcLPKqqUNmq3P) || !Equals(__monadicValue_GSBeukiHGurPne2s3dt5oe, this.__monadicValue_GSBeukiHGurPne2s3dt5oe) || !Equals(__monadicValue_FjkwamjirLMOO4rgCh4X7D, this.__monadicValue_FjkwamjirLMOO4rgCh4X7D) ? new n6.AudioReactiveVisualizerApplication_P(this) { __slot_LdA0Hmk4ryAP0wOoulOyre = __slot_LdA0Hmk4ryAP0wOoulOyre, __slot_UzXtYMlf12LPj1PRN6wrQ3 = __slot_UzXtYMlf12LPj1PRN6wrQ3, __slot_RcllWl1QwBhMGLz5YWVVk5 = __slot_RcllWl1QwBhMGLz5YWVVk5, __slot_SvydDtAgupDNkxozsYMuYH = __slot_SvydDtAgupDNkxozsYMuYH, __p_R8F6ObfWTfZM4nekGdr68m = __p_R8F6ObfWTfZM4nekGdr68m, __p_Sve0jJ5h1yzLT3yKk4oedm = __p_Sve0jJ5h1yzLT3yKk4oedm, __p_IbjV3OTaF7CQM1iXyE3nI6 = __p_IbjV3OTaF7CQM1iXyE3nI6, __p_Cq4GHN80dS7OKhmsKevdJR = __p_Cq4GHN80dS7OKhmsKevdJR, __loop_NeFeqFDqMN4M5KyWCqF24i = __loop_NeFeqFDqMN4M5KyWCqF24i, __cp_FoWlg3V5PDsOwpsHc8atHq = __cp_FoWlg3V5PDsOwpsHc8atHq, __p_FoIwMklzNovNYCHMZD7y0Z = __p_FoIwMklzNovNYCHMZD7y0Z, __p_JcWErpJJSVANvGRJzZEk9x = __p_JcWErpJJSVANvGRJzZEk9x, __pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x = __pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x, __p_ELjmj8P2WvHQOftp3Ogf15 = __p_ELjmj8P2WvHQOftp3Ogf15, __p_SXQlp8YUB6eQYL5UDed7Dc = __p_SXQlp8YUB6eQYL5UDed7Dc, __p_Lia0VvKd2mmOYFDhpc9RgP = __p_Lia0VvKd2mmOYFDhpc9RgP, __p_TtkUZfEBh6eOMR3dFKpQ8W = __p_TtkUZfEBh6eOMR3dFKpQ8W, __p_HulCyUU1ttcLPKqqUNmq3P = __p_HulCyUU1ttcLPKqqUNmq3P, __monadicValue_GSBeukiHGurPne2s3dt5oe = __monadicValue_GSBeukiHGurPne2s3dt5oe, __monadicValue_FjkwamjirLMOO4rgCh4X7D = __monadicValue_FjkwamjirLMOO4rgCh4X7D } : that_0;
            }
            else
            {
                this.__slot_LdA0Hmk4ryAP0wOoulOyre = __slot_LdA0Hmk4ryAP0wOoulOyre;
                this.__slot_UzXtYMlf12LPj1PRN6wrQ3 = __slot_UzXtYMlf12LPj1PRN6wrQ3;
                this.__slot_RcllWl1QwBhMGLz5YWVVk5 = __slot_RcllWl1QwBhMGLz5YWVVk5;
                this.__slot_SvydDtAgupDNkxozsYMuYH = __slot_SvydDtAgupDNkxozsYMuYH;
                this.__p_R8F6ObfWTfZM4nekGdr68m = __p_R8F6ObfWTfZM4nekGdr68m;
                this.__p_Sve0jJ5h1yzLT3yKk4oedm = __p_Sve0jJ5h1yzLT3yKk4oedm;
                this.__p_IbjV3OTaF7CQM1iXyE3nI6 = __p_IbjV3OTaF7CQM1iXyE3nI6;
                this.__p_Cq4GHN80dS7OKhmsKevdJR = __p_Cq4GHN80dS7OKhmsKevdJR;
                this.__loop_NeFeqFDqMN4M5KyWCqF24i = __loop_NeFeqFDqMN4M5KyWCqF24i;
                this.__cp_FoWlg3V5PDsOwpsHc8atHq = __cp_FoWlg3V5PDsOwpsHc8atHq;
                this.__p_FoIwMklzNovNYCHMZD7y0Z = __p_FoIwMklzNovNYCHMZD7y0Z;
                this.__p_JcWErpJJSVANvGRJzZEk9x = __p_JcWErpJJSVANvGRJzZEk9x;
                this.__pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x = __pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x;
                this.__p_ELjmj8P2WvHQOftp3Ogf15 = __p_ELjmj8P2WvHQOftp3Ogf15;
                this.__p_SXQlp8YUB6eQYL5UDed7Dc = __p_SXQlp8YUB6eQYL5UDed7Dc;
                this.__p_Lia0VvKd2mmOYFDhpc9RgP = __p_Lia0VvKd2mmOYFDhpc9RgP;
                this.__p_TtkUZfEBh6eOMR3dFKpQ8W = __p_TtkUZfEBh6eOMR3dFKpQ8W;
                this.__p_HulCyUU1ttcLPKqqUNmq3P = __p_HulCyUU1ttcLPKqqUNmq3P;
                this.__monadicValue_GSBeukiHGurPne2s3dt5oe = __monadicValue_GSBeukiHGurPne2s3dt5oe;
                this.__monadicValue_FjkwamjirLMOO4rgCh4X7D = __monadicValue_FjkwamjirLMOO4rgCh4X7D;
            }
            return that_0;
        }
        protected override n2.Object __ReadProperty__(string key){
            if (key == "__slot_LdA0Hmk4ryAP0wOoulOyre") return this.__slot_LdA0Hmk4ryAP0wOoulOyre;
            if (key == "__slot_UzXtYMlf12LPj1PRN6wrQ3") return this.__slot_UzXtYMlf12LPj1PRN6wrQ3;
            if (key == "__slot_RcllWl1QwBhMGLz5YWVVk5") return this.__slot_RcllWl1QwBhMGLz5YWVVk5;
            if (key == "__slot_SvydDtAgupDNkxozsYMuYH") return this.__slot_SvydDtAgupDNkxozsYMuYH;
            if (key == "__p_R8F6ObfWTfZM4nekGdr68m") return this.__p_R8F6ObfWTfZM4nekGdr68m;
            if (key == "__p_Sve0jJ5h1yzLT3yKk4oedm") return this.__p_Sve0jJ5h1yzLT3yKk4oedm;
            if (key == "__p_IbjV3OTaF7CQM1iXyE3nI6") return this.__p_IbjV3OTaF7CQM1iXyE3nI6;
            if (key == "__p_Cq4GHN80dS7OKhmsKevdJR") return this.__p_Cq4GHN80dS7OKhmsKevdJR;
            if (key == "__loop_NeFeqFDqMN4M5KyWCqF24i") return this.__loop_NeFeqFDqMN4M5KyWCqF24i;
            if (key == "__cp_FoWlg3V5PDsOwpsHc8atHq") return this.__cp_FoWlg3V5PDsOwpsHc8atHq;
            if (key == "__p_FoIwMklzNovNYCHMZD7y0Z") return this.__p_FoIwMklzNovNYCHMZD7y0Z;
            if (key == "__p_JcWErpJJSVANvGRJzZEk9x") return this.__p_JcWErpJJSVANvGRJzZEk9x;
            if (key == "__pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x") return this.__pin_group_Input_In_JcWErpJJSVANvGRJzZEk9x;
            if (key == "__p_ELjmj8P2WvHQOftp3Ogf15") return this.__p_ELjmj8P2WvHQOftp3Ogf15;
            if (key == "__p_SXQlp8YUB6eQYL5UDed7Dc") return this.__p_SXQlp8YUB6eQYL5UDed7Dc;
            if (key == "__p_Lia0VvKd2mmOYFDhpc9RgP") return this.__p_Lia0VvKd2mmOYFDhpc9RgP;
            if (key == "__p_TtkUZfEBh6eOMR3dFKpQ8W") return this.__p_TtkUZfEBh6eOMR3dFKpQ8W;
            if (key == "__p_HulCyUU1ttcLPKqqUNmq3P") return this.__p_HulCyUU1ttcLPKqqUNmq3P;
            if (key == "__monadicValue_GSBeukiHGurPne2s3dt5oe") return this.__monadicValue_GSBeukiHGurPne2s3dt5oe;
            if (key == "__monadicValue_FjkwamjirLMOO4rgCh4X7D") return this.__monadicValue_FjkwamjirLMOO4rgCh4X7D;
            return null;
        }
    }
}
namespace _AudioReactiveVisualizer_.__auto
{
}
namespace _AudioReactiveVisualizer_
{
    public struct __AdaptiveImplementations__RckyMa2RP3mPQ0ttObPClA : n38.IAdaptiveCreateDefault<float>, n39.IAdaptiveOperatorPlus<float>, n39.IAdaptiveOperatorMultiply_Scale<float>
    {
        public static void CreateDefault(out float Output_Out){
            n38._Operations_.CreateDefault_Generic<float>(Output_Out: out float Output_0);
            Output_Out = Output_0;
            return;
        }
        public static void OperatorPlus(float Input_In, float Input_2_In, out float Output_Out){
            float Input_0 = Input_In;
            float Input_2_1 = Input_2_In;
            n17._Operations_.OperatorPlus(Input_In: Input_0, Input_2_In: Input_2_1, Output_Out: out float Output_2);
            Output_Out = Output_2;
            return;
        }
        public static void OperatorMultiply_Scale(float Input_In, float Scalar_In, out float Output_Out){
            float Input_0 = Input_In;
            float Scalar_1 = Scalar_In;
            n17._Operations_.OperatorMultiply_Scale(Input_In: Input_0, Scalar_In: Scalar_1, Output_Out: out float Output_2);
            Output_Out = Output_2;
            return;
        }
    }
}
