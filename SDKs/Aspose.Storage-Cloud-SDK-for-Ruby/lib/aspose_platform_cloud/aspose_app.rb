module AsposePlatformCloud
  class AsposeApp
    
    @@app_key = nil
    @app_sid = nil
    @access_token = nil
    
    def AsposeApp.app_key_and_sid(app_key, app_sid)
      @@app_key = app_key
      @@app_sid = app_sid
    end
    
    def AsposeApp.set_access_token(access_token)
      @@access_token = access_token
    end

    def AsposeApp.app_key
      @@app_key
    end

    def AsposeApp.app_sid
      @@app_sid
    end

    def AsposeApp.access_token
      @@access_token
    end
  end
end
