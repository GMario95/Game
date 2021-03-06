﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
	public int id;
	public string name;
	public ItemType type;

	public Item(int id, string name, ItemType type) {
		this.id = id;
		this.name = name;
		this.type = type;
	}

	public enum ItemType { Discoverable, Interactable, NonInteractable }
}
