   M S B A M L   `   `   `  ����H  DAryantUtility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Ping_TesterPing_Tester  5   	       Ping_Tester.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Ping_Tester     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Title$ Aryant Utility��5	   	   $	��500��6    $	��900��6-   $��14(�6:   $��Normal"�6H   $	��900��6\   $	��550��6k   ���	#FF191919 � Icon$ 
/icon1.png��6�    � WindowState$ Normal=�6�    � WindowStartupLocation$ CenterOwner=�6�    � WindowStyle$
 None=�6�    � AllowsTransparency$
 True��6�   .��5      � $y�Visible=�6    � RowDefinitions 5   
   �� 5      $��26 �6   �� 5      .+�5   
   �� -   5        ���#252525._�5      � $��Stretch=�6   .+�5      �� $��Aryant Utility��6   
�������$��SemiBold"�5      $��Roboto)�5      $	��Top=�5      $��5,0,0,0q�5      6+   �� 5       $��Right=�6    �� Orientation$ 
Horizontal=�69   .+�5!      �� -   5        	 ��Name$	 MinimizeButton��5!      $��21��65   $��21��6A   $
��🗕��6L   $��18(�6Y   $��0,0,3,0q�6g   $��	-1,-8,0,0q�6x   $��0q�6�   
������ 
�������$
��Bold"�6�   6�   �� 5"      -   5        $	 MaximizeButton��5"      $��21��65   $��21��6A   $	��□��6L   $��26(�6X   $��0,0,5,0q�6f   $��-0.5,-12,0,0q�6w   $��0q�6�   
������ 
�������$
��Bold"�6�   6�   �� 5#      -   5        $	 CloseButton��5#      $��21��62   $��21��6>   $	��╳��6I   $��0,0,5,0q�6U   $��	-1,-4,0,0q�6f   $��0q�6z   
������ 
�������$
��Bold"�6�   6�   5$      5%      5'      �� 5(   
   -   5        $	 StartButton��5(      $��0,358,369,0q�6@   $��
Start Test��6U   $��Roboto)�6j   $��normal"�6~   ���	#FF707070���	#FF313131���	#FFF7F7F7
 � UseLayoutRounding$
 False��6�   $��1��6�   $��26��6�   $	��Top=�6  $��Right=�6#  $	��187��6?  �� 5)   
   -   5         ��Name$ AppTitle��5)      $��Right=�6&   $��0,0,370,459q�6B   $
��Wrap=�6W   $��Aryant Utility��6k   $��Roboto)�6�   $��32(�6�   $��Light"�6�   
������� �� TextAlignment$ Center=�6�   $	��186��6�   $��1��6�   $��39��6�   $��Bottom=�6  �� 5*   
   -   5        $ 
PingTarget��5*      $��Right=�6(   $��
0,70,387,0q�6D   $
��Wrap=�6X   $	��Top=�6l   $	��152��6�   $��Roboto)�6�   ���	#FFD2D2D2$ Center=�6�   $��17��6�   $��1��6�   �� 5+   
   -   5        $ PingCounter��5+      $
��Wrap=�6)   $ Center=�6=   $��60(�6T   $��OpenSans)�6b   
�������$
��Left=�6�   $	��580��6�   $��147,208,0,0q�6�   $��1��6�   $��72��6�   $	��Top=�6�   �� 6�    � Language$ pl-pl�6�   $�W��6  �� 6  $�	aiting...��6  61  �� 5,   
   -	   5        $ wersja��5,      $��0,466,434,0q�6$   $
��Wrap=�69   ���	#FF7D7D7D$ center=�6d   $��Roboto)�6{   $��58��6�   $��Right=�6�   $��1��6�   $��19��6�   $	��Top=�6�   �� 6�   $	�V1.��6�   �� 6�   $ pl-pl�6�   $�2��6  6  �� 5-   
   -
   5        $	 
StopButton��5-      $��0,358,369,0q�6%   $��	Stop Test��6:   $��Roboto)�6N   $��normal"�6b   ���	#FF707070$��26��6�   $	��Top=�6�   ���	#FF313131���	#FFF7F7F7$y�hidden=�6�   $��1��6  $��Right=�6  $	��187��66  �� 5.   
   -   5        $ PingCountdown��5.      $��Right=�6+   $
��Wrap=�6G   ���	#FF848484$��Roboto)�6r   $��80��6�   $ Center=�6�   $	��Top=�6�   $��18��6�   $��0,335,423,0q�6�   $y�Visible=�6�   $�� ��6�   $��1��6�   5/      51      