   M S B A M L   `   `   `  ����P  LViking Rejser Eksamen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Viking_Rejser_Eksamen.ViewViking_Rejser_Eksamen.View  5   	   (    "Viking_Rejser_Eksamen.View.NyRejse   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Viking_Rejser_Eksamen.View     5   	     � Title$  NyRejse��5   	   $	��450��6   $	��350��6&   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $	��230 �6   �� 5      .+�5   
   �� $��Opret ny Rejse��6   $��1��6)   $
��Left=�69   $��	72,22,0,0q�6T   $	��Top=�6g   �� 5   
   -   5         ��Name$ 
RejseTitel��5      $��1��6&   $��23��66   $��
56,53,56,0q�6B    �� TextWrapping$
 Wrap=�6V   $��Titel��6j   $	��Top=�6w   �� 5   
   -   5        $ RejseBy��5      $��1��6#   $��23��63   $��
56,88,56,0q�6?   $
 Wrap=�6S   $��By��6g   $	��Top=�6q   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ RejseStartDato��5      $��1��6-   $
��Left=�6=   $��
56,126,0,0q�6X   $	��Top=�6l   $	��120��6�      FirstDayOfWeek$ Monday=�6�      Text$ Afgang��6�     5   
   -   5        $ RejseSlutDato��5      $��1��6,   $
��Left=�6<   $��
56,160,0,0q�6W   $	��Top=�6k   $	��120��6�   �� 5   
   -   5        $ RejseMaxDeltagere��5      $��1��6-   $��23��6=   $��56,194,56,0q�6I   $
 Wrap=�6^   $��Max Antal Deltagere��6r   $	��Top=�6�   �� 5   
   -   5         ��Name$ RejseTransportoer��5      $��1��6.   $
��Left=�6>   $��
56,229,0,0q�6Y   $	��Top=�6m   $	��120��6�   �� 5   
   -   5        $ PrisPrDeltager��5      $��1��6*   $��23��6:   $��56,264,56,0q�6F   $
 Wrap=�6[   $��Pris Pr. Deltager��6o   $	��Top=�6�   �� 5   
   -   5        $ RejseBeskrivelse��5      $��1��6,   $��68��6<   $��56,303,56,0q�6H   $
 Wrap=�6]   $��Beskrivelse��6q   $	��Top=�6�   �� 5   
   -	   5         ��Name$ RejseCreate��5      $��Create��6&   $��1��67   $
��Left=�6G   $��
75,386,0,0q�6b   $	��Top=�6v   $��75��6�   6�   5      5      