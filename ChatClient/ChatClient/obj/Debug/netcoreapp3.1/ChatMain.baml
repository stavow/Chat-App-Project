   M S B A M L   `   `   `  ����E  AChatClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ChatClient
ChatClient  5   	       ChatClient.ChatMain   5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ChatClient     5   	   -   5          �Name$  
ChatWindow��5   	    � AllowsTransparency$
 True��5	   	    � WindowStyle$
 None=�5
   	   $��1q�5   	   
���   � � Title$ ChatMain��5   	   $	��639��6   $	��800��6'   ���	#FF1F1F1F � WindowStartupLocation$ CenterScreen=�6J   .��5      � .+�5   
   �� $��C H A N N E L S��6   $��10,68,608,38q�6-   .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Custom=�6E      
Foreground
 �   �   
Background �	#FF0BC8FF$��./Fonts/#Poppins Regular)�6�   .��5      R� -   5         R�Name$ categoriesTreeView��5      $	��110��63   	 R� SelectedValuePath$	 Header��6}   ���	#FF1515155      5      �� 5   
   -   5        
 ��Name$
 
topTaskbar��5      $��0,0,0,0q�6)   
���   �$��37��6M   $	��Top=�6Y   .+�5      �� -   5         ��Name$ title��5      $��C H A T  C L I E N T��6'   $
��Wrap=�6D   $	��284��6X   $��37��6d   $
��Left=�6p   ���	#FF0BC8FF$��./Fonts/#Poppins Regular)�6�   $��20(�6�    �� Padding$ 20,7,0,0q�6�   5      �� 5   
   -   5         ��Name$ exitBtn��5      $��Right=�6"   $	��Top=�6>   $��37��6V    "  CustomMaterialDesignFlatButton#���   6b   $��46��6�   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowClose=�6&   
���  ��69   5      �� 5   
   -   5        $ minimizeBtn��5      $��0q�6'   +  %MaterialDesignThemes.Wpf.RippleAssist   Feedback
 ���� $��Right=�6�   $	��Top=�6�   $��37��6�   #���   6�   $��46��6�   $��0,0,50,0q�6	  ��6;   Z� .��5        $ WindowMinimize=�6&   
�������$��31��6O   $	��0,5q�6[   5      �� 5   
   -   5         ��Name$ 
messageBox��5        CustomMaterialDesignTextBox#���  6&   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Write A Message...��6\   $
��Left=�6�   $��203,556,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��474��6�   
�������$��43��6  �� 5    
   $��M E S S A G E S��6   $��203,68,16,120q�6-   $ Custom=�6F   
 �   � �	#FF0BC8FF$��./Fonts/#Poppins Regular)�6�   .��5!      �� -   5        $ messages��5!      
�������$��Consolas)�6L    �� 
IsReadOnly$
 True��6b   ���	#FF151515���	#00ABADB3��6(   Z� 6�   5"      �� 5#   
   -	   5        $ 
sendMsgBtn��5#        CustomMaterialDesignButton#���  6%   $
��Send��6Z   $
��Left=�6i   $��711,562,0,0q�6�   $	��Top=�6�   6�   5$      5%      