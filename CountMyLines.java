/*
 * Copyright (C) 2009 The Android Open Source Project
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 */
package com.android.providers.contacts;
import android.app.SearchManager;
import android.content.Context;

// Full-line comment
public class GlobalSearchSupport {
    public ArrayList<?> asList(String[] projection) {
	
        /* Full Line comment */
        ArrayList<Object> list = new ArrayList<Object>();
        if (projection == null) {
            list.add(filter); // THIS SHOULD BE COUNTED A LINE OF CODE AND AN INLINE COMMENT
            list.add(lastAccessTime); // CODE AND INLINE COMMENT
        }  
        return list;
    }

    // Another Comment
    public void reset() {
        contactId = 0;    
        photoUri = null; /* INLINE COMMENT WITH CODE */

    }
}