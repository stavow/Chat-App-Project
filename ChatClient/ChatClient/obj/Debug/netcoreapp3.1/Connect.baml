   M S B A M L   `   `   `  ����E  AChatClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ChatClient
ChatClient  5   	       ChatClient.Connect   5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ChatClient     5   	   -   5          �Name$  ConnectWindow��5   	    � AllowsTransparency$
 True��5	   	    � WindowStyle$
 None=�5
   	   $��1q�5   	   
���   � � Title$ 
MainWindow��5   	   $	��255��6   $	��494��6)   ���	#FF1F1F1F � WindowStartupLocation$ CenterScreen=�6L   .��5      � .+�5   
   �� -   5         ��Name$ 
topTaskbar��5      $��0,0,0,0q�6)   
���   �$��37��6M   $	��Top=�6Y   .+�5      �� -   5         ��Name$ title��5      $��C O N N E C T��6'   $
��Wrap=�6=   $	��284��6Q   $��37��6]   $
��Left=�6i   ���	#FF0BC8FF$��./Fonts/#Poppins Regular)�6�   $��20(�6�    �� Padding$ 20,7,0,0q�6�   5      � 5   
   $��0,37,0,0q�6   .+�5      �� -   5         ��Name$
 tabs��5       "  CustomMaterialDesignTabControl#��[  6'   .  (MaterialDesignThemes.Wpf.ColorZoneAssist	   Mode$	 
PrimaryMid=�6_   ���	#FF1F1F1F.@�5      �� -   5        
 ��Name$
 loginTab��5       ' #MaterialDesignNavigationRailTabItem#��[ 6c   ��6,   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Login=�   Size 24.��5      � .+�5      �� $��Login��6$   $��30��61   $��0,12,0,0q�6=   $	��Top=�6O   $��Center=�6g   $��18(�6�   ���	#FF0BC8FF$
��Bold"�6�   6�   �� 5      -   5         ��Name$ unLogin��5   "     CustomMaterialDesignTextBox#���  63   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��6i   $��Center=�6�   $	��200��6�   $��
0,43,0,133q�6�   $��40��6�   6�   �� 5      -   5        $ pwdLogin��5   "   #���  64   $ Password��6j   $��Center=�6�   $	��200��6�   $��
0,101,0,75q�6�   $��40��6�   6�   �� 5      -   5         ��Name$ loginBtn��5   !     CustomMaterialDesignButton#���  63   $��Center=�6h   $	��100��6�   $��Login��6�   $��
0,167,0,17q�6�   6�   5      5      �� 5      -	   5        $
 registerTab��5      #��[ 6l   ��6/     $ AccountPlus=� 24.��5      � .+�5      �� $��Register��6$   $��30��64   $��0,12,0,0q�6@   $	��Top=�6R   $��Center=�6j   $��18(�6�   ���	#FF0BC8FF$
��Bold"�6�   6�   �� 5      -
   5        $ unReg��5   "   #���  61   $ Username��6g   $��Center=�6�   $	��200��6�   $��
0,43,0,133q�6�   $��40��6�   6�   �� 5       -   5        $ pwdReg��5    "   #���  62   $ Password��6h   $��Center=�6�   $	��200��6�   $��
0,101,0,75q�6�   $��40��6�   6�   �� 5!      -   5        $ registerBtn��5!   !   #���  66   $��Center=�6k   $	��100��6�   $��Register��6�   $��
0,167,0,17q�6�   6�   5"      5#      �� 5$      -   5        $
 connectionSettingsTab��5$      #��[ 6w   ��69     $ WifiSettings=� 24.��5%      � .+�5&      �� $��Connection Settings��6$   $��30��6?   $��0,12,0,0q�6K   $	��Top=�6]   $��Center=�6u   $��18(�6�   ���	#FF0BC8FF$
��Bold"�6�   6�   �� 5'      -   5        $ ip��5'   "   #���  6.   $ IP��6d   $��Center=�6�   $	��144��6�   $��
0,43,0,133q�6�   $��40��6�   6�   �� 5(      -   5        $
 port��5(   "   #���  60   $
 Port��6f   $��Center=�6�   $��81��6�   $��
0,101,0,75q�6�   $��40��6�   6�   �� 5)      -   5        $ updateConfig��5)   !   #���  67   $��Center=�6l   $	��100��6�   $��Update��6�   $��
0,167,0,17q�6�   6�   5*      5+      5,      5-      �� 5.   
   -   5        $ exitBtn��5.      $��Right=�6"   $	��Top=�6>   $��37��6V    " CustomMaterialDesignFlatButton#���  6b   $��46��6�   .��5/      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowClose=�6&   
���  ��69   51      52      53      