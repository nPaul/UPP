using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.�����������
{
	public partial class ��������������������������������������
	{
		////////////////////////////////////////////////////////////////////////////////
		// ��������������� ��������� � �������
		// ��������� ������ �� ���������
		//
		// ���������:
		//		��������� � ������:
		//			�����������;
		//			����;
		//			����.
		//
		// ������������ ��������:
		//  ��������� �������
		//

		public object ��������������������������������������(/*������������������*/)
		{
			/*������ = ����� ������;*/
			/*������.������������������("������������������", ������������������);*/
			/*������.������������������("������������������", ������������������.�����������);*/
			/*������.������������������("�������������", 		������������������.����);*/
			/*������.����� = 
		��������������������������.����������������������������������������(
			"�������������",
			"����������������� � (��������(������������.����������������������������.������������),��������(������������.����������������������������.����������������))
			|� ������������������ = &������������������")
		+ ";"
		+�������.��
		+�������.��
		+ "////////////////////////////////////////////////////////////////////////////////"
		+�������.��
		+
		"�������
		|	������������������.���� ��� �������,
		|	������������������.�����������.������������������ ��� �������������������,
		|	����������������.������������������������������ ��� ���������
		|��
		|	��������." + ������������������.����������().��� + " ��� ������������������
		|		����� ���������� ��������������������������� ��� ����������������
		|		�� (����������������.����������������� = ��������(������������.����������������������������.����������������))
		|���
		|	������������������.������ = &������������������";*/
			return null;
		}
		// ���������������������������()
		// ��������� ������ �� ���������
		//
		// ���������:
		//  ������������������ - ��������, �� �������� ����������� ������
		//		��������� ��������� ��������� ��� �������� � ������� �����������
		//  ��������� - ������, ��������� �������� � ������� �����������
		//  ������������� - ������, ������������ ��� ������������� ������ ��� � ����������
		//
		// ������������ ��������:
		//  ��������� �������
		//

		public object ����������������������������������������(/*�������������, ���������, �������������*/)
		{
			/*������ = ����� ������;*/
			/*������.������������������("�������������",	�������������);*/
			/*������.������������������("���������",		���������);*/
			/*������.������������������("�������������",	�������������);*/
			/*������.����� =
	"������� �����������
	|	�����������������������������������.������� ��� �������,
	|	���������������������������������.������������������ ��� ������������������,
	|	�����(�����������������������������������.����� + �����������������������������������.�����������������������������) ��� �����
	|��������� ���������
	|��
	|	��������.���������������������������.�������� ��� �����������������������������������
	|		����� ���������� ���������������.��������������������������������� ��� ���������������������������������
	|		�� �����������������������������������.������� = ���������������������������������.�������
	|			� �����������������������������������.������.���� = ���������������������������������.����
	|			� �����������������������������������.������.����������� = ���������������������������������.�����������
	|���
	|	�����������������������������������.����� + �����������������������������������.����������������������������� > 0
	|	� �����������������������������������.������ �(&���������)
	|
	|������������� ��
	|	�����������������������������������.�������,
	|	���������������������������������.������������������
	|
	|������������� ��
	|	�������
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|�������
	|	����NULL(����������������������.������� + �����
	|			����� ���������(����������������������.���, 1, 1) <> """"
	|				����� "" "" + �����
	|						����� &�������������
	|							����� ���������(����������������������.���, 1, 1) + "".""
	|						����� ����������������������.���
	|					�����
	|			����� """"
	|		����� + �����
	|			����� ���������(����������������������.��������, 1, 1) <> """"
	|				����� "" "" + �����
	|						����� &�������������
	|							����� ���������(����������������������.��������, 1, 1) + "".""
	|						����� ����������������������.��������
	|					�����
	|			����� """"
	|		�����, �������.�������.������������) ��� �������,
	|	�������.������������������ ��� ������������������,
	|	�������.����� ��� �����
	|��
	|	��������� ��� �������
	|		����� ���������� ���������������.���������.�������������(
	|				&�������������,
	|				������� �
	|					(������� ���������
	|						������������.�������
	|					��
	|						��������� ��� ������������)) ��� ����������������������
	|		�� �������.������� = ����������������������.�������
	|
	|����������� ��
	|	�������";*/
			return null;
		}
		// ����������������������������������������������()
		////////////////////////////////////////////////////////////////////////////////
		// ��������� � ������� ��������� ������� ��������

		public object ������������������������������������������������������������������(/*�������, �������������, ��������� = ������������*/)
		{
			/*���������� = "��='d MMM yyyy ""�.""'";*/
			/*���������������������� = ��������������������("������������������������");*/
			/*����� = ������������������("�����������������������������������");*/
			/*����������� = ����� �����������������;*/
			/*�����������.������������������� = "���������_������_�����������������������������������������";*/
			/*������ = ����� ������;*/
			/*������.������������������("�������",	�������);*/
			/*������.����� =
	"�������
	|	�������������.���������,
	|	�������������.����������,
	|	�����
	|		����� ����������.�������������� ���� NULL 
	|				��� ����������.�������������� < �������������.����������
	|			����� ���������(1, 1, 1)
	|		����� ����������.��������������
	|	����� ��� ��������������,
	|	�������������.�������������,
	|	�������������.���������,
	|	�������������.���,
	|	����NULL(��������������������������.�������������������������, 20) ��� �������������������������
	|��
	|	(�������
	|		���������.�������.������������ ��� ���������,
	|		���������.������ ��� ����������,
	|		���������.�������������.������������ ��� �������������,
	|		���������.���������.������������ ��� ���������,
	|		���������.�������.��� ��� ���,
	|		���������.������� ��� �������
	|	��
	|		���������������.��������� ��� ���������
	|			���������� ���������� (�������
	|				��������(���������.������) ��� ������,
	|				���������.������� ��� �������
	|			��
	|				���������������.��������� ��� ���������
	|			���
	|				���������.������������������������� = ��������(������������.�������������������������.�������������)
	|				� ���������.������� = &�������
	|			
	|			������������� ��
	|				���������.�������) ��� ����������������
	|			�� ���������.������ = ����������������.������
	|				� ���������.������� = ����������������.�������
	|	���
	|		���������.������������������������� = ��������(������������.�������������������������.�������������)
	|		� ���������.������� = &�������) ��� �������������
	|		����� ���������� ���������������.�������������������������� ��� ��������������������������
	|		�� (������)
	|		����� ���������� (�������
	|			�������������(���������.������, ����, -1) ��� ��������������,
	|			���������.������� ��� �������
	|		��
	|			���������������.��������� ��� ���������
	|				���������� ���������� (�������
	|					��������(���������.������) ��� ������,
	|					���������.������� ��� �������
	|				��
	|					���������������.��������� ��� ���������
	|				���
	|					���������.������������������������� = ��������(������������.�������������������������.����������)
	|					� ���������.������� = &�������
	|				
	|				������������� ��
	|					���������.�������) ��� ����������������
	|				�� ���������.������ = ����������������.������
	|					� ���������.������� = ����������������.�������
	|		���
	|			���������.������������������������� = ��������(������������.�������������������������.����������)
	|			� ���������.������� = &�������) ��� ����������
	|		�� �������������.������� = ����������.�������
	|
	|������������� ��
	|	����NULL(��������������������������.�������������������������, 20),
	|	�������������.���������,
	|	�������������.����������,
	|	�������������.�������������,
	|	�������������.���������,
	|	�������������.���,
	|	�����
	|		����� ����������.�������������� ���� NULL 
	|				��� ����������.�������������� < �������������.����������
	|			����� ���������(1, 1, 1)
	|		����� ����������.��������������
	|	�����";*/
			/*������� = ������.���������().�������();*/
			/*���������� = ����(1,1,1);*/
			if(true/*�������.���������()*/)
			{
				/*���������� = �������.����������;*/
				/*������������� = �����.���������������("�����������");*/
				/*�������������.���������.���������(�������);*/
				/*�����������.�������(�������������);*/
				/*������������� = �����.���������������("�����");*/
				/*�������������.���������.������		= ������(����������, ����������);*/
				if(true/*�������.��� = ������������.����������������.�������*/)
				{
					/*�������������.���������.�����������	= "������� �� ������";*/
				}
				/*�����������.�������(�������������);*/
				/*������������� = �����.���������������("������");*/
				/*�������������.���������.�����			= "" + �������.������������������������� + " " + ����������������.������������������������("����","���","����",�������.�������������������������) + " ������� � ���";*/
				/*�����������.�������(�������������);*/
				/*������������� = �����.���������������("������");*/
				/*�����������.�������(�������������);*/
			}
			if(true/*�������.����������() = 0*/)
			{
				/*������.����� =
		"�������
		|	�������������.��������� ��� ���������,
		|	�������������.���������� ��� ����������,
		|	�����
		|		����� ����������.�������������� ���� NULL 
		|				��� ����������.�������������� < �������������.����������
		|			����� ���������(1, 1, 1)
		|		����� ����������.��������������
		|	����� ��� ��������������,
		|	����NULL(��������������������������������������������������.�������������.������������, ""������������� �� �������"") ��� �������������,
		|	�������������.��������� ��� ���������,
		|	�������������.��� ��� ���,
		|	����NULL(��������������������������.�������������������������, 20) ��� �������������������������,
		|	�������������.������������������������� ��� �������������������������
		|��
		|	(�������
		|		���������.���������.�������.������������ ��� ���������,
		|		��������(���������.������) ��� ����������,
		|		���������.���������.������������ ��� ���������,
		|		���������.���������.�������.��� ��� ���,
		|		���������.�������������������������.������������ ��� �������������������������,
		|		���������.������������������������ ��� ������������������������,
		|		���������.���������.������� ��� �������
		|	��
		|		���������������.�������������������� ��� ���������
		|			���������� ���������� (�������
		|				��������(���������.������) ��� ������,
		|				���������.���������.������� ��� �������
		|			��
		|				���������������.�������������������� ��� ���������
		|			���
		|				���������.������������������������� = ��������(������������.�������������������������.�������������)
		|				� ���������.���������.������� = &�������
		|			
		|			������������� ��
		|				���������.���������.�������) ��� ����������������
		|			�� ���������.������ = ����������������.������
		|				� ���������.���������.������� = ����������������.�������
		|	���
		|		���������.������������������������� = ��������(������������.�������������������������.�������������)
		|		� ���������.���������.������� = &�������
		|	
		|	������������� ��
		|		���������.���������.�������.������������,
		|		���������.���������.������������,
		|		���������.���������.�������.���,
		|		���������.�������������������������.������������,
		|		���������.������������������������,
		|		���������.���������.�������) ��� �������������
		|		����� ���������� ���������������.�������������������������� ��� ��������������������������
		|		�� (������)
		|		����� ���������� (�������
		|			���������.���������.������� ��� �������,
		|			��������(���������.������) ��� ��������������
		|		��
		|			���������������.�������������������� ��� ���������
		|				���������� ���������� (�������
		|					��������(���������.������) ��� ������,
		|					���������.���������.������� ��� �������
		|				��
		|					���������������.�������������������� ��� ���������
		|				���
		|					���������.������������������������� = ��������(������������.�������������������������.����������)
		|					� ���������.���������.������� = &�������
		|				
		|				������������� ��
		|					���������.���������.�������) ��� ����������������
		|				�� ���������.������ = ����������������.������
		|					� ���������.���������.������� = ����������������.�������
		|		���
		|			���������.������������������������� = ��������(������������.�������������������������.����������)
		|			� ���������.���������.������� = &�������
		|		
		|		������������� ��
		|			���������.���������.�������) ��� ����������
		|		�� �������������.������� = ����������.�������
		|		����� ���������� ���������������.�������������������������������������������������� ��� ��������������������������������������������������
		|		�� �������������.������������������������ = ��������������������������������������������������.������������������������";*/
				/*������� = ������.���������().�������();*/
				if(true/*�������.���������()*/)
				{
					/*���������� = �������.����������;*/
					/*������������� = �����.���������������("�����������");*/
					/*�������������.���������.���������(�������);*/
					/*�����������.�������(�������������);*/
					/*������������� = �����.���������������("�����");*/
					/*�������������.���������.������		= ������(����������, ����������);*/
					if(true/*�������.��� = ������������.����������������.�������*/)
					{
						/*�������������.���������.�����������	= "������� �� ������ � ����������� " + �������.�������������������������;*/
					}
					/*�����������.�������(�������������);*/
					/*������������� = �����.���������������("������");*/
					/*�������������.���������.�����			= "" + �������.������������������������� + " " + ����������������.������������������������("����","���","����",�������.�������������������������) + " ������� � ���";*/
					/*�����������.�������(�������������);*/
					/*������������� = �����.���������������("������");*/
					/*�����������.�������(�������������);*/
				}
			}
			/*������.����� =
	"�������
	|	����������������������������������������.������.���� ��� ������,
	|	����������������������������������������.���������� ��� �����������,
	|	����������������������������������������.����������
	|��
	|	��������.�������������������������������.��������� ��� ����������������������������������������
	|���
	|	����������������������������������������.���������.������� = &�������
	|	� ����������������������������������������.������.��������
	|
	|����������� ��
	|	������";*/
			/*������������������ = ������.���������().���������();*/
			/*������.����� =
	"�������
	|	�����������.������������������������� ��� ������,
	|	�����(����������������������.����������) ��� ����������
	|��
	|	����������.���������������.������� ��� ����������������������
	|		���������� ���������� (�������
	|			���������������.���������������� ��� ����������������,
	|			��������(���������������.�������������������������) ��� �������������������������
	|		��
	|			(�������
	|				��������(����������������������.������.����������������) ��� ����������������,
	|				����������������������.������������������������� ��� �������������������������
	|			��
	|				����������.���������������.������� ��� ����������������������
	|			���
	|				����������������������.������.������� = &�������
	|			
	|			������������� ��
	|				����������������������.�������������������������) ��� ���������������
	|		
	|		������������� ��
	|			���������������.����������������) ��� �����������
	|		�� ����������������������.������.���������������� = �����������.����������������
	|			� (����������������������.������.������� = &�������)
	|
	|������������� ��
	|	�����������.�������������������������
	|
	|����������� ��
	|	������";*/
			/*��������������� = ������.���������().���������();*/
			/*������.����� =
	"�������
	|	0 ��� �����������,
	|	������������������.������� ��� ���������,
	|	������������������.������ ��� ����������,
	|	������������������.������������� ��� �������������
	|��
	|	�����������������.������������������ ��� ������������������
	|���
	|	������������������.������� = &�������
	|
	|����������� ��
	|	����������,
	|	�������������";*/
			/*��������������� = ������.���������().���������();*/
			/*����������� = 1;*/
			/*���������������		= �����������������(�������.��������������);*/
			/*����������������	= ?(���������������, �������.��������������, ����������������.�������������������());*/
			/*���������� = 86400;*/
			/*// ������� ������� ������� �� ��������� ���� ����� �������� ��� ����� ���� ����������,
*/
			/*// ��� �� ������� �������� ��� ���� ������ � �����
*/
			/*������ = ���������������.��������();*/
			/*������.�����������		= 0;*/
			/*������.���������		= �������;*/
			/*������.����������		= ���������������� + ����������;*/
			/*������.�������������	= ���������������� + ����������;*/
			/*// ������� ������� �� ����� ������� �������� ����
*/
			if(true/*�����������������(����������)*/)
			{
				/*����������������� = ���������(���������(����������));*/
				/*����������� = -1;*/
				while(true/*����������������� < ����������������*/)
				{
					/*������ = ���������������.��������();*/
					/*������.�����������		= �����������;*/
					/*������.���������		= �������;*/
					/*������.����������		= �����������������;*/
					/*������.�������������	= �����������������;*/
					/*����������������� = ���������(���������(���������(�����������������)+1));*/
					/*����������� = ����������� - 1;*/
				}
				/*;;*/
			}
			/*���������������.�����������("�����������");*/
			/*������� = �������������������������������������������.�����������������������������������������(���������������, ������);*/
			/*// ������ ������� � ����������� �� �������
*/
			/*���������������			= ����� ������;*/
			/*// ������� � ��������
*/
			/*����������������������	= ����� ���������������;*/
			/*����������������������.�������.��������("������");*/
			/*����������������������.�������.��������("�������������������������");*/
			/*����������������������.�������.��������("�������������");*/
			while(true/*�������.���������()*/)
			{
				if(true/*�������.����������� = 0*/)
				{
					/*// ������� ������� �� ������� ����/���� ����������
*/
					/*�������������������		= �������.���������� + �������.�����������������������������;*/
					/*������������� = �����.���������������("������");*/
					/*���������������.��������(�������������);*/
					/*������������� = �����.���������������("�����");*/
					if(true/*���������������*/)
					{
						/*�������������.���������.������		= "�� ���� ����������, " + ������(����������������, ����������);*/
					}
					/*���������������.��������(�������������);*/
					if(true/*������������������� >= 0*/)
					{
						/*������������� = �����.���������������("������");*/
						/*�������������.���������.�����			= "���������������� ������";*/
						/*�������������.���������.��������������	= "" + ������������������� + " " + ����������������.������������������������("����","���","����",�������������������);*/
					}
					/*���������������.��������(�������������);*/
					if(true/*(������������������� >= 0 � �������.������������������������������������ > 0 � �������.����������������������������� > 0)
				��� (������������������� < 0 � �������.������������������������������������ < 0 � �������.����������������������������� < 0)*/)
					{
						/*������������� = �����.���������������("������");*/
						/*�������������.���������.�����			= "�� ���";*/
						/*�����������.�������(�������������);*/
						/*���������� = "     ";*/
					}
					if(true/*������������������� >= 0*/)
					{
						if(true/*�������.������������������������������������ > 0*/)
						{
							/*������������� = �����.���������������("������");*/
							/*�������������.���������.�����			= ���������� + "������� ������� ���";*/
							/*�������������.���������.��������������	= "" + �������.������������������������������������ + " " + ����������������.������������������������("����","���","����",�������.������������������������������������);*/
							/*���������������.��������(�������������);*/
						}
						if(true/*�������.����������������������������� > 0*/)
						{
							/*������������� = �����.���������������("������");*/
							/*�������������.���������.�����			= ���������� + "�������������� ������";*/
							/*�������������.���������.��������������	= "" + �������.����������������������������� + " " + ����������������.������������������������("����","���","����",�������.�����������������������������);*/
							/*���������������.��������(�������������);*/
						}
					}
				}
			}
			/*����������������������.�����������("������, �������������������������");*/
			/*������������� = ������(�������);*/
			/*����������������������.�����������(����������������������, �������������, 2, , �������������);*/
			return null;
		}

		public void �����������������������������������������������(/*�������, ��������� = ������������*/)
		{
			/*������������� = "";*/
			/*����������� = ������������������������������������������������������������������(�������, �������������, ���������);*/
			/*����������������������.������������������(�����������, , , "������� " + �������������);*/
		}
		// ������� ��������� ��������� �������� � �������� ������ "������ ������������ � ����".
		//
		// ���������
		//  ������������������ - ��������, �� �������� ����������� ������
		//		��������� ��������� ��������� ��� �������� � ������� �����������
		//  ��������� - ������, ��������� �������� � ������� �����������
		//  ������������� - ������, ������������ ��� ������������� ������ ��� � ����������
		// ������������ ��������:
		//  ��������� �������� - �������� �����
		//

		public object ������������������������(/*������������������, ���������, ������������� = ������*/)
		{
			/*����������� = ����� �����������������;*/
			/*�����������.��������� = 0;*/
			/*�����������.���������� = 0;*/
			/*�����������.������������������� = "���������_������_������������������";*/
			/*����� 		= ������������������("�������������������������������");*/
			/*// �������� ������ ��� ������
*/
			/*��������������� = ��������������������������������������(������������������).���������().�������();*/
			/*���������������� = ����������������������������������������(������������������.����, ���������, �������������).���������().�������();*/
			/*// ������������ ���������� ������� ��������� - ��� ����������� ��������� �� ��������
*/
			/*������������������� = ����������������.����������();*/
			/*��������������������������� = �����.���������������("��������������");*/
			/*������������������			= �����.���������������("�����");*/
			/*������������������� 		= �����.���������������("������");*/
			/*��������������������������� = �����.���������������("�����������");*/
			/*������������������� 		= �����.���������������("������");*/
			/*// ������ � ����� �������� - ��� ��������� �� ��������
*/
			/*���������������� = ����� ������();*/
			/*����������������.��������(�������������������);*/
			/*����������������.��������(���������������������������);*/
			/*// ������� ������ � ������������� �����������
*/
			while(true/*���������������.���������()*/)
			{
				/*���������������������������.���������.���������(���������������);*/
				/*// ����� ���������.
*/
				/*���������������������������.���������.������������������� = ������(���������������������������.���������.�������������������);*/
				/*�������������������.���������.���������(���������������);*/
				/*�������������������.���������.���������(���������������);*/
				/*// �������
*/
			}
			/*;
	
	�����������.�������(���������������������������);*/
			/*�����������.�������(������������������);*/
			/*��������������� = 1;*/
			/*������������� = 0;*/
			/*��������������� = 0;*/
			/*����� = 0;*/
			/*// ������� ������ �� ������� ���������.
*/
			while(true/*����������������.���������()*/)
			{
				/*// ��������� �� ��������
*/
				/*������������� = ������������� + 1;*/
				/*�������������������.���������.���������(����������������);*/
				/*�������������������.���������.����������� = �������������;*/
				/*// ��������, ��������� �� ������ �� �������� ��� ���� ��������� ����� ��������
*/
				/*������������������ = �� ������������������������.���������������������������������(�����������, ����������������);*/
				if(true/*�� ������������������ � ������������� = �������������������*/)
				{
					/*����������������.��������(�������������������);*/
					/*������������������ = �� ������������������������.���������������������������������(�����������, ����������������);*/
				}
				if(true/*������������������*/)
				{
					/*���������������������������.���������.��������������� = ���������������;*/
					/*�����������.�������(���������������������������);*/
					/*�����������.���������������������������������������();*/
					/*�����������.�������(������������������);*/
					/*��������������� = ��������������� + 1;*/
					/*��������������� = 0;*/
				}
				/*�����������.�������(�������������������);*/
				/*��������������� = ��������������� + ����������������.�����;*/
				/*����� = ����� + ����������������.�����;*/
			}
			if(true/*������������� > 0*/)
			{
				/*���������������������������.���������.��������������� = ���������������;*/
			}
			/*���������������� = ����� ������();*/
			/*����������������.��������(�������������������);*/
			/*����������������.��������(���������������������������);*/
			/*����������������.��������(�������������������);*/
			/*�������������������.���������.������� = " " + �������.�� + " ";*/
			while(true/*������������������������.���������������������������������(�����������, ����������������, ����)*/)
			{
				/*�����������.�������(�������������������);*/
			}
			/*;
	
	�����������.�������(���������������������������);*/
			/*�������������������.���������.����� = �����;*/
			/*�����������.�������(�������������������);*/
			return null;
		}
		// ������������������������()
		////////////////////////////////////////////////////////////////////////////////
		// ��������� � ������� �������

		public object ��������������������������������������(/**/)
		{
			return null;
		}
	}
}

