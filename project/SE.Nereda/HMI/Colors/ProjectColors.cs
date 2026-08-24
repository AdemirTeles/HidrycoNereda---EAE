namespace SE.Nereda {
    
    
    public class ProjectColors {
        
        public static NxtControl.Drawing.Color Passive;
        
        public static NxtControl.Drawing.Color PowerOFF;
        
        public static NxtControl.Drawing.Color ActiveStatus;
        
        public static NxtControl.Drawing.Color Active;
        
        public static NxtControl.Drawing.Color PassiveStatus;
        
        public static NxtControl.Drawing.Color LedFrameColor;
        
        public static NxtControl.Drawing.Color LedFalseColor;
        
        public static NxtControl.Drawing.Color LedTrueColor;
        
        public static NxtControl.Drawing.Color ButtonTextColor;
        
        public static NxtControl.Drawing.Color ButtonInnerBorderColor;
        
        public static NxtControl.Drawing.Color ButtonTextColorMouseDown;
        
        public static NxtControl.Drawing.Color DevLEDRed;
        
        public static NxtControl.Drawing.Color DevLEDOff;
        
        public static NxtControl.Drawing.Color LabelTextColor;
        
        public static NxtControl.Drawing.BlinkColor Orangwhite;
        
        public static NxtControl.Drawing.BlinkColor DevLEDRedFlash;
        
        public static NxtControl.Drawing.BlinkColor Running;
        
        static ProjectColors() {
            Passive = NxtControl.Drawing.Color.FromName("SE.Nereda.Passive");
            PowerOFF = NxtControl.Drawing.Color.FromName("SE.Nereda.PowerOFF");
            ActiveStatus = NxtControl.Drawing.Color.FromName("SE.Nereda.ActiveStatus");
            Active = NxtControl.Drawing.Color.FromName("SE.Nereda.Active");
            PassiveStatus = NxtControl.Drawing.Color.FromName("SE.Nereda.PassiveStatus");
            LedFrameColor = NxtControl.Drawing.Color.FromName("SE.Nereda.LedFrameColor");
            LedFalseColor = NxtControl.Drawing.Color.FromName("SE.Nereda.LedFalseColor");
            LedTrueColor = NxtControl.Drawing.Color.FromName("SE.Nereda.LedTrueColor");
            ButtonTextColor = NxtControl.Drawing.Color.FromName("SE.Nereda.ButtonTextColor");
            ButtonInnerBorderColor = NxtControl.Drawing.Color.FromName("SE.Nereda.ButtonInnerBorderColor");
            ButtonTextColorMouseDown = NxtControl.Drawing.Color.FromName("SE.Nereda.ButtonTextColorMouseDown");
            DevLEDRed = NxtControl.Drawing.Color.FromName("SE.Nereda.DevLEDRed");
            DevLEDOff = NxtControl.Drawing.Color.FromName("SE.Nereda.DevLEDOff");
            LabelTextColor = NxtControl.Drawing.Color.FromName("SE.Nereda.LabelTextColor");
            Orangwhite = ((NxtControl.Drawing.BlinkColor)(NxtControl.Drawing.Color.FromName("SE.Nereda.Orangwhite")));
            DevLEDRedFlash = ((NxtControl.Drawing.BlinkColor)(NxtControl.Drawing.Color.FromName("SE.Nereda.DevLEDRedFlash")));
            Running = ((NxtControl.Drawing.BlinkColor)(NxtControl.Drawing.Color.FromName("SE.Nereda.Running")));
        }
    }
}
