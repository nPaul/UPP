using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.�����������
{
	public partial class �������������������������������������������������
	{
		////////////////////////////////////////////////////////////////////////////////
		// ��������������� ���������, �������
		////////////////////////////////////////////////////////////////////////////////
		// ���������, ������� �������
		// ��������� ����� ������� � ��������� ���
		//
		// ���������
		//  ����������		� �������� �������
		//  �������������	� �������� �������
		//
		// ������������ ��������:
		//  ��������� ���������� �������
		//

		public object ������������������(/*����������� = ������������, ����������, �������������, ����������������������������� = 0*/)
		{
			/*������ = ����� ������;*/
			/*������.����������������������� = ����� �����������������������;*/
			/*������.������������������("����������",		����������);*/
			/*������.������������������("�������������",	�������������);*/
			/*������.������������������("�����������",	�����������);*/
			/*���������������������� =
	"������� �����������
	|	��������(����������������������.���������) ��� ���������,
	|	����������������������.���������.������� ��� �������,
	|	1 ��� ���������
	|��������� �������������������
	|��
	|	���������������.��������������������.�������������(&�������������, ���������.������������ = ��������(������������.�������������������������.�������������������)) ��� ����������������������
	|���
	|	�����
	|			����� ����������������������.���������������� <= &�������������
	|					� ����������������������.���������������� <> ���������(1, 1, 1)
	|				����� ����������������������.�����������������������������������
	|			����� ����������������������.�������������������������
	|		����� <> ��������(������������.�������������������������.����������)
	|
	|������������� ��
	|	����������������������.���������.�������
	|
	|����������
	|
	|�������
	|	��������(�������������������������.���������),
	|	�������������������������.���������.�������,
	|	2
	|��
	|	���������������.��������������������.�������������(&�������������, ���������.������������ = ��������(������������.�������������������������.����������������)) ��� �������������������������
	|���
	|	�����
	|			����� �������������������������.���������������� <= &�������������
	|					� �������������������������.���������������� <> ���������(1, 1, 1)
	|				����� �������������������������.�����������������������������������
	|			����� �������������������������.�������������������������
	|		����� <> ��������(������������.�������������������������.����������)
	|
	|������������� ��
	|	�������������������������.���������.�������
	|
	|����������
	|
	|�������
	|	��������(������������.������),
	|	������������.�������,
	|	�����
	|		����� ������������.����������� = ��������(������������.�����������������������.���������������������)
	|			����� 3
	|		����� ������������.����������� = ��������(������������.�����������������������.���������������)
	|			����� 4
	|		����� 5
	|	�����
	|��
	|	����������.��������������������� ��� ������������
	|
	|������������� ��
	|	������������.�������,
	|	�����
	|		����� ������������.����������� = ��������(������������.�����������������������.���������������������)
	|			����� 3
	|		����� ������������.����������� = ��������(������������.�����������������������.���������������)
	|			����� 4
	|		����� 5
	|	�����
	|
	|������������� ��
	|	�������,
	|	���������";*/
			/*������.����� = ����������������������;*/
			/*������.���������();*/
			/*���������������������� = "�������������������";*/
			/*������������������������ =
	"������� �����������
	|	�������������������.������� ��� �������,
	|	�������(�������������������.���������) ��� ���������
	|��������� ���������������������
	|��
	|	(�������
	|		����������������������.���������.������� ��� �������,
	|		1 ��� ���������
	|	��
	|		���������������.��������������������.�������������(&�������������, ���������.������������ = ��������(������������.�������������������������.�������������������)) ��� ����������������������
	|	���
	|		�����
	|				����� ����������������������.���������������� <= &�������������
	|						� ����������������������.���������������� <> ���������(1, 1, 1)
	|					����� ����������������������.�����������������������������������
	|				����� ����������������������.�������������������������
	|			����� <> ��������(������������.�������������������������.����������)
	|	
	|	����������
	|	
	|	�������
	|		�������������������������.���������.�������,
	|		2
	|	��
	|		���������������.��������������������.�������������(&�������������, ���������.������������ = ��������(������������.�������������������������.����������������)) ��� �������������������������
	|	���
	|		�����
	|				����� �������������������������.���������������� <= &�������������
	|						� �������������������������.���������������� <> ���������(1, 1, 1)
	|					����� �������������������������.�����������������������������������
	|				����� �������������������������.�������������������������
	|			����� <> ��������(������������.�������������������������.����������)
	|	
	|	����������
	|	
	|	�������
	|		������������.�������,
	|		�����
	|			����� ������������.����������� = ��������(������������.�����������������������.���������������������)
	|				����� 3
	|			����� ������������.����������� = ��������(������������.�����������������������.���������������)
	|				����� 4
	|			����� 5
	|		�����
	|	��
	|		����������.��������������������� ��� ������������) ��� �������������������
	|
	|������������� ��
	|	�������������������.�������
	|
	|������������� ��
	|	�������,
	|	���������";*/
			/*������.����� = ������������������������;*/
			/*������.���������();*/
			/*������������������������ = "���������������������";*/
			/*������.����� =
	"�������" + ?(����������������������������� = 0, "", " ������ " + �����������������������������) + "
	|	�������������������.�������������,
	|	����������.���������,
	|	�������������������.�������,
	|	�������������������.�������.��� ��� ���,
	|	�������������������.������������������,
	|	�������������������.�������������,
	|	�������������������.���������,
	|	�������������������.����������������,
	|	NULL ��� ��������������,
	|	�������������������.������������ ��� ������������,
	|	�����
	|		����� ���������.������������������������� = ��������(������������.�������������������������.����������)
	|			����� ��������(������������.�����������������������������.����������)
	|		����� ��������(������������.�����������������������������.��������)
	|	����� ��� ���������,
	|	NULL ��� �����������,
	|	������ ��� ������������������,
	|	����������.���������.������������,
	|	NULL ��� �����������������������
	|��
	|	(�������
	|		��������(���������.������) ��� ������������,
	|		����������������������������.������������� ��� �������������,
	|		����������������������������.������� ��� �������,
	|		����������������������������.������������������ ��� ������������������,
	|		����������������������������.������������� ��� �������������,
	|		����������������������������.��������� ��� ���������,
	|		����������������������������.���������������� ��� ����������������,
	|		����������������������������.������������ ��� ������������
	|	��
	|		���������������.���������������������������� ��� ����������������������������
	|			����� ���������� ���������������.��������� ��� ���������
	|			�� ����������������������������.������������� >= ���������.������
	|				� ����������������������������.������� = ���������.�������
	|	���
	|		����������������������������.������������������ = ��������(������������.����������������������������.�����������)
	|		� ����������������������������.������� � (������� ��������� ������� �� ���������������������)";*/
			if(true/*�����������������(����������)*/)
			{
				/*������.����� = ������.����� + "
	|		� ����������������������������.������������� >= &����������";*/
			}
			if(true/*�����������������(�������������)*/)
			{
				/*������.����� = ������.����� + "
	|		� ����������������������������.������������� <= &�������������";*/
			}
			/*������.����� = ������.����� + "
	|	
	|	������������� ��
	|		����������������������������.�������������,
	|		����������������������������.������������������,
	|		����������������������������.�������������,
	|		����������������������������.���������,
	|		����������������������������.����������������,
	|		����������������������������.������������,
	|		����������������������������.�������) ��� �������������������
	|		����� ���������� ���������������.��������� ��� ���������
	|		�� �������������������.������������ = ���������.������
	|			� �������������������.������� = ���������.�������
	|		���������� ���������� (�������
	|			�����������������.��������� ��� ���������,
	|			�����������������.������� ��� �������
	|		��
	|			" + ���������������������� + " ��� �����������������
	|			���������� ���������� " + ������������������������ + " ��� �������������������
	|			�� �����������������.������� = �������������������.�������
	|				� �����������������.��������� = �������������������.���������) ��� ����������
	|		�� �������������������.������� = ����������.�������
	|���
	|	�����
	|			����� ���������.������������������������� = ��������(������������.�������������������������.����������)
	|				����� ������
	|			����� �������������������.������������������ = ��������(������������.����������������������������.�����������)
	|				����� �����
	|						����� �������������������.������������� = ���������.�������������
	|								� �������������������.��������� = ���������.���������
	|								� �������������������.���������������� = ���������.����������������
	|								� �������������������.������������ = ���������.������������
	|							����� ������
	|						����� ����
	|					�����
	|			����� �����
	|					����� (�� �������������������.������������������ � (��������(������������.����������������������������.����������������������������), ��������(������������.����������������������������.����������������������������������), ��������(������������.����������������������������.����������), ��������(������������.����������������������������.�����������)))
	|						����� ������
	|					����� ����
	|				�����
	|		����� = ����
	|
	|����������
	|
	|�������" + ?(����������������������������� = 0, "", " ������ " + �����������������������������) + "
	|	�������������������.�������������,
	|	����������.���������,
	|	�������������������.�������,
	|	�������������������.�������.���,
	|	�������������������.������������������,
	|	���������.�������������,
	|	NULL,
	|	NULL,
	|	NULL,
	|	NULL,
	|	�����
	|		����� ���������.������������������������� = ��������(������������.�������������������������.����������)
	|			����� ��������(������������.�����������������������������.����������)
	|		����� ��������(������������.�����������������������������.��������)
	|	�����,
	|	NULL,
	|	������,
	|	����������.���������.������������,
	|	NULL
	|��
	|	(�������
	|		����������������������������.������������� ��� �������������,
	|		����������������������������.������� ��� �������,
	|		����������������������������.������������������ ��� ������������������,
	|		��������(���������.������) ��� ������������
	|	��
	|		���������������.���������������������������� ��� ����������������������������
	|			����� ���������� ���������������.��������� ��� ���������
	|			�� (�������������(����������������������������.�������������, ����, 1) >= ���������.������)
	|				� ����������������������������.������� = ���������.�������
	|	���
	|		����������������������������.������������������ � (��������(������������.����������������������������.����������), ��������(������������.����������������������������.����������������������������������))
	|		� ����������������������������.������� � (������� ��������� ������� �� ���������������������)";*/
			if(true/*�����������������(����������)*/)
			{
				/*������.����� = ������.����� + "
	|		� ����������������������������.������������� >= &����������";*/
			}
			if(true/*�����������������(�������������)*/)
			{
				/*������.����� = ������.����� + "
	|		� ����������������������������.������������� <= &�������������";*/
			}
			/*������.����� = ������.����� + "
	|	
	|	������������� ��
	|		����������������������������.�������������,
	|		����������������������������.������������������,
	|		����������������������������.�������) ��� �������������������
	|		����� ���������� ���������������.��������� ��� ���������
	|		�� �������������������.������������ = ���������.������
	|			� �������������������.������� = ���������.�������
	|		���������� ���������� (�������
	|			�����������������.��������� ��� ���������,
	|			�����������������.������� ��� �������
	|		��
	|			" + ���������������������� + " ��� �����������������
	|			���������� ���������� " + ������������������������ + " ��� �������������������
	|			�� �����������������.������� = �������������������.�������
	|				� �����������������.��������� = �������������������.���������) ��� ����������
	|		�� �������������������.������� = ����������.�������
	|���
	|	�����
	|			����� ���������.������������������������� = ��������(������������.�������������������������.����������)
	|				����� ������
	|			����� �����
	|					����� (�� �������������������.������������������ � (��������(������������.����������������������������.����������������������������), ��������(������������.����������������������������.����������������������������������), ��������(������������.����������������������������.����������), ��������(������������.����������������������������.�����������)))
	|						����� ������
	|					����� ����
	|				�����
	|		����� = ����
	|
	|����������
	|
	|�������" + ?(����������������������������� = 0, "", " ������ " + �����������������������������) + "
	|	�������������������.�������������,
	|	����������.���������,
	|	�������������������.�������,
	|	�������������������.�������.���,
	|	�������������������.������������������,
	|	���������.�������������,
	|	NULL,
	|	NULL,
	|	NULL,
	|	NULL,
	|	�����
	|		����� ���������.������������������������� = ��������(������������.�������������������������.����������)
	|			����� ��������(������������.�����������������������������.����������)
	|		����� ��������(������������.�����������������������������.��������)
	|	�����,
	|	NULL,
	|	������,
	|	����������.���������.������������,
	|	NULL
	|��
	|	(�������
	|		��������(����������������������������.�������������) ��� �������������,
	|		����������������������������.������� ��� �������,
	|		����������������������������.������������������ ��� ������������������,
	|		��������(���������.������) ��� ������������
	|	��
	|		���������������.���������������������������� ��� ����������������������������
	|			����� ���������� ���������������.��������� ��� ���������
	|			�� (�������������(����������������������������.�������������, ����, 1) >= ���������.������)
	|				� ����������������������������.������� = ���������.�������
	|	���
	|		����������������������������.������������������  = ��������(������������.����������������������������.����������������������������)
	|		� ����������������������������.������� � (������� ��������� ������� �� ���������������������)
	|	
	|	������������� ��
	|		����������������������������.������������������,
	|		����������������������������.�������) ��� �������������������
	|		����� ���������� ���������������.��������� ��� ���������
	|		�� �������������������.������������ = ���������.������
	|			� �������������������.������� = ���������.�������
	|		���������� ���������� (�������
	|			�����������������.��������� ��� ���������,
	|			�����������������.������� ��� �������
	|		��
	|			" + ���������������������� + " ��� �����������������
	|			���������� ���������� " + ������������������������ + " ��� �������������������
	|			�� �����������������.������� = �������������������.�������
	|				� �����������������.��������� = �������������������.���������) ��� ����������
	|		�� �������������������.������� = ����������.�������
	|		���������� ���������� ���������������.���������������������������������������.�������������(, ������� � (������� ��������� ������� �� ���������������������)) ��� ���������������������������������������
	|		�� �������������������.������� = ���������������������������������������.�������
	|			� ���������������������������������������.��������� = ��������(������������.��������������������������������������.�������������������������)
	|���
	|	�����
	|			����� ���������.������������������������� = ��������(������������.�������������������������.����������)
	|				����� ������
	|			����� �����
	|					����� (�� �������������������.������������������ � (��������(������������.����������������������������.����������������������������), ��������(������������.����������������������������.����������������������������������), ��������(������������.����������������������������.����������), ��������(������������.����������������������������.�����������)))
	|						����� ������
	|					����� ����
	|				�����
	|		����� = ����";*/
			if(true/*�����������������(����������)*/)
			{
				/*������.����� = ������.����� + "
	|		� �������������������.������������� >= &����������";*/
			}
			if(true/*�����������������(�������������)*/)
			{
				/*������.����� = ������.����� + "
	|		� �������������������.������������� <= &�������������";*/
			}
			/*������.����� = ������.����� + "
	|
	|����������
	|
	|�������" + ?(����������������������������� = 0, "", " ������ " + �����������������������������) + "
	|	�������������������.�������������,
	|	�������������������.���������,
	|	�������������������.���������.�������,
	|	�������������������.���������.�������.���,
	|	�������������������.������������������,
	|	�������������������.�������������,
	|	�������������������.���������,
	|	�������������������.����������������,
	|	NULL,
	|	�������������������.������������,
	|	�����
	|		����� �����
	|				����� ��������������������.���������������� <= �������������������.�������������
	|						� ��������������������.���������������� <> ���������(1, 1, 1)
	|					����� ��������������������.�����������������������������������
	|				����� ��������������������.�������������������������
	|			����� = ��������(������������.�������������������������.����������)
	|			����� ��������(������������.�����������������������������.����������)
	|		����� ��������(������������.�����������������������������.��������)
	|	�����,
	|	�������������������.�����������,
	|	����,
	|	�������������������.���������.������������,
	|	�������������������.�����������.������������
	|��
	|	(�������
	|		��������(��������������������.������) ��� ������������,
	|		����������������������������.������������� ��� �������������,
	|		����������������������������.��������� ��� ���������,
	|		����������������������������.������������������ ��� ������������������,
	|		����������������������������.������������������������ ��� �������������,
	|		����������������������������.��������� ��� ���������,
	|		����������������������������.���������������� ��� ����������������,
	|		����������������������������.������������ ��� ������������,
	|		�����
	|			����� ����������������������������.�����������.������������������� = ��������(����������.�����������.������������)
	|				����� ����������������������������.�����������
	|			����� ����������������������������.�����������.�������������������
	|		����� ��� �����������
	|	��
	|		���������������.���������������������������� ��� ����������������������������
	|			����� ���������� ���������������.�������������������� ��� ��������������������
	|			�� ����������������������������.������������� >= ��������������������.������
	|				� ����������������������������.��������� = ��������������������.���������
	|	���
	|		����������������������������.������������������ = ��������(������������.����������������������������.�����������)
	|		� ����������������������������.��������� � (������� ��������� ��������� �� �������������������)";*/
			if(true/*�����������������(����������)*/)
			{
				/*������.����� = ������.����� + "
	|		� ����������������������������.������������� >= &����������";*/
			}
			if(true/*�����������������(�������������)*/)
			{
				/*������.����� = ������.����� + "
	|		� ����������������������������.������������� <= &�������������";*/
			}
			if(true/*����������� <> ������������*/)
			{
				/*������.����� = ������.����� + "
	|		� ����������������������������.����������� �(&�����������)
	|		� ����������������������������.������������������������.�������� �(&�����������)";*/
			}
			/*������.����� = ������.����� + "
	|	
	|	������������� ��
	|		����������������������������.�������������,
	|		����������������������������.������������������,
	|		����������������������������.������������������������,
	|		����������������������������.���������,
	|		����������������������������.����������������,
	|		����������������������������.������������,
	|		����������������������������.�����������,
	|		�����
	|			����� ����������������������������.�����������.������������������� = ��������(����������.�����������.������������)
	|				����� ����������������������������.�����������
	|			����� ����������������������������.�����������.�������������������
	|		�����,
	|		����������������������������.���������) ��� �������������������
	|		����� ���������� ���������������.�������������������� ��� ��������������������
	|		�� �������������������.������������ = ��������������������.������
	|			� �������������������.��������� = ��������������������.���������
	|���
	|	�����
	|			����� �����
	|					����� ��������������������.���������������� <= &�������������
	|							� ��������������������.���������������� <> ���������(1, 1, 1)
	|						����� ��������������������.�����������������������������������
	|					����� ��������������������.�������������������������
	|				����� = ��������(������������.�������������������������.����������)
	|				����� ������
	|			����� �������������������.������������������ = ��������(������������.����������������������������.�����������)
	|				����� �����
	|						����� �������������������.������������� = ��������������������.������������������������
	|								� �������������������.��������� = ��������������������.���������
	|								� �������������������.���������������� = ��������������������.����������������
	|								� �������������������.������������ = ��������������������.������������
	|							����� ������
	|						����� ����
	|					�����
	|			����� �����
	|					����� (�� �������������������.������������������ � (��������(������������.����������������������������.����������������������������), ��������(������������.����������������������������.����������������������������������), ��������(������������.����������������������������.����������), ��������(������������.����������������������������.�����������)))
	|						����� ������
	|					����� ����
	|				�����
	|		����� = ����
	|
	|����������
	|
	|�������" + ?(����������������������������� = 0, "", " ������ " + �����������������������������) + "
	|	�������������������.�������������,
	|	�������������������.���������,
	|	�������������������.���������.�������,
	|	�������������������.���������.�������.���,
	|	�������������������.������������������,
	|	NULL,
	|	NULL,
	|	NULL,
	|	�������������������.��������������,
	|	NULL,
	|	������������������������������.���������,
	|	�������������������.�����������,
	|	����,
	|	�������������������.���������.������������,
	|	�������������������.�����������.������������
	|��
	|	(�������
	|		��������(������������������������������.������) ��� ������������,
	|		����������������������������.������������� ��� �������������,
	|		����������������������������.��������� ��� ���������,
	|		����������������������������.������������������ ��� ������������������,
	|		����������������������������.�������������� ��� ��������������,
	|		�����
	|			����� ����������������������������.�����������.������������������� = ��������(����������.�����������.������������)
	|				����� ����������������������������.�����������
	|			����� ����������������������������.�����������.�������������������
	|		����� ��� �����������
	|	��
	|		���������������.���������������������������� ��� ����������������������������
	|			����� ���������� ���������������.������������������������������ ��� ������������������������������
	|			�� ����������������������������.������������� >= ������������������������������.������
	|				� ����������������������������.��������� = ������������������������������.���������
	|	���
	|		����������������������������.������������������ � (��������(������������.����������������������������.������������), ��������(������������.����������������������������.���������������������������), ��������(������������.����������������������������.���������������), ��������(������������.����������������������������.�����������������������), ��������(������������.����������������������������.�������������))
	|		� ����������������������������.��������� � (������� ��������� ��������� �� �������������������)";*/
			if(true/*�����������������(����������)*/)
			{
				/*������.����� = ������.����� + "
	|		� ����������������������������.������������� >= &����������";*/
			}
			if(true/*�����������������(�������������)*/)
			{
				/*������.����� = ������.����� + "
	|		� ����������������������������.������������� <= &�������������";*/
			}
			if(true/*����������� <> ������������*/)
			{
				/*������.����� = ������.����� + "
	|		� ����������������������������.����������� �(&�����������)";*/
			}
			/*������.����� = ������.����� + "
	|	
	|	������������� ��
	|		����������������������������.�������������,
	|		����������������������������.������������������,
	|		����������������������������.��������������,
	|		����������������������������.�����������,
	|		�����
	|			����� ����������������������������.�����������.������������������� = ��������(����������.�����������.������������)
	|				����� ����������������������������.�����������
	|			����� ����������������������������.�����������.�������������������
	|		�����,
	|		����������������������������.���������) ��� �������������������
	|		����� ���������� ���������������.������������������������������ ��� ������������������������������
	|		�� �������������������.������������ = ������������������������������.������
	|			� �������������������.��������� = ������������������������������.���������
	|���
	|	�����
	|			����� ������������������������������.��������� = ��������(������������.�����������������������������.������������)
	|					� �������������������.������������������ <> ��������(������������.����������������������������.������������)
	|				����� ������
	|			����� ������������������������������.��������� = ��������(������������.�����������������������������.���������������)
	|					� �������������������.������������������ <> ��������(������������.����������������������������.���������������)
	|				����� ������
	|			����� ������������������������������.��������� = ��������(������������.�����������������������������.�������������)
	|					� �������������������.������������������ <> ��������(������������.����������������������������.�������������)
	|				����� ������
	|			����� ������������������������������.��������� = ��������(������������.�����������������������������.�����������������������)
	|					� �������������������.������������������ <> ��������(������������.����������������������������.�����������������������)
	|				����� ������
	|			����� ������������������������������.��������� = ��������(������������.�����������������������������.���������������������������)
	|					� �������������������.������������������ <> ��������(������������.����������������������������.���������������������������)
	|				����� ������
	|			����� ������������������������������.��������� = ��������(������������.�����������������������������.��������)
	|					� (�� �������������������.������������������ � (��������(������������.����������������������������.����������������������������), ��������(������������.����������������������������.����������������������������������), ��������(������������.����������������������������.����������), ��������(������������.����������������������������.�����������)))
	|				����� ������
	|			����� ������������������������������.��������� = ��������(������������.�����������������������������.����������)
	|				����� ������
	|			����� ������������������������������.��������� ���� NULL 
	|				����� ������
	|			����� ����
	|		����� = ����
	|
	|����������
	|
	|�������" + ?(����������������������������� = 0, "", " ������ " + �����������������������������) + "
	|	�������������������.�������������,
	|	�������������������.���������,
	|	�������������������.���������.�������,
	|	�������������������.���������.�������.���,
	|	�������������������.������������������,
	|	NULL,
	|	NULL,
	|	NULL,
	|	NULL,
	|	NULL,
	|	�����
	|		����� �����
	|				����� ��������������������.���������������� <= �������������(�������������������.�������������, ����, 1)
	|						� ��������������������.���������������� <> ���������(1, 1, 1)
	|					����� ��������������������.�����������������������������������
	|				����� ��������������������.�������������������������
	|			����� = ��������(������������.�������������������������.����������)
	|			����� ��������(������������.�����������������������������.����������)
	|		����� ��������(������������.�����������������������������.��������)
	|	�����,
	|	�������������������.�����������,
	|	����,
	|	�������������������.���������.������������,
	|	�������������������.�����������.������������
	|��
	|	(�������
	|		����������������������������.������������� ��� �������������,
	|		����������������������������.��������� ��� ���������,
	|		����������������������������.������������������ ��� ������������������,
	|		��������(��������������������.������) ��� ������������,
	|		�����
	|			����� ����������������������������.�����������.������������������� = ��������(����������.�����������.������������)
	|				����� ����������������������������.�����������
	|			����� ����������������������������.�����������.�������������������
	|		����� ��� �����������
	|	��
	|		���������������.���������������������������� ��� ����������������������������
	|			����� ���������� ���������������.�������������������� ��� ��������������������
	|			�� (�������������(����������������������������.�������������, ����, 1) >= ��������������������.������)
	|				� ����������������������������.��������� = ��������������������.���������
	|	���
	|		����������������������������.������������������ � (��������(������������.����������������������������.����������), ��������(������������.����������������������������.����������������������������������))
	|		� ����������������������������.��������� � (������� ��������� ��������� �� �������������������)";*/
			if(true/*�����������������(����������)*/)
			{
				/*������.����� = ������.����� + "
	|		� ����������������������������.������������� >= &����������";*/
			}
			if(true/*�����������������(�������������)*/)
			{
				/*������.����� = ������.����� + "
	|		� ����������������������������.������������� <= &�������������";*/
			}
			if(true/*����������� <> ������������*/)
			{
				/*������.����� = ������.����� + "
	|		� ����������������������������.����������� �(&�����������)";*/
			}
			/*������.����� = ������.����� + "
	|	
	|	������������� ��
	|		����������������������������.�������������,
	|		����������������������������.������������������,
	|		����������������������������.�����������,
	|		�����
	|			����� ����������������������������.�����������.������������������� = ��������(����������.�����������.������������)
	|				����� ����������������������������.�����������
	|			����� ����������������������������.�����������.�������������������
	|		�����,
	|		����������������������������.���������) ��� �������������������
	|		����� ���������� ���������������.�������������������� ��� ��������������������
	|		�� �������������������.������������ = ��������������������.������
	|			� �������������������.��������� = ��������������������.���������
	|���
	|	�����
	|			����� �����
	|					����� ��������������������.���������������� <= �������������(�������������������.�������������, ����, 1)
	|							� ��������������������.���������������� <> ���������(1, 1, 1)
	|						����� ��������������������.�����������������������������������
	|					����� ��������������������.�������������������������
	|				����� = ��������(������������.�������������������������.����������)
	|				����� ������
	|			����� �����
	|					����� (�� �������������������.������������������ � (��������(������������.����������������������������.����������������������������), ��������(������������.����������������������������.����������������������������������), ��������(������������.����������������������������.����������), ��������(������������.����������������������������.�����������)))
	|						����� ������
	|					����� ����
	|				�����
	|		����� = ����
	|
	|����������
	|
	|�������" + ?(����������������������������� = 0, "", " ������ " + �����������������������������) + "
	|	�������������������.�������������,
	|	�������������������.���������,
	|	�������������������.���������.�������,
	|	�������������������.���������.�������.���,
	|	�������������������.������������������,
	|	NULL,
	|	NULL,
	|	NULL,
	|	NULL,
	|	NULL,
	|	�����
	|		����� �����
	|				����� ��������������������.���������������� <= �������������(�������������������.�������������, ����, 1)
	|						� ��������������������.���������������� <> ���������(1, 1, 1)
	|					����� ��������������������.�����������������������������������
	|				����� ��������������������.�������������������������
	|			����� = ��������(������������.�������������������������.����������)
	|			����� ��������(������������.�����������������������������.����������)
	|		����� ��������(������������.�����������������������������.��������)
	|	�����,
	|	�������������������.�����������,
	|	����,
	|	�������������������.���������.������������,
	|	�������������������.�����������.������������
	|��
	|	(�������
	|		��������(����������������������������.�������������) ��� �������������,
	|		����������������������������.��������� ��� ���������,
	|		����������������������������.������������������ ��� ������������������,
	|		��������(��������������������.������) ��� ������������,
	|		�����
	|			����� ����������������������������.�����������.������������������� = ��������(����������.�����������.������������)
	|				����� ����������������������������.�����������
	|			����� ����������������������������.�����������.�������������������
	|		����� ��� �����������
	|	��
	|		���������������.���������������������������� ��� ����������������������������
	|			����� ���������� ���������������.�������������������� ��� ��������������������
	|			�� (�������������(����������������������������.�������������, ����, 1) >= ��������������������.������)
	|				� ����������������������������.��������� = ��������������������.���������
	|	���
	|		����������������������������.������������������ = ��������(������������.����������������������������.����������������������������)
	|		� ����������������������������.��������� � (������� ��������� ��������� �� �������������������)";*/
			if(true/*����������� <> ������������*/)
			{
				/*������.����� = ������.����� + "
	|		� ����������������������������.����������� �(&�����������)";*/
			}
			/*������.����� = ������.����� + "
	|	
	|	������������� ��
	|		����������������������������.������������������,
	|		����������������������������.�����������,
	|		�����
	|			����� ����������������������������.�����������.������������������� = ��������(����������.�����������.������������)
	|				����� ����������������������������.�����������
	|			����� ����������������������������.�����������.�������������������
	|		�����,
	|		����������������������������.���������) ��� �������������������
	|		����� ���������� ���������������.�������������������� ��� ��������������������
	|		�� �������������������.������������ = ��������������������.������
	|			� �������������������.��������� = ��������������������.���������
	|		���������� ���������� ���������������.���������������������������������������.�������������(, ������� � (������� ��������� ������� �� ���������������������)) ��� ���������������������������������������
	|		�� �������������������.���������.������� = ���������������������������������������.�������
	|			� ���������������������������������������.��������� = ��������(������������.��������������������������������������.�������������������������)
	|���
	|	�����
	|			����� �����
	|					����� ��������������������.���������������� <= �������������(�������������������.�������������, ����, 1)
	|							� ��������������������.���������������� <> ���������(1, 1, 1)
	|						����� ��������������������.�����������������������������������
	|					����� ��������������������.�������������������������
	|				����� = ��������(������������.�������������������������.����������)
	|				����� ������
	|			����� �����
	|					����� (�� �������������������.������������������ � (��������(������������.����������������������������.����������������������������), ��������(������������.����������������������������.����������������������������������), ��������(������������.����������������������������.����������), ��������(������������.����������������������������.�����������)))
	|						����� ������
	|					����� ����
	|				�����
	|		����� = ����";*/
			if(true/*�����������������(����������)*/)
			{
				/*������.����� = ������.����� + "
	|		� �������������������.������������� >= &����������";*/
			}
			if(true/*�����������������(�������������)*/)
			{
				/*������.����� = ������.����� + "
	|		� �������������������.������������� <= &�������������";*/
			}
			return null;
		}
		// ������������������()

		public object ��������������������������������(/*������, ���������������, ����������������*/)
		{
			if(true/*������.������������������*/)
			{
				/*�����������������������������������������������.�������������������������������������(������, ���������������, ����������������);*/
			}
			return null;
		}
	}
}

