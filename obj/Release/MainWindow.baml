   M S B A M L   `   `   `  ���� E  AVSLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:VSLauncher
VSLauncher      VSLauncher.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:VSLauncher     -     � Title$  
VSLauncher��$��512.5��$��300.8��$��Center=�$��Center=� � 
ResizeMode$ NoResize=� � Icon$ limg/gameicon.ico�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�����  �� ImageSource$ limg/soil.png�� j� Viewport$ 	0,0,40,40� j� TileMode$
 Tile=� j� Viewbox$ 	0,0,86,86�	 j� ViewportUnits$	 Absolute=�
 j� ViewboxUnits$
 Absolute=� � 	Resources    ComboboxButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers :� RoutedEvent  
SaveButton 
 CmbBtn P� Property P� Value  	VSTextBox �Name J� SnapsToDevicePixels ��Name �� CornerRadius ��Name��%  &	        &	     &	     &	 �    �� " ��.���  �@�OverridesDefaultStyle . ��  � �� �	#51000000��  � �� �� " ��.R��� $��border��$��0q�
���   �#��z��._��� $��Center=�$��Center=� :� $ PreviewMouseDown��.[��� .���� :� $ PreviewMouseUp��.[��� .���� �� " ��.���  �@�OverridesDefaultStyle . ��  � �� �� " ��.R��� $��border��$��0q����	#FF262020#��z��._��� $��Center=�$��Center=� :� $ PreviewMouseDown��.[��� .���� :� $ PreviewMouseUp��.[��� .���� �� " ��.���  �@�OverridesDefaultStyle . ��  � ��
 ���� ��  � ��$ 25����  � �� �	#FFE0CFBB��  � ��$ 13(���  � ��$ Tahoma)���  � �� �� " ��.R��� $��border��$��0q�
���   �#��z��._��� $
��Left=�$��Center=�$��8,0,0,0q� P�  �@J�IsMouseOver . . ���  � �� �	#CCE0CFBB��  � �� �	#FF262020�� " ��.���  � �� �	#51000000��  � ��$ 35����  � �� �	#FFE0CFBB��  � ��$ 14(���  � ��$ Tahoma)���  � �� �	#59E0CFBB��  � ��$ Center=���  � ��$ 8,-1,0,0q���  � �� �� " ��.R�� $
 root��#��z��#��z�� . .+��� $ 
Background��$��1q�$ 0��#��z��#��z���� $ PART_ContentHost��$��0q�#��z����.  #��z����Z�  P�  �@J�IsMouseOver . . ���  � �� �	#7FE0CFBBP�  �@J�	IsFocused . . ���  � �� �	#FFE0CFBB��  � �� �	#B2262020.���  � RowDefinitions �� $��35 ��� $	��195 ��� $	��273 �.+�� -   $��Toolbar��$��0�����	#FF262020 � Cursor$ Arrow��$��2��$��
0,0,-0.2,0q�.+���  �� Orientation$ 
Horizontal=�$
��Left=�.+��� $��limg/gameicon.ico��$��18��$��18��$��8,1,0,0q�$ Arrow���� $��VSLauncher (v0.3.3)��$��Tahoma)�$
��13.5(�$��Center=�$��Center=����	#FFE0CFBB$��1,0,0,0q�$
��Bold"�$ Arrow���� $ 
Horizontal=�$��Right=�.+��� -   $	��–��$
��Bold"�$��Tahoma)�$��14(�$��Center=�$��Center=�$��0,0,6,0q�$
 Hand������ " ��.���  � �� �	#FFE0CFBB �� Triggers P�  �@J�IsMouseOver . . ���  � �� �	#FFA39585�� -   $��X��$
��Bold"�$��Tahoma)�$��14(�$��Center=�$��Center=�$��0,0,8,0q�$
 Hand������ " ��.���  � �� �	#FFE0CFBB P�  �@J�IsMouseOver . . ���  � �� �	#FFA39585� -   $
��Logo��$��1��$��2��$��
0,0,-0.2,0q�.+��� $��limg/logo.png��$	��175��$��0,15,0,5q�� -   $��	LoginData��$��2�� K� ZIndex$ 5��$��2��$��0,0,-0.2,-0.4q�.+��� -   $��	CbmBorder��$��24��$��40��$
��Left=�$	��Top=�$��25,5,0,0q�$��1q� � ToolTip$$ Выбор языка игры��$
 Hand��
������ ���� " ��.���  � �� �	#59E0CFBB P�  �@J�IsMouseOver . . ���  � �� �	#7FE0CFBB:� $ PreviewMouseDown��.[��� .���� .����  �� TargetProperty$ BorderBrush.Color�  g� Duration$  	0:0:0.000D�	! �� To$! 	#59E0CFBBX�:� $ PreviewMouseUp��.[��� .���� .���� $ BorderBrush.Color�$  	0:0:0.000D�$! 	#7FE0CFBBX�._��� -   #��[  .���� $ 
Horizontal=�.+��� $��13��$��13��$��4,0,0,0q����� " ��.���  � ��$# limg/Icons/globe_inactive.png�� �� " �� Binding" �� # �� Path$# IsMouseOver�$ �� ElementName$$ 	CbmBorder��% �� Value% True.a���  � ��$! limg/Icons/globe_active.png���� " �� & �� RelativeSource& �� *FindAncestor+' �� AncestorType"' ��( �� AncestorLevel$( 1��$# 	IsPressed�% True.a���  � ��$# limg/Icons/globe_inactive.png���� $��10��$��10��$��4,0,5,0q����� " ��.���  � ��$% limg/Icons/chevron_inactive.png�� �� " �� $# IsMouseOver�$$ 	CbmBorder��% True.a���  � ��$# limg/Icons/chevron_active.png���� " �� & �� *FindAncestor+"' ��$( 1��$# 	IsPressed�% True.a���  � ��$% limg/Icons/chevron_inactive.png��� -	   $��LanguageGrid��$��2��$��74��$	��154��$
��Left=�$	��Top=�$��	25,33,0,0q�$y�Hidden=�$ 10��.+�� 
������ $	��2.5�����	#FF262020) � PointsC) �   ��[ ������������[ ��)��[ �ү��5��[ � ���	#FF262020���	#7FE0CFBBC) �   ��[ ������������[ ��)��[ �ү��5��[ $��1��� $��55��$	��144��$
��Left=�$	��Top=�$��2.9,10.1,0,0q�.+��� $ Vertical=�.+��� -
   #��[ $
 Hand��.���� $$��English \ Английский���� -   #��[ $��	0,1.8,0,0q�$
 Hand��.���� $��Russian \ Русский���� -   $��LanguageLabel��$�� ��$��Tahoma)�$��Normal"����	#FFE0CFBB$��13(�$	��Top=�$
��Left=�$��
72,8.9,0,0q�$ Язык игры���� -   $��CbmBorderHelp��$��24��$��24��$��Right=�$	��Top=�$��0,5,25,0q�$��1q�$ Помощь��
������ ���� " ��.���  � �� �	#59E0CFBB P�  �@J�IsMouseOver . . ���  � �� �	#7FE0CFBB:� $ PreviewMouseDown��.[��� .���� .���� $ BorderBrush.Color�$  	0:0:0.000D�$! 	#59E0CFBBX�:� $ PreviewMouseUp��.[��� .���� .���� $ BorderBrush.Color�$  	0:0:0.000D�$! 	#7FE0CFBBX�._��� -   #��[  $
 Hand��.���� $ 
Horizontal=�.+��� $��13��$��13��$��0,0,0,0q����� " ��.���  � ��$" limg/Icons/info_inactive.png�� �� " �� $# IsMouseOver�$$ CbmBorderHelp��% True.a���  � ��$  limg/Icons/info_active.png���� " �� & �� *FindAncestor+"' ��$( 1��$# 	IsPressed�% True.a���  � ��$" limg/Icons/info_inactive.png���� -   * ��Name$* NicknameBox��$��2��#��[ $��
25,39,25,0q�$	��Top=�$�� ��$��8,-1,8,0q��� + J� IsHitTestVisible+ .  $��14(�$��Tahoma)�$��Ваш никнейм��$��
35,48,35,0q�$	��Top=����	#3FE0CFBB���� " ��.���  � y�$ 	Collapsed=� �� " �� *Text+$$ NicknameBox��%  .a���  � y�$ Visible=��� -   $* PlayerUIDBox��$��2��#��[ $��
25,84,25,0q�$	��Top=�$�� ��$��8,-1,8,0q��� + .  $��14(�$��Tahoma)�$��
Ваш UID��$��
35,93,40,0q�$	��Top=����	#3FE0CFBB���� " ��.���  � y�$ 	Collapsed=� �� " �� *Text+$$ PlayerUIDBox��%  .a���  � y�$ Visible=��� -   , ��Name$, StatusLabel��$��Tahoma)�$��12(�$
��Left=�$	��Top=����	#FF998D7F$��25,125.5,25,0q�$��Normal"�$ Arrow��$��0q�.���� -   - ��Name$- 
StatusText��$��WrapWithOverflow=�$��Center=�$
��Left=�$y�Visible=��� -   $��
SaveButton��$��35��$	��Top=�$��25,199,25,0q�$��1q�$C =Сохранить настройки никнейма и UID��$
 Hand��$y�Visible=����� " ��.���  � �� �	#FFE0CFBB��  � �� �	#FFE0CFBB P�  �@J�IsMouseOver . . ���  � �� �	#FFCBBAA8��  � �� �	#FFCBBAA8:� $ PreviewMouseDown��.[��� .���� .���� $ BorderBrush.Color�$  	0:0:0.000D�$! 	#FFB9A999X��� $ Background.Color�$  	0:0:0.000D�$! 	#FFB9A999X�:� $ PreviewMouseUp��.[��� .���� .���� $ BorderBrush.Color�$  	0:0:0.000D�$! 	#FFCBBAA8X��� $ Background.Color�$  	0:0:0.000D�$! 	#FFCBBAA8X�._��� -   #��[ .���� $ 
Horizontal=�.+��� $+��%Сохранить настройки��$��Tahoma)�$��16(�$
��Bold"����	#FF262020$��Center=�$��Center=��� -   $��
PlayButton��$��35��$	��Top=�$��25,199,25,0q�$��1q�$! Запустить игру��$
 Hand��$y�Hidden=����� " ��.���  � �� �	#FF9AC73E��  � �� �	#FF9AC73E P�  �@J�IsMouseOver . . ���  � �� �	#FF7EA333��  � �� �	#FF7EA333:� $ PreviewMouseDown��.[��� .���� .���� $ BorderBrush.Color�$  	0:0:0.000D�$! 	#FF6E8E2CX��� $ Background.Color�$  	0:0:0.000D�$! 	#FF6E8E2CX�:� $ PreviewMouseUp��.[��� .���� .���� $ BorderBrush.Color�$  	0:0:0.000D�$! 	#FF7EA333X��� $ Background.Color�$  	0:0:0.000D�$! 	#FF7EA333X�._��� -   #��[ .���� $ 
Horizontal=�.+��� -   $, PlayGameBtnLabel��$��Играть!��$��Tahoma)�$��16(�$
��Bold"����	#FF262020$��Center=�$��Center=��� $��Made By Outcast��$��Tahoma)�$��12(�$��Center=�$	��Top=����	#FF998D7F$��0,242.5,0,0q�$��Normal"�$ Arrow��