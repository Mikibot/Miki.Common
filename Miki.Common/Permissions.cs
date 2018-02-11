﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Miki.Common
{
	public enum DiscordGuildPermission : byte
	{
		CreateInstantInvite = 0,
		KickMembers = 1,
		BanMembers = 2,
		Administrator = 3,
		ManageChannels = 4,
		ManageGuild = 5,
		ReadMessages = 10,
		SendMessages = 11,
		SendTTSMessages = 12,
		ManageMessages = 13,
		EmbedLinks = 14,
		AttachFiles = 15,
		ReadMessageHistory = 16,
		MentionEveryone = 17,
		UseExternalEmojis = 18,
		Connect = 20,
		Speak = 21,
		MuteMembers = 22,
		DeafenMembers = 23,
		MoveMembers = 24,
		UseVAD = 25,
		ChangeNickname = 26,
		ManageNicknames = 27,
		ManageRoles = 28,
		ManageWebhooks = 29,
		ManageEmojis = 30
	}

	public enum DiscordChannelPermission : byte
	{
		CreateInstantInvite = 0,
		ManageChannel = 4,
		ReadMessages = 10,
		SendMessages = 11,
		SendTTSMessages = 12,
		ManageMessages = 13,
		EmbedLinks = 14,
		AttachFiles = 15,
		ReadMessageHistory = 16,
		MentionEveryone = 17,
		UseExternalEmojis = 18,
		Connect = 20,
		Speak = 21,
		MuteMembers = 22,
		DeafenMembers = 23,
		MoveMembers = 24,
		UseVAD = 25,
		ManagePermissions = 28
	}
}
