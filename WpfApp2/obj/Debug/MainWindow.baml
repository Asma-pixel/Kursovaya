   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  CezarEncryprtDecrypt��5   	   $	��650��6&   $	��800��63    � 
ResizeMode$ NoResize=�5	   	    � Icon$ /Resources/laurel32.png��5
   	   .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��/Resources/logo.png��6   $��0��6-   $��Center=�6:   $
��Left=�6U   $��50��6p   $��50��6{   $
��20 0q�6�   �� 5   
   -   5        $��btnBack��5   �   $y�Hidden=�6   $��
Назад��6%   $��Right=�65   $��Center=�6Q   $��0,0,16,0q�6l   $
��auto��6�   $
��15 7q�6�   6�   �� 5   
    �� Orientation$ Vertical=�6   $��Center=�6,   $	��Top=�6I   $	��100��6a   .+�5      o� $��Center=�6   $��Center=�60   
�������$��0 0 0 30q�6b   .@�5      m� $��Инструкция��6   61   �� 5      m� 5      $��О программе��6   63   5      �� 5      $I��CПрограмма для работы с шифром цезаря��6   $��24(�6D   $��Italic$�6R   $��Center=�6e   $��Center=�6�   $��0q�6�   5       � 5   
   -   5        $��	MainFrame��5   4     � NavigationUIVisibility$ Hidden=�6E   $��0,98,0,0q�6e   $��2��6w   5      5      